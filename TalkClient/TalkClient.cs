using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Globalization;
using TalkLibrary;



namespace TalkClient
{
    public partial class TalkClient : Form
    {
        private delegate void updateUICallback(string text, string type);

        private UnicodeEncoding encoder;

        private TcpClient tcpclient;
        private UdpClient udpclient;
        private IPAddress serverIPAddress;
        private IPEndPoint serverIPEndpoint;
        private NetworkStream clientStream;
        private List<Talkuser> userlist;
        
        private Thread monitorThread;

        private string nickname;

        public TalkClient()
        {
            tcpclient = new TcpClient();
            udpclient = new UdpClient();
            encoder = new UnicodeEncoding();
            userlist = new List<Talkuser>();
            monitorThread = new Thread(new ThreadStart(monitorProc));
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TalkClient_Load(object sender, EventArgs e)
        {

        }

        private void monitorProc()
        {
            BinaryFormatter bin = new BinaryFormatter();
            while (true)
            {
                try
                {
                    CompareInfo stringprocceser = CultureInfo.InvariantCulture.CompareInfo;
                    byte[] buffer = new byte[4096];
                    string type;

                    clientStream.Read(buffer, 0, buffer.Length);
                    type = encoder.GetString(buffer);

                    if (encoder.GetString(buffer).CompareTo("TEXT") == 0)
                    {
                        clientStream.Read(buffer, 0, buffer.Length);
                        updateUI(encoder.GetString(buffer), "Monitor");  
                    }
                    if (encoder.GetString(buffer).CompareTo("USER") == 0)
                    {
                        userlist = (List<Talkuser>)bin.Deserialize(clientStream);
                        updateUI("" , "List");
                    }
                }
                catch
                {
                }
            }
        }

        //功能 : 更新client端的UI
        public void updateUI(string text, string type)
        {
            if (this.InvokeRequired)
            {
                updateUICallback updateUICallback = new updateUICallback(updateUI);
                this.Invoke(updateUICallback, text, type);
            }
            else
            {
                if (type.Equals("Monitor"))
                    Monitor.AppendText(text + "\n");
                if (type.Equals("List"))
                {
                     List.Items.Clear();
                    foreach (Talkuser talkuser in userlist)
                        List.Items.Add(talkuser.Username);
                }
                   
            }
        }

        //功能 : 設定登入資訊登入指定Server
        private void login_Click(object sender, EventArgs e)
        {
            //設定登入資訊
            serverIPAddress = IPAddress.Parse(ip.Text);
            serverIPEndpoint = new IPEndPoint(serverIPAddress, 16000);
            udpclient.Connect(serverIPEndpoint);
            nickname = username.Text;

            ip.Enabled = false;
            username.Enabled = false;
            login.Enabled = false;

            try
            {
                byte[] buffer = new byte[4096];

                tcpclient.Connect(serverIPEndpoint);
                clientStream = tcpclient.GetStream();

                buffer = encoder.GetBytes(nickname);
                clientStream.Write(buffer, 0, buffer.Length);

                monitorThread.Start();

            }
            catch
            {
                MessageBox.Show("Server is offline");
                tcpclient.Close();
            }
        }
        //功能 : 擷取input中的訊息後送出,並且清除input
        private void send_Click(object sender, EventArgs e)
        {
            byte[] buffer = encoder.GetBytes(nickname + " : " +input.Text + "\n");

            clientStream.Write(buffer, 0, buffer.Length);
            clientStream.Flush();
            input.Clear();
            input.Select(input.SelectionStart, 0);
            
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void disconnectOnExit(object sender, FormClosedEventArgs e)
        {
            tcpclient.Close();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            monitorThread.Abort();
            tcpclient.Close();
        }

        private void disposeall(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void enterDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                input.Clear();
        }

        private void input_TextChanged(object sender, EventArgs e)
        {

        }

        private void enterUp(object sender, KeyEventArgs e)
        {

        }

        private void enterSend(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.send.Focus();
                this.send_Click(sender, e);
            }
        }

        private void enterPress(object sender, KeyPressEventArgs e)
        {    
        }
    }
}
