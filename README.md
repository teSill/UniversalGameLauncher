# Universal Game Launcher

## Key features:
- Easy to use and customize
- Version checking/Auto updating of your game
- Grab XML data from the server to display things like the built-in patch notes
- Will work with games from any game engine (Unity, Unreal Engine, Godot, any!)

![image_1](http://temsoft.io/launcher/Launcher_Ready.png)
![image_2](http://temsoft.io/launcher/Launcher_Updating.png)




## Setting it up:

The application is written in Visual Studio 2017.

Everything that you need to modify to get the launcher working with your settings, is in the "Constants.cs" class. Assuming that you've already downloaded and opened the solution (UniversalGameLauncher.sln), go ahead and open up Constants.cs now.

1. Let's start by entering your game's name in the "GAME_TITLE" field. This should be the name of your executable game client.

2. Set up the path for your game if you'd like. By default, the data gets saved into your home directory in a folder by the name of "GAME_TITLE".

3. Let's now upload the necessary files to get everything up and running:

3.1. Pack your client along with whatever else files are necessary for the client to run into a ZIP file. Make sure that the client you want the launcher to run shares the value of "GAME_TITLE" in Constants.cs

3.2. Create a text file called "version.txt" and enter the number "1.0.0.0" (or similar) into it. That's it. 

3.3. Lastly, the XML file for our patch notes. Download or copy the contents from https://temsoft.io/temsoft_assets/updates.xml and modify the text to your liking.

3.4. Although not required to run, now might be a good time to grab your desired logo, icon and background for the launcher as well.

4. Now upload these items onto a host of your choosing. Ideally one that you know will keep the files up and alive.

5. Next, you'll want to add the URLs of your recently uploaded items. This should be pretty self-explanatory, but make sure that the file extensions are correct.

6. Now we should arrive at the navigation bar buttons. Give them the names and links that you wish.

7. At the bottom you'll find some basic settings for the launcher. Change them up how you'd like. Or don't. Up to you.

8. Once you're done editing the class, hit the "Build" button at the top and open up "Configuration Manager". On the first dropdown list, select "Release" instead of "Debug". Close the window. Click "Build" again, and then "Build solution". Done. Your updated launcher is now in \bin\release\.

## Auto Updating

The application's version will start at 1.0.0.0, as should the text file's value that you uploaded earlier. When you upload a new version of your game and want the launcher to prompt an update, all you have to do is raise the value of the number in your "version.txt" file. 
This will create a mismatch between the launcher's local version and the version you're hosting on your server, and the launcher will prompt to re-download your game the next time it's ran.

This might also be a good time to update your updates.xml file with the latest patch notes, if that's something you're keeping track of.


## Support

For support, inquiries or anything else, you can contact me at https://temsoft.io
