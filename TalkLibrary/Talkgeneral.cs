using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalkLibrary
{
    public class Talkgeneral
    {
        public delegate void messageEventhandler(object sender , TalkmessageEventArgs e);
        public UnicodeEncoding encoder;
    }
}
