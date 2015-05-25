# Mud Assist 1.1.3
Mud Assist is Botbase for [Rebornbuddy](http://rebornbuddy.com) that gives full control over your CR.
It's similar to the Combat Assist Botbase, but gives much more control over the CR.

## Example Settings
![Settings](http://i.imgur.com/Z6surT2.png)
![Targeting](http://i.imgur.com/xryvzIY.png)

![Routine](http://i.imgur.com/IdJaw8q.png)
![Hotkeys](http://i.imgur.com/dE9gpWH.png)

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
- (Feature) Dynamically Change CR
- Have any better ideas? PM me.
