using Clio.Utilities;
using ff14bot;
using ff14bot.Managers;
using ff14bot.Navigation;
using ff14bot.Objects;
using Mud.Properties;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mud.Helpers
{
    public class Waypoint
    {
        public static DateTime LastHardpoint = DateTime.Now;

        public String Name;
        public Vector3 Location;
        public bool IsHardPoint;
        public Waypoint(GameObject obj)
        {
            bool hard = Waypoint.IsValid(obj.Location) 
                && DateTime.Now.Subtract(LastHardpoint) > TimeSpan.FromSeconds(5);
            if (hard)
                LastHardpoint = DateTime.Now;
            this.Name = obj.Name;
            this.Location = obj.Location;
            this.IsHardPoint = hard;
        }

        public Waypoint(GameObject obj, bool hardPoint)
        {
            this.Name = obj.Name;
            this.Location = obj.Location;
            this.IsHardPoint = hardPoint;
        }

        public Waypoint Ground()
        {
            Vector3 rayStart = new Vector3(this.Location.X, this.Location.Y + 0.25f, this.Location.Z);
            Vector3 rayEnd = new Vector3(this.Location.X, this.Location.Y - 10f, this.Location.Z);
            Vector3 hit;
            Vector3 distances;
            WorldManager.Raycast(rayStart, rayEnd, out hit, out distances);
            if (IsValid(hit))
                this.Location = hit;
            return this;
        }

        public float Distance(Waypoint other)
        {
            return (this.Location.Distance3D(other.Location));
        }

        public bool InLineOfSight(Waypoint other)
        {
            return InLineOfSight(other, 1) 
                && InLineOfSight(other, 2) 
                && InLineOfSight(other, 3);
        }

        private bool InLineOfSight(Waypoint other,int offsetY)
        {
            Vector3 start = Core.Player.Location;
            start.Y = start.Y + offsetY;
            Vector3 end = other.Location;
            end.Y = end.Y + offsetY;
            Vector3 hit;
            Vector3 distances;
            WorldManager.Raycast(start, end, out hit, out distances);
            return !IsValid(hit);
        }

        public bool IsCloserThan(Waypoint other)
        {
            return (Core.Player.Location.Distance3D(this.Location) < Core.Player.Location.Distance3D(other.Location));
        }

        public override string ToString()
        {
            return this.Name + " - " + this.Location.ToString() + " Hardpoint: " + this.IsHardPoint.ToString();
        }

        private static bool IsValid(Vector3 loc) {
            return !(loc.X == 0 && loc.Y == 0 && loc.Z == 0);
        }
    }

    public class WaypointManager
    {
        public const int WAYPOINT_DISTANCE = 2;
        public static bool IsNavigating = false;
        private static Queue<Waypoint> CurrentWaypoints = new Queue<Waypoint>();

        public static void Track()
        {
            GameObject moveTarget = MoveTarget;
            if (moveTarget != null)
            {
                if (CurrentWaypoints.Count > 0)
                {
                    Waypoint lastWaypoint = CurrentWaypoints.Last();
                    Waypoint nextWaypoint = new Waypoint(moveTarget);
                    if (lastWaypoint.Distance(nextWaypoint) > WAYPOINT_DISTANCE)
                    {
                        CurrentWaypoints.Enqueue(nextWaypoint.Ground());
                    }
                }
                else
                {
                    Waypoint nextWaypoint = new Waypoint(moveTarget).Ground();
                    CurrentWaypoints.Enqueue(nextWaypoint);
                }
            }
            //Logging.Write(LogLevel.INFO,"WaypointManager Tracking {0}: Waypoints - {1}, Next - {2}",moveTarget,CurrentWaypoints.Count,WaypointManager.Next);
        }

        private static GameObject _MoveTarget = null;
        private static GameObject MoveTarget
        {
            get
            {
                GameObject newTarget = null;
                IEnumerable<Character> targetTanks = MudBase.VisiblePartyMembers.Where(p => MudBase.IsTank(p) && p.Location.Distance3D(Core.Player.Location) >= (float)Settings.Default.AUTO_MOVE_FOLLOW_RANGE_MIN && Core.Player.Location.Distance3D(p.Location) <= (float)Settings.Default.MAX_TARGET_DISTANCE);
                if (Core.Player.HasTarget
                        && Core.Player.CurrentTarget.Location.Distance3D(Core.Player.Location) >= ((float)Settings.Default.AUTO_MOVE_TARGET_RANGE + Core.Player.CurrentTarget.CombatReach)
                        && Core.Player.Location.Distance3D(Core.Player.CurrentTarget.Location) <= (float)Settings.Default.MAX_TARGET_DISTANCE
                        && ((MudBase.IsValidEnemy(Core.Player.CurrentTarget)
                                && Core.Player.CurrentTarget.Location.Distance3D(Core.Player.Location) >= ((float)Settings.Default.AUTO_MOVE_TARGET_RANGE + Core.Player.CurrentTarget.CombatReach)
                                && (MudBase.MovementModes[Settings.Default.SELECTED_MOVEMENT_MODE].Equals("Combat")
                                    || (MudBase.MovementModes[Settings.Default.SELECTED_MOVEMENT_MODE].Equals("Tank") && MudBase.InCombat)))
                            || (!MudBase.IsValidEnemy(Core.Player.CurrentTarget)
                                && Core.Player.CurrentTarget.Location.Distance3D(Core.Player.Location) >= (float)Settings.Default.AUTO_MOVE_FOLLOW_RANGE_MIN
                                && MudBase.MovementModes[Settings.Default.SELECTED_MOVEMENT_MODE].Equals("Follow")))) 
                    newTarget = Core.Player.CurrentTarget;
                    //Logging.Write(LogLevel.WARNING,"New Target: {0}",newTarget); }
                else if (targetTanks.Count() > 0 && MudBase.MovementModes[Settings.Default.SELECTED_MOVEMENT_MODE].Equals("Tank"))
                    newTarget = targetTanks.First();
                if (_MoveTarget != newTarget)
                {
                    GameObject oldTarget = _MoveTarget;
                    _MoveTarget = newTarget;
                    WaypointManager.OnTargetChanged(oldTarget, newTarget);
                }
                return _MoveTarget;
            }
        }

        private static void OnTargetChanged(GameObject oldTarget,GameObject newTarget)
        {
            CurrentWaypoints.Clear();
            Track();
        }

        public static Waypoint Next
        {
            get
            {
                if (CurrentWaypoints.Count == 0)
                    return null;
                Waypoint peek = CurrentWaypoints.Peek();
                // Don't Skip Hardpoints
                if (CurrentWaypoints.Count > 1)
                {
                    Waypoint peek2 = CurrentWaypoints.ToArray()[1];
                    if (peek2.IsCloserThan(peek) && peek2.InLineOfSight(new Waypoint(Core.Player)))
                    {
                        Logging.Write(LogLevel.INFO, "Skipping Waypoint: {0}", CurrentWaypoints.Dequeue());
                        return Next;
                    }
                }
                if (peek.Distance(new Waypoint(Core.Player)) > 0.25)
                    return peek;
                Logging.Write(LogLevel.WARNING, "Reached Waypoint: {0}", CurrentWaypoints.Dequeue());
                //if(CurrentWaypoints.Count > 0)
                    //Logging.Write(LogLevel.PRIMARY, "Next Waypoint: {0}", CurrentWaypoints.Peek());
                return Next;
            }
        }

        internal static void MoveToNext()
        {
            GameObject moveTarget = MoveTarget;
            if (MoveTarget != null
                // Start Navigating If > Max range
                && ((!WaypointManager.IsNavigating 
                        && Core.Player.Location.Distance3D(moveTarget.Location) > (float)Settings.Default.AUTO_MOVE_FOLLOW_RANGE_MAX)
                    // Keep Navigating If > Min Range
                    || (WaypointManager.IsNavigating 
                        && (Core.Player.Location.Distance3D(moveTarget.Location) > (float)Settings.Default.AUTO_MOVE_FOLLOW_RANGE_MIN))
                    || (Core.Player.Location.Distance3D(moveTarget.Location) > ((float)Settings.Default.AUTO_MOVE_TARGET_RANGE + moveTarget.CombatReach)
                                && MudBase.IsValidEnemy(Core.Player.CurrentTarget)
                                && MudBase.InCombat)))
            {
                WaypointManager.IsNavigating = true;
                Waypoint player = new Waypoint(Core.Player);
                Waypoint next = WaypointManager.Next;
                // Use Gaia Navigator If Enabled & > Some Yards From Next Waypoint OR Not In LOS Of Next Waypoint
                if (Navigator.NavigationProvider is GaiaNavigator
                        && (player.Distance(next) > (float)(10 + Settings.Default.AUTO_MOVE_FOLLOW_RANGE_MIN)
                            || !player.InLineOfSight(next)))
                {
                    //Logging.Write(LogLevel.WARNING, "MoveTo: {0}", next);
                    Navigator.NavigationProvider.MoveTo(next.Location);
                    Waypoint.LastHardpoint = DateTime.Now;
                }
                else if (Navigator.NavigationProvider is GaiaNavigator
                    && next.IsHardPoint)
                {
                    //Logging.Write(LogLevel.WARNING, "MoveTo Hardpoint: {0}", next);
                    Navigator.NavigationProvider.MoveTo(next.Location);
                }
                else
                {
                    //Logging.Write(LogLevel.WARNING, "MoveTowards: {0}", next);
                    Navigator.PlayerMover.MoveTowards(next.Location);
                }
            }
            // Otherwise Clear Waypoints
            else
            {
                WaypointManager.IsNavigating = false;
                WaypointManager.CurrentWaypoints.Clear();
            }
        }

        internal static void StopNavigating()
        {
            Logging.Write(LogLevel.INFO, "Stopping, No Waypoint");
            WaypointManager.IsNavigating = false;
            WaypointManager.CurrentWaypoints.Clear();
            Navigator.PlayerMover.MoveStop();
        }

        // Needs Work
        internal static bool IsStuck()
        {
            return WaypointManager.IsNavigating
                && (!MovementManager.IsMoving
                    || MovementManager.IsMoving && MovementManager.Speed < 2);
        }
    }
}
