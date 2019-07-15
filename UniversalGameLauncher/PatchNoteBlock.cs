using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace UniversalGameLauncher {
    public class PatchNoteBlock {
        
        public string Title { get; set; }
        public string Text { get; set; }
        public string Link { get; set; }

        public PatchNoteBlock() {

        }
    }
}
