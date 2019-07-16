using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalGameLauncher {
    class Constants : Application {

        /// <summary>
        /// Core game info
        /// </summary>
        public static readonly string GAME_TITLE = "TemsoftAutoClicker";
        public static readonly string LAUNCHER_NAME = "Temsoft Launcher";

        /// <summary>
        /// Paths & urls
        /// </summary>
        public static readonly string DESTINATION_PATH = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), GAME_TITLE);
        public static readonly string ZIP_PATH = Path.Combine(DESTINATION_PATH, GAME_TITLE + ".zip");
        public static readonly string GAME_EXECUTABLE_PATH = Path.Combine(DESTINATION_PATH, GAME_TITLE + ".exe");

        public static readonly string VERSION_URL = "https://temsoft.io/version.txt";
        public static readonly string APPLICATION_ICON_URL = "https://temsoft.io/temsoft_assets/temsoft_logo_ico.ico"; // Needs to be .ico
        public static readonly string LOGO_URL = "https://temsoft.io/temsoft_assets/Placeholder_Logo_White_280x58.png"; // Ideally around 283x75
        public static readonly string BACKGROUND_URL = "https://temsoft.io/temsoft_assets/fantasy-3077928_1280.jpg";
        public static readonly string PATCH_NOTES_URL = "https://temsoft.io/temsoft_assets/updates.xml";
        public static readonly string CLIENT_DOWNLOAD_URL = "https://temsoft.io/temsoft_assets/TemsoftAutoClicker.zip";

        /// <summary>
        /// Navigation bar buttons
        /// </summary>
        public static readonly string NAVBAR_BUTTON_1_TEXT = "Website";
        public static readonly string NAVBAR_BUTTON_1_URL = "https://temsoft.io/";
        public static readonly string NAVBAR_BUTTON_2_TEXT = "News";
        public static readonly string NAVBAR_BUTTON_2_URL = "https://google.com/";
        public static readonly string NAVBAR_BUTTON_3_TEXT = "Community";
        public static readonly string NAVBAR_BUTTON_3_URL = "https://youtube.com/";
        public static readonly string NAVBAR_BUTTON_4_TEXT = "Support";
        public static readonly string NAVBAR_BUTTON_4_URL = "https://github.com/";
        public static readonly string NAVBAR_BUTTON_5_TEXT = "Discord";
        public static readonly string NAVBAR_BUTTON_5_URL = "https://github.com/";

        // Modify this array if you're adding or removing a button
        public static readonly string[] NAVBAR_BUTTON_TEXT_ARRAY = {NAVBAR_BUTTON_1_TEXT, NAVBAR_BUTTON_2_TEXT, NAVBAR_BUTTON_3_TEXT,
                                                                    NAVBAR_BUTTON_4_TEXT, NAVBAR_BUTTON_5_TEXT };

        /// <summary>
        /// Settings
        /// </summary>
        public static bool SHOW_VERSION_TEXT = true;
        public static bool AUTOMATICALLY_BEGIN_UPDATING = false;
        public static bool AUTOMATICALLY_LAUNCH_GAME_AFTER_UPDATING = false;
        public static bool SHOW_ERROR_BOX_IF_PATCH_NOTES_DOWNLOAD_FAILS = true;

    }
}
