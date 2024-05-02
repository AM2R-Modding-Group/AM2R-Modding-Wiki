---
title: Adding Sounds and Music 

resources:
  - name: soundsAdd
    src: "soundsAdd.png"
    title: Adding a new sound
  - name: embeddedAudioAdd
    src: "embeddedAudioAdd.png"
    title: Adding embedded audio
  - name: newEmbeddedAudio
    src: "newEmbeddedAudio.png"
    title: A new Embedded Audio asset
  - name: newSound
    src: "newSound.png"
    title: A new Sound's properties	
---
Sounds can be either loaded internally (a WAV file embedded in the `data.win`) or externally (an Ogg Vorbis file placed in the game's folder).
{{<tabs "source">}}
{{<tab "Internal">}}
1. Open the AM2R `data.win` in UndertaleModdingTool.  

2. In the assets pane, right-click on `Embedded Audio`, and click `Add`. 
{{<columns>}}
{{<img name="embeddedAudioAdd" size="origin">}} 
<---> 
{{<img name="newEmbeddedAudio" size="origin">}}
{{</columns>}}
   The number in the name of the new `EmbeddedSound` is its `Index Number`. This will be needed for a later step.

3. In the new `EmbeddedSound`, click `Import`, and select the desired WAV file. 

4. Right-click on `Sounds` in the assets pane, then click `Add`
{{<columns>}}
{{<img name="soundsAdd" size="origin">}}
<--->
{{<img name="newSound" size="origin">}}
{{</columns>}}

5. Fill the sound's property fields with the appropriate data. Look at an existing sound asset for reference on how it should look.

   - **Name** A string to identify the sound in code. A prefix is recommended for easier searching and quick identification. In AM2R, the naming convention is `snd` for sound effects, and `mus` for music.
   - **Flags**: `IsEmbedded, Regular`
   - **Type** *Unused for Embedded Sounds* *Leave as default values.*
   - **File** *Unused for Embedded Sounds* *Leave as default values.*
   - **Effects**, **Volume**, and **Pitch** *Leave as default values.*
   - **Audio Group** *Unused in AM2R.* *Leave as default values.*
   - **Audio File** The first box is the index number of the new `EmbeddedSound`. The second box displays the name of the `EmbedddedSound` with that index number. Enter the index number in the first box; the second box will update after an UMT restart. For previosuly assigned sounds, drag the new `EmbeddedSound` from the asset pane into the second box.
  {{<hint type="warning">}}
  Due to a bug in UMT, save and restart the mod tool for the `Audio File` changes to show properly in the sound's properties.
  {{</hint>}} 
   - **Preload (old audio system)** Enable the option *(check box)* 
{{</tab>}}

{{<tab "External">}}
1. If not done already, convert the sound file to Ogg Vorbis file format.

2. Place the Ogg audio file in the game's folder.

3. Open the AM2R `data.win` in UndertaleModdingTool.  

4. Right-click on `Sounds` in the assets pane, then click `Add`
{{<columns>}}
{{<img name="soundsAdd" size="origin">}}
<--->
{{<img name="newSound" size="origin">}}
{{</columns>}}

5. Fill the sound's property fields with the appropriate data. Look at an existing sound asset for reference on how it should look.

   - **Name** A string to identify the sound in code. A prefix is recommended for easier searching and quick identification. In AM2R, the naming convention is `snd` for sound effects, and `mus` for music.
   - **Flags**: `Regular`
   - **Type** The extension of the file. `.ogg` for Ogg Vorbis files
   - **File** Is the name of the sound file, including extension. example: `sndBoom.ogg`, `musTune.ogg`
   - **Effects**, **Volume**, and **Pitch** *Leave as default values.*
   - **Audio Group** *Unused in AM2R.* *Leave as default values.*
   - **Audio File** *Unused for externally loaded audio.* *Leave as default values.*
   - **Preload (old audio system)** Enable the option *(check box)* 
{{</tab>}}
{{< /tabs >}}
The new sound is now usable! The sound's name will show as red text in the code editor



