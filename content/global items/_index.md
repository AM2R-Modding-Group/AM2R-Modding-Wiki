
---
title: Global Items
---
Global item variables are global variables that keep track of what the items player has collected. These variables are list items in the `gobal.item[]` array. Adding new items or replacing existing items such as Screw Attack will be much easier when you know which global variable corresponds to what item.

There are two separate variables for most items that either keep track of if the player has obtained it or if the player has it equipped. For example, Spider Ball has `global.item[2]` which `1` indicates that the player has it. `global.spiderball`, however, actually dictates if the player is able to use it or not. If `global.spiderball` is equivalent to `0` in this case, the player has it and can enable it, but it is currently disabled.

{{< hint type="note">}}
The variable tracking if a major is currently equipped is not part of the global item array.
{{< /hint >}}

 For setting up majors as temporary powerups you may only want to set the player having them active, but not unlocked, then set it as inactive once the powerup has expired.

| Global Item Variable | Currently Active Item Variable | Corresponding Item |
| :------------------: | :------------------: | :----------------: |
| global.item[0] | global.bomb | Bombs |
| global.item[1] | global.powergrip | Power Grip |
| global.item[2] | global.spiderball | Spider Ball |
| global.item[3] | global.jumpball | Spring Ball |
| global.item[4] | global.screwattack | Screw Attack |
| global.item[5] | global.currentsuit (should return `1`) | Varia Suit |
| global.item[6] | global.spacejump | Space Jump |
| global.item[7] | global.speedbooster | Speed Booster |
| global.item[8] | global.hijump | Hi-Jump |
| global.item[9] | global.currentsuit (should return `2`) | Gravity Suit |
| global.item[10] | global.cbeam | Charge Beam |
| global.item[11] | global.ibeam | Ice Beam |
| global.item[12] | global.wbeam | Wave Beam |
| global.item[13] | global.sbeam | Spazer Beam |
| global.item[14] | global.pbeam | Plasma Beam |
| global.item[15] | global.morphball | Morph Ball |

{{< hint type="note">}}
Colliding with an item object will switch on both the global item variable and the currently active item variable, enabling the player to turn on and off the powerup and have it enabled when picked up.
{{< /hint >}}

It is important to note that the Power Suit is not a major item. Suits are chosen depending on what `global.currentsuit` suit is. `0` is Power Suit, `1` is Varia Suit, `2` is Gravity Suit.

The game assumes the player always has the Morph Ball no matter what, mainly because it is already acquired on the start of the game.
Despite Morph Ball and Power Grip being obtained and enabled on game start, there exists a Power Grip item, but no Morph Ball item. This is a leftover from Metroid:Confrontation.

{{< hint type="note">}}
Metroid:Confrontation is the tech demo for AM2R, featuring a different storyline and less developed gameplay features.
{{< /hint >}}

The global item array has values ranging to `350`, although there aren't 350 items in the game. In the `gml_Script_sv6_add_items` script, the global item array adds values from `0` to `350`. 
The script `gml_Script_sv6_add_itemsA4` adds values 20 more values to the array from `400` to `420`.
`gml_Script_sv6_add_itemsA6` adds 20 values ranging from `600` to `620`.
And `gml_Script_sv6_add_itemsA7` adds 20 values ranging from `700` to `720`.
There are 88 total items in the game, including all major items and minor items. Items with global item values greater than `15` are minor items (missile tanks, energy tanks, super missiles, and power bombs).
