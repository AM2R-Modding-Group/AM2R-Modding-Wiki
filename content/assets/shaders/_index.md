---
title: Shaders
resources:
  - name: Olive
    src: "olive.png"
    title: Olive
  - name: Blue
    src: "blue.png"
    title: Blue
  - name: B&W
    src: "blackandwhite.png"
    title: Black&White
  - name: Virtualtroid
    src: "virtualtroid.png"
    title: Virtualtroid
  - name: Green
    src: "green.png"
    title: Green
  - name: CustomDefault
    src: "customDefault.png"
    title: Custom, with default values in modifiers.ini
  - name: CustomMissing
    src: "customMissing.png"
    title: Custom, with default values if the keys in modifier.ini are missing
---
This subsection documents the various shaders used in AM2R. Shader assets have the prefix `sh`.
{{<todo>}} Am2r 1.0 used a shader for gravity suit. document that one more{{</todo>}}
AM2R 1.0 uses a shader internally known as `shReplaceColor`. Not much is known about it, but Rivals of Aether also has a similar if not the same shader. It seems to originate from GMLscripts.com, but it also could've been a shader shipped with old GameMaker versions or from GMC. DoctorM64 did not write it himself.  

This shader was originally used in AM2R 1.0 to palette swap the Varia Suit sprites to Gravity Suit. However, since many GPUs had issues running the shader, thus leaving Gravity Suit to look the same as Varia Suit, it went unused in 1.1 in favour of prerendered sprites. Not much documentation has been done in looking into how exactly the shader worked, on neither a code side, nor a dev-usage side.


The Community Updates uses two shaders:
## Pixelated Pope's Retro Palette Swapper
Internally known as `shPaletteSwap`. It can be found for free here: https://pixelatedpope.itch.io/retro-palette-swapper. Note that for the versions 1.5.5 and lower, you want to use the `Retro Pal Swapper 2.1 for GMS1` asset.

The shader is used on desktop machines as an extra to palette swap Samus and Metroids. It is disabled on Android systems. However, despite that, similar to the early 1.0 color repalce shader, it also has issues running on many GPUs, especially laptop or other lower-end ones.
{{<todo>}} document more {{</todo>}}

## PixHammer's GameBoy Shader
Internally known as `shGameBoy`. It can be bought for 2$ here: https://pixhammer.itch.io/gameboy-shader. 

The shader is used as an extra to limit the whole screen to 4 colors, similar to the GameBoy.
The available default available presets are these:
{{<columns>}}
{{< img name="Olive" size=tiny >}}
<--->
{{< img name="Blue" size=tiny >}}
<--->
{{< img name="B&W" size=tiny >}}
<--->
{{< img name="Virtualtroid" size=tiny >}}
<--->
{{< img name="Green" size=tiny >}}
<--->
{{< img name="CustomDefault" size=tiny >}}
<--->
{{< img name="CustomMissing" size=tiny >}}
{{</columns>}}

The values are harcoded several places:
- The `set_8bit_shader` script for `Olive` to `Green`
- The `modifiers.ini` file for one Custom variant
- the `scr_load_scripts` script for the other Custom variant

The user is able to modify the `Custom` variant in the `modifiers.ini`, by changing the keys `CustomColorXValueY`, where X is a number from 1 to 4, and Y is a number from 1 to 3. The colors are sorted from darkest to brightest (`CustomColor1ValueY` is darkest, `CustomColor4ValueY` is brightest), and then by red, green and blue values (`CustomColorXValue1` is the red component, `CustomColorXValue3` is the blue component). The values can take in numbers from 0 to 255.
