using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalGameLauncher {
    class Constants {

        /// <summary>
        /// Core game info
        /// </summary>
        public static readonly string GAME_NAME = "YourGameName";

        /// <summary>
        /// Paths & urls
        /// </summary>
        public static readonly string FOLDER_NAME = GAME_NAME;
        public static readonly string EXECUTABLE_NAME = GAME_NAME + ".exe";
        public static readonly string FOLDER_PATH = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), FOLDER_NAME);
        public static readonly string EXECUTABLE_PATH = Path.Combine(FOLDER_PATH, EXECUTABLE_NAME);

        public static readonly string VERSION_URL = "https://temsoft.io/version.txt";

        public static readonly string FIRST_DOWNLOADABLE_ITEM = "https://temsoft.io/UnityNetworking.zip";
        public static readonly string SECOND_DOWNLOADABLE_ITEM = "";

        /// <summary>
        /// Navigation bar buttons
        /// </summary>
        public static readonly string NAVBAR_BUTTON_1_TEXT = "Website";
        public static readonly string NAVBAR_BUTTON_1_URL = "https://temsoft.io/";
        public static readonly string NAVBAR_BUTTON_2_TEXT = "Community";
        public static readonly string NAVBAR_BUTTON_2_URL = "https://google.com/";
        public static readonly string NAVBAR_BUTTON_3_TEXT = "Support";
        public static readonly string NAVBAR_BUTTON_3_URL = "https://youtube.com/";
        public static readonly string NAVBAR_BUTTON_4_TEXT = "Discord";
        public static readonly string NAVBAR_BUTTON_4_URL = "https://github.com/";

        public static readonly string[] NAVBAR_BUTTON_TEXT_ARRAY = {NAVBAR_BUTTON_1_TEXT, NAVBAR_BUTTON_2_TEXT, NAVBAR_BUTTON_3_TEXT, NAVBAR_BUTTON_4_TEXT };

        /// <summary>
        /// Messages & text
        /// </summary>
        public static readonly string DOWNLOAD_FINISHED_MESSAGE = "Download finished! You can now play the game.";

        /// <summary>
        /// Settings
        /// </summary>
        public static bool SHOW_VERSION_TEXT = true;
        public static bool AUTOMATICALLY_BEGIN_UPDATING = false;

    }
}
