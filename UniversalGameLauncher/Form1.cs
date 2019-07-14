using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace UniversalGameLauncher {
    public partial class Application : Form {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Version LocalVersion { get { return new Version(Properties.Settings.Default.VersionText); } }
        public Version OnlineVersion { get; private set; }

        private bool _isReady;
        public bool IsReady {
            get {
                return _isReady;
            }
            set {
                _isReady = value;
                TogglePlayButton(value);
            }
        }

        public bool UpToDate { get { return LocalVersion >= OnlineVersion; } }

        public Application() {
            InitializeComponent();

        }

        private void OnLoadApplication(object sender, EventArgs e) {
            SetUpButtonEvents();
            InitializeFiles();
            InitializeVersionControl();

            IsReady = UpToDate;

            if (!UpToDate && Constants.AUTOMATICALLY_BEGIN_UPDATING) {
                DownloadFile();
            }

            navbarPanel.BackColor = Color.FromArgb(25, 100, 100, 100);
        }

        private void InitializeVersionControl() {
            currentVersionLabel.Visible = Constants.SHOW_VERSION_TEXT;

            currentVersionLabel.Text = Properties.Settings.Default.VersionText;
            OnlineVersion = GetOnlineVersion();

            Console.WriteLine("We are on version " + LocalVersion + " and the online version is " + OnlineVersion);
        }

        private void InitializeFiles() {
            if (!Directory.Exists(Constants.FOLDER_PATH)) {
                Directory.CreateDirectory(Constants.FOLDER_PATH);
            } 
        }

        private Version GetOnlineVersion() {
            try {
                string onlineVersion = new WebClient().DownloadString(Constants.VERSION_URL);
                Console.WriteLine(LocalVersion >= new Version(onlineVersion));
                Version.TryParse(onlineVersion, out Version result);
                return result;
            } catch {
                MessageBox.Show("The launcher was unable to read the current client version from the server!", "Fatal error");
                return null;
            }
        }

        private void OnClickPlay(object sender, EventArgs e) {
            if (IsReady) {
                Environment.Exit(0);
            } else {
                DownloadFile();
            }
        }

        private void DownloadFile() {
            using (WebClient webclient = new WebClient()){ 
                webclient.DownloadProgressChanged += OnDownloadProgressChanged;
                webclient.DownloadFileCompleted += new AsyncCompletedEventHandler(OnDownloadCompleted);
                webclient.DownloadFileAsync (
                    // Link to file, Path to file
                    new System.Uri(Constants.FIRST_DOWNLOADABLE_ITEM), Constants.EXECUTABLE_PATH
                );
            }
        }

        private void OnDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e) {
            updateProgressBar.Value = e.ProgressPercentage;
            updateLabelText.Text = string.Format("Downloaded {0} of {1}", StringUtility.FormatBytes(e.BytesReceived), StringUtility.FormatBytes(e.TotalBytesToReceive));
        }
        private void OnDownloadCompleted(object sender, AsyncCompletedEventArgs e) {
            updateLabelText.Text = Constants.DOWNLOAD_FINISHED_MESSAGE;
            currentVersionLabel.Text = OnlineVersion.ToString();
            Properties.Settings.Default.VersionText = OnlineVersion.ToString();
            Properties.Settings.Default.Save();
            Console.WriteLine("Updated version. Now running on version: " + LocalVersion);
            IsReady = true;
        }

        private void TogglePlayButton(bool toggle) {
            switch(toggle) {
                case true:
                    playButton.BackColor = Color.Green;
                    playButton.Text = "Play";
                    break;
                case false:
                    playButton.BackColor = Color.DeepSkyBlue;
                    playButton.Text = "Update";
                    break;
            }
        }
        
        // Move the form with LMB
        private void Application_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        
        private void SetUpButtonEvents() {
            Button[] buttons = { navbarButton1, navbarButton2, navbarButton3, navbarButton4 };

            for(int i = 0; i < buttons.Length; i++) {
                buttons[i].Click += new EventHandler(OnClickButton);
                buttons[i].Text = Constants.NAVBAR_BUTTON_TEXT_ARRAY[i];
            }
        }

        public void OnClickButton(object sender, EventArgs e) {
            var button = (Button) sender;
            switch(button.Name) {
                case nameof(navbarButton1):
                    System.Diagnostics.Process.Start(Constants.NAVBAR_BUTTON_1_URL);
                    break;
                case nameof(navbarButton2):
                    System.Diagnostics.Process.Start(Constants.NAVBAR_BUTTON_2_URL);
                    break;
                case nameof(navbarButton3):
                    System.Diagnostics.Process.Start(Constants.NAVBAR_BUTTON_3_URL);
                    break;
                case nameof(navbarButton4):
                    System.Diagnostics.Process.Start(Constants.NAVBAR_BUTTON_4_URL);
                    break;
            }
        }
    }
}
