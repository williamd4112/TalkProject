using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Permissions;

namespace TalkLibrary
{
    //Define a connection 
    public class Talkconnection : Talkgeneral
    {
        //message事件
        public event messageEventhandler messageEvent;

        private TcpClient client;
        private Talkuser clientUser;

        public TcpClient Client { get { return client; } }
        public Talkuser ClientUser { get { return clientUser; } }

        //建構式
        public Talkconnection(TcpClient client)
        {
            encoder = new UnicodeEncoding();
            this.client = client;
            this.clientUser = new Talkuser();
            this.clientUser.Username = "Anonymous";
        }

        //功能 : 觸發message事件
        public void messageComing(TalkmessageEventArgs e)
        {
            if (messageEvent != null)
                messageEvent(this , e);
        }

    }
}
