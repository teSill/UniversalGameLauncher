using ICSharpCode.SharpZipLib.Zip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalGameLauncher {
    class Extract {

        private Application _application;

        public Extract(Application application) {
            _application = application;
        }

        public void Run() {
            BackgroundWorker bgw = new BackgroundWorker {
                WorkerReportsProgress = true
            };

            bgw.DoWork += new DoWorkEventHandler(
                delegate(object o, DoWorkEventArgs args) {
                    BackgroundWorker bw = o as BackgroundWorker;
                    FastZip fastZip = new FastZip();
                    fastZip.ExtractZip(Constants.ZIP_PATH, Constants.DESTINATION_PATH, null);
            });
            
            bgw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(
            delegate(object o, RunWorkerCompletedEventArgs args) {
                _application.SetLauncherReady();
            });

            bgw.RunWorkerAsync();

        }
    }
}
