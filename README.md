Develop branch for the plains enviroment. Below we will give guidance on how you can contribute to the project. 
First out, all textures, objects, tiles and game characters are to be put in subfolder of 213-game / Assets. 


**Textures**

All textures, regardless if they belong to tiles, objects or characters are to be placed in the texture folder. The texture format is not important, but preferable png due to it's alpha channel support (transparent colors and some other features that the jpg format do not support). Also it is preferable that textures are in size of power of two, (squares like 128 / 128 , 256 / 256, 512 / 512, 1024 / 1024 and so on). 



**Tiles (the environment)**

Tiles are the enviroment itself (and in this case planes, a grassy, green and lush enviroment). The game will support several enviroments, but currently the main focus is to create tileset for the planes enviroment. The enviroment have a set size, due to randomnice tile feature (different types of same tileset can be put togheter to create some variety and re-playability). The size is set to 10 x 10 metres. Hight is not specified yet, but currently the standard has been set to 4 metres (rock sides and so on). More details around this will come at a later time but for now use those measures. 



**Objects**

Objects are the things you will enounter / see in the enviroment itself. This means rocks, trees, various assets and so on. Remember that the textures related to objects also should be placed in the texture path. There might be change to this in future, but for now use this. 
There currently are no specifications of ojects, but preferable not too big. Unit size should be in meters and size 1 / 1 (important to remember if you use other modelling programs like 3DS Max / Blender and so on). Also polugon count should be game-ready, that means low as possible but sifficient to see what the object is meant to be. Ideally the polycount for one single object should be within 4 diggits, but in special cases 5 diggits should work. Ideally tho, keep it under 5 diggits (10000). 



**Game characters**

Game characters are an generalization of both human player and  the AI. It can be the human controlled character, it can be friendly AI controller players, enemies / foes or general objects that should act as a living thing. Ideally, the characters should support animations. An human controlled character should have an idle state (what does it do when just standing still and doing nothing, breathing and small motoristic movements), an movement staee (jogs / runs, heavy movement with both upper and lower body, more visually affected by the the forces of nature) and an attack state (swings towards certain direction with the upper body and arms to hit something, might coupled with a defensive back-track shortly after). As of timeframe the animations should be short, ideally within 100 frames at 1 / 1 speed (in 3ds max, but it's not that important as we can scale the speed to fit the game on our part).
As before, the character sohuld be game-ready and withing the 5 diggits polycount and placed in the gameCharacter folder (within Assets). 

This readme will be updated as more details are clear.
