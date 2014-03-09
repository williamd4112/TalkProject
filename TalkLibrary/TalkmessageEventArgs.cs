using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalkLibrary
{
    public class TalkmessageEventArgs:EventArgs
    {
        private string message;
        private string nickname;
        private string messageType;
        private Talkconnection connection;

        public string Message { get { return message; } }
        public string Nickname { get { return nickname; } }
        public string MessageType { get { return messageType; } }
        public Talkconnection Connection { get { return connection; } }

        public TalkmessageEventArgs(string message , string messageType, Talkconnection connection)
            : base()
        {
            this.message = message;
            this.connection = connection;
            this.messageType = messageType;
        }

        
    }
}
