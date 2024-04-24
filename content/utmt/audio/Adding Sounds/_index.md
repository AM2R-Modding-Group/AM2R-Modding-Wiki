---
title: Adding Sounds
---

First, be sure your new sound file is a .wav
Open your project in UMT
Right-click on Embedded Audio, and click Add. Take note of the number in the name of the new EmbeddedSound.
In the new EmbeddedSound, click Import, and select the desired sound file. 

After the sound is imported, right-click on sounds in the asset pane, then click Add
First name your sound, preferably with the snd prefix. When it asks whether to change this instance or all instances of this string, pick all.
Now, take a look at an existing sound for reference.
In your new sound, fill the fields with the appropriate data.
Flags should have IsEmbedded, Regular
Type is .wav
File is the name of the file you imported.
Effects, Volume, and Pitch should be left at default values.
Don't touch Audio Group
Audio File The first box is the index number of the new EmbeddedSound. For the second box, drag the new EmbeddedSound from the asset pane into it.
Enable Preload (check box)

Your new sound should be usable in the code editor (will be red text), though i've found that a save and restart of UMT is needed before the changes show properly in the Sound's properties.


{{<todo>}} Add markdown, images, and stuff. {{</todo>}}

