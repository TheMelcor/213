**This readme will be updated as more details are clear!**

1: Use the readme, and if unsure - ask before doing anything

2: Use pull request to start the process of contribute to the project, and again - ask if unsure

3: Never push into master, fork and work in seprate branches which in time can be merged into developer branch (called dev)

4: We are honored by the interest of other people and contributions & interests. This is an open sources project and we will strive to accept most of the contributions as long as they do not violate some part of point #5

5: No copyrighted material, no offensive (in terms of racisms, hate and so on) material are to be contributed into the project

6: No profitable gains are to be received by this. You might use any assets from this project however you like, but no profitable gains are to be gained

**Below we have given specific details on the assets related to the game, please take a moment to read them before contributing**

**Textures**

All textures, regardless if they belong to tiles, objects or characters are to be placed in the texture folder. The texture format is not important, but preferable png due to it's alpha channel support (transparent colors and some other features that the jpg format do not support). Also it is preferable that textures are in size of power of two (like 128 / 128 , 256 / 256, 512 / 512, 1024 / 1024 and so on). It is possible to have various sizes, like 1025 / 256, but keep power of two in mind. 

**Tiles (the environment)**

Tiles are the enviroment itself (and in plains caseit is a grassy, green and lush enviroment). The game will support several enviroments, but currently the main focus is to create tileset for the planes enviroment. The enviroment have a set size, due to randomnice tile feature (different types of same tileset can be put togheter to create some variety and re-playability). The size is set to 10 x 10 metres. Hight is not specified yet, but currently the standard has been set to 4 metres (rock sides and so on). Preferable the tiles should be seamless, that means being able to be connected with other tiles without too much of a obvious seam. If there are limitation to which direction the tiles can be connected it's preferable that the name suggest what limitations there are. For example plainsWestSea suggests that the tile can be conntected to other tiles from north, south and west (unless that is a sea tile). Lastly the object itself should be named the same as the model files as it, again, makes the work easier to combine tiles.

**Objects**

Objects are the things you will enounter / see in the enviroment itself. This means rocks, trees, various assets and so on. Remember that the textures related to objects also should be placed in the texture path. There might be change to this in future, but for now use this. There currently are no specifications of ojects, but preferable not too big. Unit size should be in meters and size 1 / 1 (important to remember if you use other modelling programs like 3DS Max / Blender and so on). Also polugon count should be game-ready, that means low as possible but sifficient to see what the object is meant to be. Ideally the polycount for one single object should be within 4 diggits, but in special cases 5 diggits should work. Ideally tho, keep it under 5 diggits (10000). If the object has an animation, set the animation to 100 frames / "ticks", take a look on the treasure chest and animated barrel to see examples of this.
In addition there is an object list, please see the readme in the object subfolder. Lastly, uv mapped / textured objects is a timesaver to work with at later stages (please?). 

**Game characters**

Game characters are an generalization of both human player and the AI. It can be the human controlled character, it can be friendly AI controller players, enemies / foes or general objects that should act as a living thing. Ideally, the characters should support animations. An human controlled character should have an idle state (what does it do when just standing still and doing nothing, breathing and small motoristic movements), an movement staee (jogs / runs, heavy movement with both upper and lower body, more visually affected by the the forces of nature) and an attack state (swings towards certain direction with the upper body and arms to hit something, might coupled with a defensive back-track shortly after). As of timeframe the animations should be short, ideally within 100 frames at 1 / 1 speed (in 3ds max, but it's not that important as we can scale the speed to fit the game on our part). As before, the character sohuld be game-ready and withing the 5 diggits polycount and placed in the gameCharacter folder (within Assets).
