# The Game (obvious placeholder is obvious)


## Table of contents

* [Contribution](#contribution)
    * [Naming convention](#naming-convention)
    * [Textures](#textures)
    * [Tiles (the environment)](#tiles-(the-environment))
    * [Objects](#objects)
    * [Game characters](#game-characters)
    * [Audio](#audio)
* [Scenaros / winning conditions](#scenaros-/-winning-conditions]
* [License](#license)
* [Credits](#credits)


### Contribution

**Naming convention**

When naming assets, please enforce logical naming (an barrel object would be named a barrel while a charater sounds would be named something like characterAction01). The start of the name should be with lower case, and new words should be upper case without space or underscore. Examples on this can be characterAction01, doorAnimated02, musicCalm01 and so on. Number the assets is preferable when there are several different types of assets with same name. Numbering should be done two diggits, as we suspect we won't get over 99 different assets with same name.

**Textures**

All textures, regardless if they belong to tiles, objects or characters are to be placed in the texture folder. The texture format is not important, but preferable png due to it's alpha channel support (transparent colors and some other features that the jpg format do not support). Also it is preferable that textures are in size of power of two (like 128 / 128 , 256 / 256, 512 / 512, 1024 / 1024 and so on). It is possible to have various sizes, like 1025 / 256, but keep power of two in mind.

**Tiles (the environment)**

Tiles are the enviroment itself (and in plains case is a grassy, green and lush enviroment). The game will support several enviroments, but currently the main focus is to create tileset for the planes enviroment. The enviroment have a set size, due to randomnice tile feature (different types of same tileset can be put togheter to create some variety and re-playability). The size is set to 10 x 10 metres. Hight is not specified yet, but currently the standard has been set to 4 metres (rock sides and so on). Preferable the tiles should be seamless, that means being able to be connected with other tiles without too much of a obvious seam. If there are limitation to which direction the tiles can be connected it's preferable that the name suggest what limitations there are. For example plainsWestSea suggests that the tile can be conntected to other tiles from north, south and west (unless that is a sea tile). Lastly the object itself should be named the same as the model files as it, again, makes the work easier to combine tiles.

**Objects**

Objects are the things you will enounter / see in the enviroment itself. This means rocks, trees, various assets and so on. Remember that the textures related to objects also should be placed in the texture path. There might be change to this in future, but for now use this. There currently are no specifications of ojects, but preferable not too big. Unit size should be in meters and size 1 / 1 (important to remember if you use other modelling programs like 3DS Max / Blender and so on). Also polugon count should be game-ready, that means low as possible but sifficient to see what the object is meant to be. Ideally the polycount for one single object should be within 4 diggits, but in special cases 5 diggits should work. Ideally tho, keep it under 5 diggits (10000). If the object has an animation, set the animation to 100 frames / "ticks", take a look on the treasure chest and animated barrel to see examples of this. In addition there is an object list, please see the readme in the object subfolder. Lastly, uv mapped / textured objects is a timesaver to work with at later stages (please?).

**Game characters**

Game characters are an generalization of both human player and the AI. It can be the human controlled character, it can be friendly AI controller players, enemies / foes or general objects that should act as a living thing. Ideally, the characters should support animations. An human controlled character should have an idle state (what does it do when just standing still and doing nothing, breathing and small motoristic movements), an movement staee (jogs / runs, heavy movement with both upper and lower body, more visually affected by the the forces of nature) and an attack state (swings towards certain direction with the upper body and arms to hit something, might coupled with a defensive back-track shortly after). As of timeframe the animations should be short, ideally within 100 frames at 1 / 1 speed (in 3ds max, but it's not that important as we can scale the speed to fit the game on our part). As before, the character sohuld be game-ready and withing the 5 diggits polycount and placed in the gameCharacter folder (within Assets).

**Audio**

Audio is the sounds of the game, both in terms of character / object sounds but also music. The format to use ise MP3 in either 128kbps or 256kbps bitrate. Please check the section and issues / project to see what sounds is allready implemented and which one is neeeded. Also keep in mind peaks and lows on audio recordings to prevent audio clipping or noticeable disturbance. 

**Scenaros / winning conditions**

As this game is a roguelike game, there is no clear main scenario or story. The rules that follows the levels can change from level to level, and the goal itself is to master the rules of the said levels to advance to next one. As with the rest of the game we want to be able to add several new rules as we progress further into the development, and not locking ourselves into certain rules. The current rules, or winning conditions for completeing the levels is at current stage following: 
List of currently planned winning conditions / scenarios: 
1: Find door and interact with it - standing on certain point reveals doors or hit a collision box / trigger box to reveal door.
2: Find item / find several items - find key and use it on door / collect xx amount of items to open the door.
3: Find item and use item on another item - find an item that can be used together / combined with another item.
4: Find item to open door - picking up a item reveals the door.
5: Kill certain character to open locked door - killing an enemy based on combat unlocks the door which is visible from the start.  


## License
[GPL3.0](https://github.com/TheMelcor/213/blob/master/LICENSE)


## Credits
https://github.com/Cmoen11/BuffBot for guidance of functional readme / instruction page
