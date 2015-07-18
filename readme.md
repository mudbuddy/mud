# Mud Assist 2.0.2
Mud Assist is Botbase for [Rebornbuddy](http://rebornbuddy.com) that gives full control over your CR.
It's similar to the Combat Assist Botbase, but gives much more control over the CR.

## Example Settings
![Routine](http://i.imgur.com/QHOMuH7.png)
![Movement](http://i.imgur.com/M0EIGGS.png)

![Settings](http://i.imgur.com/AY5vjVx.png)
![Hotkeys](http://i.imgur.com/myAQVXi.png)

More images on [Imgur...](http://imgur.com/a/23tjd#0)

## Features
- Pause/Unpause with Hotkey
- Optional Auto Sprint Out of Combat
- Initiate Attacks While Out of Combat (if Combat Routine Supports)
- Heal While Out of Combat (if Combat Routine Supports)
- Move In Range of Target or Tank
- Optional Facing Target
- Enable / Disable Specific Parts of the Combat Routine, such as PreCombatBuff/Heal/CombatBuff/Combat
- Optional Tank Assist (Target Tank's Target)
- Auto Targeting / Target Whitelisting/Blacklisting
- Persistent Settings

## Installation
1. [Download Mud Assist](https://github.com/mudbuddy/mud/archive/master.zip)
2. Unzip into **`<RebornBuddy Path>\BotBases\`**
3. Select `Mud Assist` from the **BotBase Dropdown Menu** after starting **RebornBuddy**

## Change Log
- `2.0.2`: Fix Issues With Facing Not Setting Properly
- `2.0.1`: Fix Combat Reach Issues For Melee Classes (Thanks **torfin**)
- `2.0.1`: Fix Some Combat Checking Issues (Thanks **torfin**)
- `2.0.1`: Fix Minor Combat Issue w/ **Being Tanked** Mode
- `2.0.0`: Swappable Combat Routines
- `2.0.0`: Auto-Accept Quests
- `2.0.0`: Auto-Talk to NPCs
- `2.0.0`: Waypoint-Based Navigation
- `2.0.0`: Separate Follow Range & Combat Range
- `2.0.0`: Additional Movement Mode For "Follow"
- `2.0.0`: Hotkey For Movement Mode Toggle
- `2.0.0`: New Targeting Mode: Lowest HP Being Tanked
- `2.0.0`: Use Pull Behavior When Attacking Out Of Combat
- `2.0.0`: Enable / Disable Combat Routine Rest Behavior
- `2.0.0`: Enable / Disable Combat Routine Pull Buff Behavior
- `2.0.0`: Selectable Navigation Provider
- `2.0.0`: Use Combat Behavior For Pulling If No Pull Behavior
- `2.0.0`: Only Use Combat Behavior IN Combat Unless Pulling W/ It
- `2.0.0`: Logic Fix: Target Enemy Over Follow Tank To Fix CR Issues
- `2.0.0`: Don't Sprint Inside Instances
- `2.0.0`: Allow Pull If Not In Party OR Player Is Tank
- `2.0.0`: Don't Execute Pull Or Combat Behavior Outside Of Pull Range
- `2.0.0`: Namespace Updates
- `2.0.0`: Fix Issues When CR Doesn't Implement Behavior
- `2.0.0`: Lots Of Refactoring
- `2.0.0`: Fix Some Navigation Provider Issues
- `2.0.0`: Tweak Issues W/ Routines
- `2.0.0`: Fix Bot Navigation With Providers
- `2.0.0`: Fix Pull Routine
- `2.0.0`: Navigation Tweaks
- `2.0.0`: Combat Fixes
- `2.0.0`: UI Improvements
- `2.0.0`: Better Default Settings
- `2.0.0`: Adjust Tab Order
- `2.0.0`: Follow Tweaks
- `2.0.0`: Version Update
- `2.0.0`: Status Bar / Separate Save Button
- `2.0.0`: Fix Waypoints From Jumping Tanks
- `1.1.3`: Improved Tank Assist Code (Don't Start Combat Until Tank Does)
- `1.1.3`: Improved Following Logic With Min/Max Range
- `1.1.3`: Prevent Movement From Interrupting Casting
- `1.1.2`: Hotkeys For Add/Remove Target
- `1.1.2`: Can Now Acquire & Follow Targets While Mounted
- `1.1.2`: Additional Target Filter For "None"
- `1.1.2`: Numerous Target Filter Fixes / Enhancement
- `1.1.2`: Get FFXIV Process Before Flashing Message (thanks newb23)
- `1.1.2`: Use GameSettingsManager.FaceTargetOnAction For Facing (thanks newb23)
- `1.1.2`: Other Various Bug Tweaks / Fixes
- `1.1.1`: Minor bug fixes
- `1.1.0`: Add Facing/Movement
- `1.1.0`: Target List Enhancements
- `1.1.0`: UI Improvements / Flash Messages
- `1.0.6`: Targeting by Distance. Execute CR while moving.
- `1.0.5`: Allow list to function as Blacklist or Whitelist
- `1.0.4`: Fix null pointer on Empty Hotkeys
- `1.0.3`: Improved Targeting Mode / Hotkeys
- `1.0.2`: Null check on GetPartyTank to prevent Log spam when Tank not in group
- `1.0.1`: Fix for CR toggle
- `1.0.0`: Release

## Planned Updates
- (Feature) Target Mode - Tank Mobs (Gain Aggro)
- (Feature) Target Mode - Treasure Coffers
- Have any better ideas? PM me or open a request on Github. Thanks!
