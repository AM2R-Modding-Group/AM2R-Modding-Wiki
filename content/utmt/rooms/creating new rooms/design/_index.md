---
title: Design
weight: 1
---

TODO: having some more screenshots in here would be nice. Also fix some phrasing.

Now we get to actually laying out and "building" your room. For this, there are two main steps; Setting up collision and tiling.
{{< hint type="note">}}
It is generally recommended to do tiling first, as UTMT will always put the visuals for collision blocks in the foreground, meaning that doing tiling afterwards is a horrible experience.
{{</hint>}}
To give your room form, you can place tiles from the many different tilesets. Each tile is added individually by right clicking in the tiles section, selecting `add new tile`, and then dragging the tileset that you want to use over from the left into the definition. This will be a slow process. Each unit or block that represents a tile is 16x16 pixels pixels large, and can be selected manually by setting the source position and size or selected automatically by clicking on the tile you want. However the latter option is sometimes not as good for tilesets which aren't limited to blocks. It is helpful to use an image editor to find the coordinates of specific points for the former option. Tiles that are a multiple of 16x16 can be selected by holding `ALT` while dragging over the tileset thumbnail in the tile's properties.
Take note of the depth variable when adding tiles. Since UTMT does not have a layer system, this value is what decides which tiles are in the foreground and which are in the background, with lower values being shown in front of higher values.

{{< hint type="tip">}}
Here are some depth values to take note of:
- Backgrounds: 100
- Samus: -1
- Foreground: -100
- Breakable Blocks: -111/-112
- Fading Tiles: -120 (Do not work without an `oFadeTiles` object)
{{</hint>}}

Something you can use to make the tiling process a lot faster is to copy existing tiles by holding alt and dragging them around the room. This will copy everything from that tile, including depth and tileset. This drastically speeds up the tiling process.

You are now ready to start building your room. On the left `Filter by name...` box, search for `solid`. There, all the solid collision blocks under the `Game objects` category are to be added by dragging and dropping them onto the room. For puzzles and other uses, you can also search for `missile`, `bomb`, `super missile` and other destroyable blocks. Keep in mind that these blocks, as well as solid blocks, are invisible and do not appear without putting tiles over them or giving them creation code.  
Now, your room's collision and destroyable blocks are all layed out. In-game, you will see nothing in your room, but you will able to collide with the blocks and break them as usual. 

Before we get into backgrounds, you are wondering what to do with the destroyable blocks since they do not appear visible, or even the fact you cannot get into the room at all. The room requires a `oGotoRoom` object (from now on called "transitions") to actually enter it from anywhere else. Breakable blocks need creation code to make them look like different blocks. You should NOT put tiles over them if your intent is to have them break.
Transitions will be covered later.

For the breakable blocks, there are two solutions:
1. Add creation code for each of them and use `tile_link(tileset,x,y)` as its content. It will link the block to a tileset and will automatically use a 16 x 16 size. The x and y coordinates correspond with the top-left corner of the breakable block. 
2. Place a tile in the position where the breakable block will be, and set the depth of that tile to either `-111` or `-112`.

Now you can add breakable blocks in your room!  

For backgrounds, you should place an `oBackground` object somewhere in the room. Usually they are placed in the top-left of the room. The `oBackground` object has create code `load_bgset(value)`. The value is the set of backgrounds the object will use. For example, `load_bgset(7)` will put the Area 4 background sprites in the background. The best way to determine this is finding an `oBackground` object in a different room in the same area as yours or the area your prefer and copying it or its creation code to yours. Your room now has a background with parallax movement!

TODO: above is false, you can easily check what value is used for load_bgset by checking the appropriate script, and then ctrl+clicking the number next to `bgid[0]` under the `argument0 == value` condition.
