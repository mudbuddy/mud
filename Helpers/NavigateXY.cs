using Clio.Utilities;
using ff14bot;
using ff14bot.Behavior;
using ff14bot.Managers;
using ff14bot.Navigation;
using System;
using TreeSharp;
using Action = TreeSharp.Action;

namespace MudBase.Helpers
{
    class NavigateXY
    {
        private bool _done;
        public string X { get; set; }
        public string Y { get; set; }
        public bool IsDone { get { return _done; } }
        public bool IsCompleted = false;
        private int distance = 10;
        float _x;
        float _y;
        //calculate vector coords
        float vecX;
        float vecY;
        Vector3 dest = new Vector3(999,999,999);
        bool tempDest = false;
        bool haveDest=false;

        protected Composite CreateBehavior()
        {
            return new PrioritySelector(
				new Sequence(
					new Action(r => {
                        haveDest = (Vector3.Distance(dest, Core.Me.Location) > 10 && dest.X != 999);					
				    }),
                    new Action(r => {

				    // take the float divide it by 50 (Size of one tile in minimap) round to full number and add 21 (since 21/21 is 0,0 in meshes)
				    var locX=Math.Ceiling(Core.Me.X/50)+21;
				    var locY=Math.Ceiling(Core.Me.Z/50)+21;

				    //Logging.Write("we are currently at {0} which translates to {1} and {2}",Core.Me.Location,locx,locy);
                    //Logging.Write("we want to X{0},y{1}", vecx, vecy);

				    if ( Math.Abs(vecX - locX) >2 || Math.Abs(vecY -locY )>2)
				    {
                        //we  are out DayOfWeek raycast  rage 

                        if (vecX > locX && !haveDest)
                        {
                            Logging.Write(" target X{0} bigger than current location X{1}",vecX,locX);
                            SetDestination(
                                new Vector3(Core.Me.X + 100, +150f, Core.Me.Z), 
                                new Vector3(Core.Me.X + 100, -150f, Core.Me.Z));
					    }

                        if (vecY > locY && vecX > locX && !haveDest)
                        {
                            Logging.Write(" target X{0} bigger than current location X{1} and target y{2} > current Location Y{3}", vecX, locX, vecY, locY);
                            SetDestination(
                                new Vector3(Core.Me.X + 100, +150f, Core.Me.Z + 100), 
                                new Vector3(Core.Me.X + 100, -150f, Core.Me.Z + 100));
					    }

                        if (vecY < locY && vecX < locX && !haveDest)
                        {
                            Logging.Write(" target X smaler than current location X and target y smaller current Location Y");
                            SetDestination(
                                new Vector3(Core.Me.X - 100,+150f,Core.Me.Z - 100),
                                new Vector3(Core.Me.X - 100,-150f,Core.Me.Z - 100));
					    }


                        if (vecY > locY && !haveDest)
                        {
                            Logging.Write(" target y bigger than current location y");
                            SetDestination(
                                new Vector3(Core.Me.X, +150f, Core.Me.Z + 100),
                                new Vector3(Core.Me.X, -150f, Core.Me.Z + 100));
					    }
                        if (vecY < locY && !haveDest)
                        {
                            Logging.Write(" target y smaller than current location y");
                            SetDestination(
                                new Vector3(Core.Me.X, +150f, Core.Me.Z - 100),
                                new Vector3(Core.Me.X, -150f, Core.Me.Z - 100));
					    }
                        if (vecX < locX && !haveDest)
                        {
                            Logging.Write(" target X smaller than current location X");
                            SetDestination(
                                new Vector3(Core.Me.X - 100, +150f, Core.Me.Z),
                                new Vector3(Core.Me.X - 100, -150f, Core.Me.Z));
					    }
                        if (!haveDest)
					        Logging.Write(" Did not find destination !!!!");
				    }
				    else
                    {
                        SetDestination(
                            new Vector3(vecX - 100, +150f, vecY),
                            new Vector3(vecX, -150f, vecY));
				    }}),
                    new ActionAlwaysFail()
			    ),
				new Decorator(ret => Vector3.Distance(Core.Player.Location, dest) <= distance && tempDest==false,
                 	new Sequence(
						new Action(r =>
                            {
                                ff14bot.Managers.MovementManager.MoveForwardStop();
                                Logging.Write("Stopping player");
							    _done=true;
                            }))),
				new Decorator(ret => Vector3.Distance(Core.Player.Location, dest) > distance,
                    CommonBehaviors.MoveAndStop(ret => dest, distance, stopInRange: true, destinationName :"NavXY")),
                new ActionAlwaysSucceed()
            );
        }

        private void SetDestination(Vector3 startMid, Vector3 endMid)
        {
            Vector3 topHit;
            if (WorldManager.Raycast(startMid, endMid, out topHit))
            {
                Logging.Write("Found destination {0}", topHit);
                dest = topHit;
                tempDest = true;
                return;
            }
        }
	
        protected void OnResetCachedDone()
        {
            _done = false;
        }

        protected void OnStart()
        {
            Logging.Write("(X,Y): ({0},{1})", X, Y);
            //  float _x = Convert.ToSingle(X);
            //  float _y = Convert.ToSingle(Y);
            vecX = Convert.ToSingle(X);
            vecY = Convert.ToSingle(Y);
            Logging.Write("(_x,_y): ({0},{1})", _x, _y);
            //calculate vector coords
            //  float vecx = (21 - _x) * 50;
            //  float vecy = (21 - _y) * 50;
            Logging.Write("(vecX,vecY): ({0},{1})",vecX,vecY);
        }

        protected void OnDone()
        {
            Navigator.PlayerMover.MoveStop();
        }
    }
}