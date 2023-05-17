
---
title: Global Items
---
Item variables are global variables that keep track of what items the player has collected. These variables are listed in the `gobal.item[]` array. Adding new items or replacing existing items such as Screw Attack will be much easier when you know which global variables corresponds to what item.

There are two separate variables for most items that either keep track of whether the player has it obtained or equipped. For example, Spider Ball is mapped to `global.item[2]` which if set to `1` indicates that the player has collected it. `global.spiderball`, however, dictates if the player is able to use it or not. If `global.spiderball` is equivalent to `0`, then in this case, the player has the item collected and can enable it, but it is currently disabled.

{{< hint type="note">}}
The variable tracking of a major is currently equipped or not is not part of the `global.item` array.
{{< /hint >}}

 If you want to set up majors as temporary powerups you should set the player having them active, but not unlocked, then set it as inactive once the powerup has expired.

| Global Item Variable | Currently Active Item Variable | Corresponding Item |
| :------------------: | :------------------: | :----------------: |
| global.item[0] | global.bomb | Bombs |
| global.item[1] | global.powergrip | Power Grip |
| global.item[2] | global.spiderball | Spider Ball |
| global.item[3] | global.jumpball | Spring Ball |
| global.item[4] | global.hijump | Hi-Jump |
| global.item[5] | global.currentsuit (should return `1`) | Varia Suit |
| global.item[6] | global.spacejump | Space Jump |
| global.item[7] | global.speedbooster | Speed Booster |
| global.item[8] | global.screwattack| Screw Attack |
| global.item[9] | global.currentsuit (should return `2`) | Gravity Suit |
| global.item[10] | global.cbeam | Charge Beam |
| global.item[11] | global.ibeam | Ice Beam |
| global.item[12] | global.wbeam | Wave Beam |
| global.item[13] | global.sbeam | Spazer Beam |
| global.item[14] | global.pbeam | Plasma Beam |
| global.item[15] | global.morphball | Morph Ball |

{{< hint type="note">}}
Colliding with an item object will switch on both the collected item variable and the currently active item variable, enabling the player to turn the powerup on and off and have it enabled when picked up.
{{< /hint >}}

It is important to note that the Power Suit is not a major item. Suits are chosen depending on what `global.currentsuit` suit is. `0` is Power Suit, `1` is Varia Suit, `2` is Gravity Suit.

Despite Morph Ball and Power Grip being obtained and enabled on game start, there exists a Power Grip item, but no Morph Ball item. This is a leftover from Metroid:Confrontation. However, the game assumes the player always has the Morph Ball no matter what, mainly because it is already acquired on the start of the game.

There are 88 total items in the game, including all major items and minor items. Items with global item values greater than `15` are minor items (missile tanks, energy tanks, super missiles, and power bombs).

{{<todo>}} 
Currently, there is no table available that displays information of all the `global.item` values used for minor items, however those can be seen in `gml_Script_debug_view_items`.
{{</todo>}}
