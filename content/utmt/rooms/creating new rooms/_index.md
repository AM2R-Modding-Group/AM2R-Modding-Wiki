
---
title: Making new custom rooms in AM2R with UTMT
resources: 
  - name: optimalRoomUp
    src: "optimalRoomUp.png"
    title: Optimal placing for up and down transitions
  - name: optimalRoomSide
    src: "optimalRoomSide.png"
    title: Optimal placing for left and right transitions
---

### Preparation:
Room sizes __must__ be multiples of `320` x `240`. It is highly recommended. Make sure room FPS is `60` to not speed-up or slow-down the game in that room.  
Once you have your set room size, set a background by putting `bgScreenGuide` in the one of the background definitions by dragging and dropping from the left, and enable it.  
Next, click on the Views category, and click the first View. Set its Pos/size values to `0, 0, 320, 240`, regardless of room size. Next, set Port pos/size values to `0, 0, 320, 240` as well. Set Border values to `160, 160`.  
Make sure Speed values are at `-1, -1`.
Lastly, to make the camera follow the player, put `oCamera` in Follows object.  
You are now ready to start building your room. On the left, search for `solid`. There, all the solid collision blocks are to be added by dragging and dropping onto the screen. For puzzles and other uses, you can also search for `missile`, `bomb`, `super missile` and other destroyable blocks. Keep in mind that these blocks, as well as solid blocks, are invisible and do not appear without putting tiles over them or giving them code.  
Now, your room's collision and destroyable blocks are all layed out. In-game, you will see nothing in your room, but will able to collide with the blocks and break them as usual. To give your room form, you can put tiles in from the many different tilesets. Each tile is added individually, so this will be a slow process. Each unit or block that represents a tile is 16 x 16 pixels large, and can be selected manually through setting the source position and size or clicking on what tile you want, however the latter option is sometimes not as good for tilesets that aren't limited to blocks. It is recommended to use an image editor to find the coordinates of specific points for the former option.  
Before we get into backgrounds, you are wondering what to do with the destroyable blocks since they do not appear visible, or even the fact you cannot get into the room at all. The room requires a `oGotoRoom` object (from now on called "transitions") to actually enter it from anywhere else. Breakable blocks need code to look like different blocks, do NOT put tiles over them if your intent is to have them break.
Transitions will be covered later.

For the breakable blocks, make create code for each of them and use `tile_link(tileset,x,y)`. It will link the block to a tileset and will automatically use a 16 x 16 size. The x and y coordinates correspond with the top-left corner of the breakable block. Now you can add breakable blocks in your room!  
For backgrounds, you should place an `oBackground` object somewhere in the room. Usually they are placed in the top-left of the room. The `oBackground` object has create code `load_bgset(value)`. The value is the set of backgrounds the object will use. For example, `load_bgset(7)` will put the Area 4 background sprites in the background. The best way to determine this is finding an `oBackground` object in a different room in the same area as yours or the area your prefer and copying it or its creation code to yours. Your room now has a background with parallax movement!

Finally, we are up to transitions. These are the objects that allow you to go to other rooms, and they take quite a bit of time to prepare to be visually appealing. Bad transitions end up with teleporting Samuses across the screen and the camera moving strangely. However, with the right knowledge, it can be done very quickly. Each transition requires a lot of number fiddling in the create code. The essential values needed are: `targetroom`, `direction`, `height`, `targetx`, `targety`, `camstartx`, `camstarty`, `transitionx`, `transitiony`.  
What to assign to those variables are:
- `targetroom` = The room number of the room you are transitioning into. Entering the name of the room will automatically make UTMT convert it into its number ID.
- `direction` = A number for what direction Samus is travelling in. 0 = Right. 90 = Up. 180 = Left. 270 = Down.
- `height` = The size of the transition. Depends on direction. If the transition is going Right or Left, this number is how tall the transition is. This means the optimal location to place the transition is at the bottom of the entrance, directly on a collision block. If the direction is going Up or Down, this variable is how wide the transition is, starting from its origin (its centre) going towards the right. Optimal placement is placing this on directly on the right of the leftmost wall the transition is between. 
- `targetx` = The x coordinate of where Samus is in the next room you are transitioning to.
- `targety` = The y coordinate of where Samus is in the room you are transitioning to.
- `camstartx` = The x coordinate of the camera's centre in the next room.
- `camstarty` = The y cooridinate of the camera's centre in the next room. 
- `transitionx` = x coordinate of where Samus is during the transition cutscene relative to the camera's origin. This has a range of 0-320. Do not go above or below it.
- `transitiony` = y coordinate of where Samus is during the transition cutscene relative to the camera's origin. This has a range of 0-240.

{{< img name="optimalRoomUp" size=origin >}}

{{< img name="optimalRoomSide" size=origin >}}

At this point with at least `targetroom` and `targetx` and `targety` and `direction` set, the transition should now work.

Next are some tips to help smoothen out the transition, taken from my own experience:  
- `targetx` and `targety` = If Samus is in the air, try use the x and y coordinates of the floor tile you want her to end up on after the cutscene. Since the floor tiles have origins on the top-left of their image, and Samus will end up *on* them and not in the air above them.
- `camstartx` and `camstarty` = After testing the transition cutscene once, I try and find the midpoint of where it is on my screen in-game in reference to any nearby tiles or objects. This will take some trial and error to get right.
- `transitionx` and `transitiony` = This will also take some trial and error to get right. Essentially what I do is I take the midpoint and I either subtract or add a quarter of the room size's x and y values depending on where I want Samus to end up in during the transition before actually going through it. After going through the transition, and finding out how terribly Samus is offset, I add or subtract from the values by 16 (essentially one block) to help get closer to the preferred final destination of where Samus is during the cutscene. This is easier to understand in practice, hopefully.

Congratulations! You have a functional room with transitions, collision units, tiles, background, and a camera! Feel free to add your own objects in and whatever you feel is necessary.
