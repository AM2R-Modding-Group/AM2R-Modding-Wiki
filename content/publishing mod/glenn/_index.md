---
title: Port to other Operating Systems
weight: 1
---

Now that you have your Raw Mod for *your* Operating System, you should port your mod 
and create Raw Mods for other Operating Systems as well. This step is **optional but recommended** in order for you to 
make your mod available for more people.   
Luckily, there is a tool by Miepee that simplifies that process, 
called [Glenn](https://github.com/Miepee/Glenn).  

This tool only works with **GameMaker VM builds**, which essentially means, 
that *only* if you created your mod via a YYC build with GameMaker Studio 1.4, you are *unable* to use it. In the case you have done that, 
see instructions further down on what you can do.

The project's Readme should sufficiently explain its usage, but here's a quick rundown nonetheless.

1. Make sure that you don't have any functionality that's OS specific! This includes using `\` instead of `/`, 
writing to the asset folder / `working_dir`, make sure that every file you read is in lowercase etc. The Readme goes into
full detail on there.   
If you encounter anything in your Mod that's OS specific, you need to modify your Mod accordingly.  
**Important if you plan to port for Mac:** Make sure that all references to `immersion_play_effect`, 
`immersion_stop` and `font_replace` are removed or are behind an OS check as they'll otherwise crash the game! For vanilla AM2R, only the alarms in `oDrillSeq1` and `oDrillSeq2` are affected with `immersion_stop` (you can see the exact patch you can do in the [Pull Request here](https://github.com/AM2R-Community-Developers/AM2R-Community-Updates/pull/109/files)), all other functions (`immersion_play_effect` and `font_replace`) are already behind an OS check.

2. Download the [latest version of Glenn](https://github.com/Miepee/Glenn/releases/latest). 
Choose the GUI version for your OS.

3. Extract the zip to a folder of your liking. I'll call that folder "ExtractedTool" for future reference.

4. Execute the tool in your ExtractedTool folder, feed your Raw Mod zip and select the checkboxes accordingly.  
    - Check `Windows` / `Linux` / `Android`/  `Mac` if you want to have a Raw Mod Zip created for that OS
    - Check the `Requires Internet` option if your mod needs internet in any way (i.e. multiplayer) *and* you have `Android` checked.
    - Check the `Use custom save location` option if you want your **Android** mod to use a custom save location. If you don't include this for Android, users who will install your mod will need to 
uninstall the normal Community Updates, which can cause their saves to get deleted.

5. Select the icon and splash images you want for your mod.

6. Click on the "Port" button

After that, there will now be a Raw Zip Versions for the OS' you selected in the ExtractedTool folder.

---
If you're a GM:S 1.4 User, and you compiled your mods using YYC, you have two options:

1. Manage to YYC compile it for all platforms that you want to redistribute (this can be very painful, especially for Mac and Android).

2. Compile your Mod as VM, *make sure that nothing broke in the process*, and then use Glenn from above.
