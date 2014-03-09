namespace TalkClient
{
    partial class TalkClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TalkClient));
            this.Monitor = new System.Windows.Forms.TextBox();
            this.input = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.ip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.List = new System.Windows.Forms.ListBox();
            this.logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Monitor
            // 
            this.Monitor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.Monitor, "Monitor");
            this.Monitor.Name = "Monitor";
            this.Monitor.ReadOnly = true;
            this.Monitor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // input
            // 
            resources.ApplyResources(this.input, "input");
            this.input.Name = "input";
            this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
            this.input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterDown);
            this.input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enterPress);
            this.input.KeyUp += new System.Windows.Forms.KeyEventHandler(this.enterUp);
            this.input.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.enterSend);
            // 
            // send
            // 
            resources.ApplyResources(this.send, "send");
            this.send.Name = "send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            this.send.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterDown);
            // 
            // login
            // 
            resources.ApplyResources(this.login, "login");
            this.login.Name = "login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // ip
            // 
            resources.ApplyResources(this.ip, "ip");
            this.ip.Name = "ip";
            this.ip.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // username
            // 
            resources.ApplyResources(this.username, "username");
            this.username.Name = "username";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // List
            // 
            this.List.FormattingEnabled = true;
            resources.ApplyResources(this.List, "List");
            this.List.Name = "List";
            // 
            // logout
            // 
            resources.ApplyResources(this.logout, "logout");
            this.logout.Name = "logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // TalkClient
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.logout);
            this.Controls.Add(this.List);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ip);
            this.Controls.Add(this.login);
            this.Controls.Add(this.send);
            this.Controls.Add(this.input);
            this.Controls.Add(this.Monitor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TalkClient";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.disposeall);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.disconnectOnExit);
            this.Load += new System.EventHandler(this.TalkClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Monitor;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox List;
        private System.Windows.Forms.Button logout;
    }
}

