
---
title: Global Items
---
Global item variables are variables that keep track of what the player has and what the player has equipped. Adding new items and simply setting additional items such as Screw Attack will be much easier when you find out what global variable corresponds to what item.

There are two separate variables for most items that either keep track of if the player has obtained it or if the player has it equipped. For example, Spider Ball has `global.item[2]` which `1` indicates that the player has it. `global.spiderball`, however, actually dictates if the player is able to use it or not. If `global.spiderball` is equivalent to `0` in this case, the player has it and can enable it, but it is currently disabled.

Basically, `global.item` makes it so it is able to be turned on/off and the other variable, depending on its name, will actually mean the power up is active.

 For setting them up as temporary powerups you may only want to set the player having them active, but not unlocked, then set it as inactive once the powerup has expired.

| Global Item Variable | Active Item Variable | Corresponding Item |
| :------------------: | :------------------: | :----------------: |
| global.item[0] | global.bomb | Bombs |
| global.item[1] | global.powergrip | Power Grip |
| global.item[2] | global.spiderball | Spider Ball |
| global.item[3] | global.jumpball | Spring Ball |
| global.item[4] | global.screwattack | Screw Attack |
| global.item[5] | global.currentsuit == 1 | Varia Suit |
| global.item[6] | global.spacejump | Space Jump |
| global.item[7] | global.speedbooster | Speed Booster |
| global.item[8] | global.hijump | Hi-Jump |
| global.item[9] | global.currentsuit == 2 | Gravity Suit |
| global.item[10] | global.cbeam | Charge Beam |
| global.item[11] | global.ibeam | Ice Beam |
| global.item[12] | global.wbeam | Wave Beam |
| global.item[13] | global.sbeam | Spazer Beam |
| global.item[14] | global.pbeam | Plasma Beam |
| global.item[15] | global.morphball | Morph Ball |

Colliding with an item object will switch on both the global item variable and the active item variable, enabling the player to turn on and off the powerup and have it active on pickup.

It is important to note that the Power Suit is not a major item. Suits are chosen depending on what `global.currentsuit` suit is. `0` is Power Suit, `1` is Varia Suit, `2` is Gravity Suit.

Strangely, there is currently no Morph Ball item that grants morph ball, but there is a Power Grip item, despite both already being obtained and active on game start.
