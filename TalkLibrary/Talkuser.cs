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
    [Serializable]
    public class Talkuser
    {
        public enum stat
        {
            ALIVE,
            DEAD
        }
        protected string username;
        protected stat userstat;
        public string Username { get; set; }
        public stat Userstat { get; set; }

        public Talkuser()
        {
            Userstat = stat.ALIVE;
        }
       
    }
}
