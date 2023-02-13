---
title: Design
weight: 1
resources:
  - name: decorationTiling
    src: "decorationTiling.png"
    title: And finally the decoration and background tiles.
  - name: oobTiling
    src: "oobTiling.png"
    title: Then we add the out of bounds tiles.
  - name: initialTiling
    src: "initialTiling.png"
    title: First we start with the tiles the player is meant to interact with.
---

TODO: having some more screenshots in here would be nice. Also fix some phrasing.

Now we get to actually laying out and "building" your room. For this, there are two main steps; Setting up collision and tiling.
{{< hint type="note">}}
It is generally recommended to do tiling first, as UTMT will always put the visuals for collision blocks in the foreground, meaning that doing tiling afterwards is a horrible experience. 
{{</hint>}}
To give your room form, you can place tiles from the many different tilesets. Each tile is added individually by right clicking in the tiles section, selecting `add new tile`, and then dragging the tileset that you want to use over from the left into the definition. This will be a slow process. Each unit or block that represents a tile is 16x16 pixels pixels large, and can be selected manually by setting the source position and size or selected automatically by clicking on the tile you want. However the latter option is sometimes not as good for tilesets which aren't limited to blocks. It is helpful to use an image editor to find the coordinates of specific points for the former option. Tiles that are a multiple of 16x16 can be selected by holding `ALT` while dragging over the tileset thumbnail in the tile's properties.
Take note of the depth variable when adding tiles. Since UTMT does not have a layer system, this value is what decides which tiles are in the foreground and which are in the background, with lower values being shown in front of higher values.

{{<hint type="tip">}}
Here are some depth values to take note of:
- Backgrounds: 100
- Samus: -1
- Foreground: -100
- Breakable Blocks: -111/-112
- Fading Tiles: -120 (Do not work without an `oFadeTiles` object)
{{</hint>}}

Something you can use to make the tiling process a lot faster is to copy existing tiles by holding alt and dragging them around the room. This will copy everything from that tile, including depth and tileset. This drastically speeds up the tiling process.  
It is recommended to start with the tiles that the player will actually interact with, then adding stuff outside the playable area and background decorations.

{{<columns>}}
{{< img name="initialTiling" size=origin >}}
<--->
{{< img name="oobTiling" size=origin >}}
<--->
{{< img name="decorationTiling" size=origin >}}
{{</columns>}}

Now we can begin adding collision, for this we will use objects, notably `oSolid1` and `oSlope(1-4)`. On the left `Filter by name...` box, search for `Solid`. Here you will find all types of Solids, though for most purposes, `oSolid1` will be all you need. You can add it just by dragging the object into the room and placing it where you want it, then you can scale it to fit your needs. Then, for sloped surfaces you can use the `oSlope(1-4)` and `oSlope(1-4)B`. Don't try to rotate these objects, instead, if the slope doesn't have the correct orientation, take a slope with a different number and drag it into the definition box of your selected slop until you find the one with the right orientation.
{{<hint type="warning">}}
Never Delete objects, or basically anything in UTMT. Everything in UTMT is organized in a large list, with the newest addition always located in the bottom. Deleting something that is not literally the last thing in this list can have unforseen consequences and will often break things. If you mistakenly put the wrong object in your room, replace it with another object that you actually need (Just drag an object from into the definition box of your misplaced object)
{{</hint>}}

For puzzles and other uses, you can also search for `missile`, `bomb`, `super missile` and other destroyable blocks. Keep in mind that these blocks, as well as solid blocks, are invisible and do not appear without putting tiles over them or giving them creation code.  
For this, there are two solutions:
1. Add creation code for each of them and use `tile_link(tileset,x,y)` as its content. It will link the block to a tileset and will automatically use a 16 x 16 size. The x and y coordinates correspond with the top-left corner of the breakable block. 
2. Place a tile in the position where the breakable block will be, and set the depth of that tile to either `-111` or `-112`.

{{<hint type="tip">}}
Here are all the Breakable Blocks, along with what they are commonly refered to:
- `oBlockShoot`; Break blocks
- `oBlockShootChain`; A chain of break blocks
- `oBlockStep`; Crumble blocks
- `oBlockBomb`; Bomb blocks
- `oBlockBombChain`; A chain of bomb blocks
- `oBlockMissile`; Missile blocks
- `oBlockSMissile`; Super Missile Blocks
- `oBlockSpeed`; Speedboost Blocks
- `oBlockPBomb`; Power bomb blocks
- `oBlockPBombChain`; A chain of Power bomb blocks
- `oBlockScrew`; Screw attack blocks
{{</hint>}}

Now you can add breakable blocks in your room!  

For backgrounds, you should place an `oBackground` object somewhere in the room. Usually they are placed in the top-left of the room. The `oBackground` object has create code `load_bgset(value)`. The value is the set of backgrounds the object will use. For example, `load_bgset(7)` will put the Area 4 background sprites in the background. The best way to determine this is finding an `oBackground` object in a different room in the same area as yours or the area your prefer and copying it or its creation code to yours. Your room now has a background with parallax movement!

TODO: above is false, you can easily check what value is used for load_bgset by checking the appropriate script, and then ctrl+clicking the number next to `bgid[0]` under the `argument0 == value` condition.

Now, your room's collision and destroyable blocks are all layed out, you could even test it out in game right now, but currently you cannot get into your room. For this we will need transitions. Covered in the next page