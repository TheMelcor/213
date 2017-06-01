# The Game (obvious placeholder is obvious)


## Table of contents

* [Introduction](#introduction)
* [Contribution](#contribution)
    * [Naming convention](#naming-convention)
    * [Unit setup](#unit-setup)
    * [Textures](#textures)
    * [Tiles](#tiles) 
    * [Objects](#objects)
    * [Game characters](#game-characters)
    * [Audio](#audio)
* [Winning conditions](#winning-conditions)
* [Complete levels](#complete-levels)
* [Camera](#camera)
* [License](#license)
* [Credits](#credits)


## Introduction

We're thankfull for any interest or contributions you might have to this project! Contributions can be in form of assets (specified in the contribution paragraph), ideas or feedback. This project is part of our semester assignment for the course IS-213; Open Source Project, and the idea is to create an project of our own interest and trying to related it to the Open Source community - be it the tools or platform for cooperation. This GIT page is meant to cover this, and all our assets are open to the public through the GPL3.0 license. There also is a report which isthe theoretical fundation for this project, where we elaborate more on theories and in-dept explenation of file formats, requirements and tools. A link to a readable version of this is as following: https://www.docdroid.net/PxJS90w/finalreport213.docx.html. While it is normal to refer to "Read the manual" if you are unsure how to contribute or show interest for this project, we try to strive towards an more including environment. Feel free to drop any of the core members an email and we'll try to best of our abilities to answer any questions you might have regarding this project. Also, if you want to fork our and continue your own project based on this fundation, we're equally happy with that as well, just remember the credits if you use the assets we have used of other people's work. 

## Contribution

#### Naming convention

When naming assets, please enforce logical naming (an barrel object would be named a barrel while a charater sounds would be named something like characterAction01). The start of the name should be with lower case, and new words should be upper case without space or underscore. Examples on this can be characterAction01, doorAnimated02, musicCalm01 and so on. Number the assets is preferable when there are several different types of assets with same name. Numbering should be done two diggits, as we suspect we won't get over 99 different assets with same name.

#### Unit setup

When modelling an issue that might be present is the scaling, as different systems and programs use different scaling or units as it is called. Currently we are using the scalling showed in the picture below, but we accept other as well. Make sure to include the unit setup if you use other settings when uploading models.
![Unit reference picture](https://s1.postimg.org/4bqgaw43db/Untitled.png)


#### Textures

All textures, regardless if they belong to tiles, objects or characters are to be placed in the texture folder. The texture format is not important, but preferable png due to it's alpha channel support (transparent colors and some other features that the jpg format do not support). Also it is preferable that textures are in size of power of two (like 128 / 128 , 256 / 256, 512 / 512, 1024 / 1024 and so on). It is possible to have various sizes, like 1025 / 256, but keep power of two in mind.

#### Tiles

Tiles are the enviroment itself (and in plains case is a grassy, green and lush enviroment). The game will support several enviroments, but currently the main focus is to create tileset for the planes enviroment. The enviroment have a set size, due to randomnice tile feature (different types of same tileset can be put togheter to create some variety and re-playability). The size is set to 10 x 10 metres. Hight is not specified yet, but currently the standard has been set to 4 metres (rock sides and so on). Preferable the tiles should be seamless, that means being able to be connected with other tiles without too much of a obvious seam. If there are limitation to which direction the tiles can be connected it's preferable that the name suggest what limitations there are. For example plainsWestSea suggests that the tile can be conntected to other tiles from north, south and west (unless that is a sea tile). Lastly the object itself should be named the same as the model files as it, again, makes the work easier to combine tiles.

#### Objects

Objects are the things you will enounter / see in the enviroment itself. This means rocks, trees, various assets and so on. Remember that the textures related to objects also should be placed in the texture path. There might be change to this in future, but for now use this. There currently are no specifications of ojects, but preferable not too big. Unit size should be in meters and size 1 / 1 (important to remember if you use other modelling programs like 3DS Max / Blender and so on). Also polugon count should be game-ready, that means low as possible but sifficient to see what the object is meant to be. Ideally the polycount for one single object should be within 4 diggits, but in special cases 5 diggits should work. Ideally tho, keep it under 5 diggits (10000). If the object has an animation, set the animation to 100 frames / "ticks", take a look on the treasure chest and animated barrel to see examples of this. In addition there is an object list, please see the readme in the object subfolder. Lastly, uv mapped / textured objects is a timesaver to work with at later stages (please?).

#### Game characters

Game characters are an generalization of both human player and the AI. It can be the human controlled character, it can be friendly AI controller players, enemies / foes or general objects that should act as a living thing. Ideally, the characters should support animations. An human controlled character should have an idle state (what does it do when just standing still and doing nothing, breathing and small motoristic movements), an movement staee (jogs / runs, heavy movement with both upper and lower body, more visually affected by the the forces of nature) and an attack state (swings towards certain direction with the upper body and arms to hit something, might coupled with a defensive back-track shortly after). As of timeframe the animations should be short, ideally within 100 frames at 1 / 1 speed (in 3ds max, but it's not that important as we can scale the speed to fit the game on our part). As before, the character sohuld be game-ready and withing the 5 diggits polycount and placed in the gameCharacter folder (within Assets).

#### Audio

Audio is the sounds of the game, both in terms of character / object sounds but also music. The format to use ise MP3 in either 128kbps or 256kbps bitrate. Please check the section and issues / project to see what sounds is allready implemented and which one is neeeded. Also keep in mind peaks and lows on audio recordings to prevent audio clipping or noticeable disturbance. 

## Winning conditions

As this game is a roguelike game, there is no clear main scenario or story. The rules that follows the levels can change from level to level, and the goal itself is to master the rules of the said levels to advance to next one. As with the rest of the game we want to be able to add several new rules as we progress further into the development, and not locking ourselves into certain rules. The current rules, or winning conditions for completeing the levels is at current stage following: 

1: Find door and interact with it - standing on certain point reveals doors or hit a collision box / trigger box to reveal door.

2: Find item / find several items - find key and use it on door / collect xx amount of items to open the door.

3: Find item and use item on another item - find an item that can be used together / combined with another item.

4: Find item to open door - picking up a item reveals the door.

5: Kill certain character to open locked door - killing an enemy based on combat unlocks the door which is visible from the start.  


## Complete levels

As we progressed and are progressing in the project, it turns out that the randomization of tiles is more difficult than first anticipated. We therefor will not have time to implement this feature within the timeframe of this project (deadline is 05 of july). Therefor we have desided to built the levels from scratch, one at a time. The levels that are complete are to be put within a subfolder of completeLevels, and should be named logically. In other words, level04 has it's own subfolder which contains a readme with information about the model as well as the model itself. Please see the readme and copy it's structure when making new levels. To save space you can xref (reference) objects which is allready created for the game in the object folder as well as textures. In addition, please try to enforce the modeling rules establised within the [Contribution](#contribution) part of this documentation. 

## Camera

The idea is to have an isometric camera angle. Currently the camera angle is set to aprox. 53,5 degrees with full rotation to left and right, utilizing the 3D structure of the game and it's 3D modells. Please note that the camera angle behaves differently on 16/9 and 4/3 monitors, therefore we advice reading more about this at following link: http://www.wolframalpha.com/input/?i=atan(4%2F3) to calculate ideal camera angles. 

## License
[GPL3.0](https://github.com/TheMelcor/213/blob/master/LICENSE)


## Credits
https://github.com/Cmoen11/BuffBot for guidance of functional readme / instruction page 



http://soundimage.org by Eric Matyas for the music in the game. Great page and great sharing philosophy 


http://tf3dm.com/3d-model/rigged-stick-figure-by-swp-2-55987.html by swpws for the character model


[Back to top](#table-of-contents)

