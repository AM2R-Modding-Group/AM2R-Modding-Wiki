 
---
title: Music
---
{{<todo>}} should the music files be embedded here for quick listen/download? or is the soundcloud enough? {{</todo>}}
This subsection documents the various music tracks used in AM2R.  
The music is licensed under CC BY-NC-SA 3.0 and can be found here: https://soundcloud.com/user-64632134/sets/am2r-original-soundtrack  
The official Soundtrack tracks were created by Milton Guasti, Darren Kerwin and Torbjørn Brandrud.  
The music assets have the prefix `mus` and have the same name as the music file names listed here, but without the extension (e.g. `musTitle` instead of `musTitle.ogg`).  
Be aware, that on Unix systems (Linux, Android, macOS) the music file names are all lowercase, due to the way GameMaker loads them.
{{<expand "Table of Contents" >}}
{{<toc format=raw >}}
{{</expand>}}

# AM2R Title
This track plays on the title screen. The music file is called `musTitle.ogg`.

# Intro
This track plays on the intro cutscene. The music file is called `musIntroSeq.ogg`.

# Samus Fanfare
This is a short jingle that plays when Samus spawns. The music file is called `musFanfare.ogg`.

# Initial Descent
This track plays in the Main Caves and in the lower part of A6 (Search & Rescue Hideout), while it is daytime. The music file is called `musMainCave.ogg`.
{{<todo>}} document when global.time (day) changes, and link it here {{</todo>}}

# Metroid Appear
Not officially named. This track plays as an intro before every Metroid fight. The music file is called `musMonsterAppear.ogg`. Before version 1.5.3 it was called `musMetroidAppear.ogg`.

# Alpha Metroid Fight
This track plays during a fight with an Alpha Metroid. The music file is called `musAlphaFight.ogg`.

# Abandoned
This plays as an ambience track between the Main Caves and the bigger parts of the following Areas: Golden Temple, Hydro Station, Industrial Complex, Distribution Center. The music file is called `musCaveAmbience.ogg`.

# Golden Temple
This plays in the Golden Temple. The music file is called `musArea1A.ogg`.

# Breeding Grounds
This plays in the Breeding Grounds in the Golden Temple. The music file is called `musArea1B.ogg`.

# Ancient Guardian
This plays during the fight with the Ancient Guardian. The music file is called `musAncientGuardian.ogg`.  
It also plays during the fight with the Tester, if the file `musTester.ogg` does not exist.

# Hydro Station
This plays in the Hydro Station. The music file is called `musArea2A.ogg`.

# Growing Deadlier
This plays in the Breeding Grounds in the Hydro Station. The music file is called `musArea2B.ogg`.

# Arachnus
This plays during the fight with Arachnus. The music file is called `musArachnus.ogg`.

# Gamma Metroid Fight
This plays during a fight with a Gamma Metroid. The music file is called `musGammaFight.ogg`.

# Industrial Complex
This plays in the Industrial Complex. The music file is called `musArea3A.ogg`.

# Overgrown Caverns
This plays in the Breeding Grounds in the Industrial Complex. The music file is called `musArea3B.ogg`.

# Torizo
This plays during the first phase against Torizo. The music file is called `musTorizoA.ogg`.

# Torizo Ascendant
This plays during the second phase against Torizo. The music file is called `musTorizoB.ogg`.

# Research Lab
This plays in the Research Site. The music file is called `musLabAmbience.ogg`.

# Forlorn Descent
This plays in the Main Caves and in the lower part of A6 (Search & Rescue Hideout), during every other time except daytime. The music file is called `musMainCave2.ogg`.

# Vertical Darkness
This plays in the Tower, if it has not been activated yet. The music file is called `musCaveAmbienceA4.ogg`.

# Zeta Metroid Fight
This plays during the fight with a Zeta Metroid. The music file is called `musZetaFight.ogg`.

# The Tower
This plays in the Tower after it has been activated. The music file is caleld `musArea4A.ogg`.

# Power Plant
This plays in the Power Plant. The music file is called `musArea4B.ogg`.

# Escape
This plays in the Power Plant during the escape sequence. The music file is called `musReactor.ogg`.

# Flooded Complex
This plays in the Distribution Center, if the EMP Statue has not been activated yet. The music file is called `musArea5A.ogg`.

# Ancient Power
This plays in the Distribution Center after the EMP Statue has been activated. The music file is called `musArea5B.ogg`.

# Transport Room
This plays during most rooms which contain a tansporter pipe. The music file is called `musItemAmb.ogg`.  
It does *not* play in item rooms. If the file `musItemAmb2.ogg` exists, then that file gets played.

# Serris
This plays during the fight with Serris. The music file is called `musEris.ogg`.

# Thoth
This plays at the GFS Thoth. The music file is called `musArea8.ogg`.

# Genesis
This plays during the fight with Genesis. The music file is called `musGenesis.ogg`.

# The Nest
This plays during the upper/bubble part of A6 (The Nest). The music file is called `musArea6A.ogg`.

# Omega Metroid Fight
This plays during a fight with an Omega Metroid. The music file is called `musOmegaFight.ogg`.

# Genetics Lab
Genetics Lab is split into two in the official soundtrack.  
`Genetics Lab 1` plays in the first rooms in the labs before the hatchling cutscene has been triggered. That music file is called `musArea7A.ogg`.  
The first part of `Genetics Lab 2` plays during the hatchling cutscene. The music file is called `musArea7B.ogg`.  
The second part of `Genetics Lab 2` plays in the first rooms in the labs after the hatchling cutscene has been triggered, or in the latter rooms in the labs. The music file is called `musArea7C.ogg`

# Final Corridor
This plays in the final corridor before the Metroid Queen Arena. The music file is called `musArea7D.ogg`.

# Queen Battle
This plays during the Metroid Queen Battle and is split up into multiple tracks.
The first part of `Queen Battle Part 1` plays as an intro to the fight. The music file is called `musQueenIntro.ogg`.  
The second part of `Queen Battle Part 1` plays during the rest of the fight. The music file is called `musQueen.ogg`.  

If the files `musQueenbreak.ogg`, `musQueen2.ogg` and `musQueen3.ogg` exists, then there's slightly different behaviour:  
- The second part of `Queen Battle Part 1` only plays during the first room of the fight.  
- The first part of `Queen Battle Part 2` plays when the Queen is charging her fireball attack to change between different phases. The first one is in the first room, the second one in the last corridor. The music file is called `musQueenbreak.ogg`.  
- The second part of `Queen Battle Part 2` plays during the corridors. The music file is called `musQueen2.ogg`.  
- The third part of `Queen Battle Part 2` plays during the last room and the cavern. The music file is called `musQueen3.ogg`.

# The Last Metroid
This plays in the rooms after the baby Metroid has been collected. The music file is called `musHatchling.ogg`.

# Credits
This plays during the credits sequence. The music file is called `musCredits.ogg`.

# Item Fanfare
This plays when a major item has been collected. The music file is called `musItemGet.ogg`.

# Secret Ending
This track is not part of the official soundtrack. It exists in the Community Updates since version 1.4 and was made by [unknown](https://www.youtube.com/@unknown-gd6nk). It is licensed under [CC BY-NC-SA 4.0](https://creativecommons.org/licenses/by-nc-sa/4.0/deed). The music file is called `musEnding.ogg`.
