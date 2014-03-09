﻿namespace Talk
{
    partial class TalkServer
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
            this.label1 = new System.Windows.Forms.Label();
            this.monitor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.stat = new System.Windows.Forms.Label();
            this.typeStat = new System.Windows.Forms.Label();
            this.list = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "History Message";
            // 
            // monitor
            // 
            this.monitor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.monitor.Location = new System.Drawing.Point(14, 24);
            this.monitor.Multiline = true;
            this.monitor.Name = "monitor";
            this.monitor.ReadOnly = true;
            this.monitor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.monitor.Size = new System.Drawing.Size(198, 232);
            this.monitor.TabIndex = 1;
            this.monitor.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Connection List";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Host";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(99, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // stat
            // 
            this.stat.AutoSize = true;
            this.stat.Location = new System.Drawing.Point(159, 9);
            this.stat.Name = "stat";
            this.stat.Size = new System.Drawing.Size(51, 12);
            this.stat.TabIndex = 6;
            this.stat.Text = "OFFLINE";
            // 
            // typeStat
            // 
            this.typeStat.AutoSize = true;
            this.typeStat.Location = new System.Drawing.Point(216, 259);
            this.typeStat.Name = "typeStat";
            this.typeStat.Size = new System.Drawing.Size(0, 12);
            this.typeStat.TabIndex = 7;
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.ItemHeight = 12;
            this.list.Location = new System.Drawing.Point(218, 24);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(97, 232);
            this.list.TabIndex = 8;
            // 
            // TalkServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 299);
            this.Controls.Add(this.list);
            this.Controls.Add(this.typeStat);
            this.Controls.Add(this.stat);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monitor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TalkServer";
            this.Text = "TalkServer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.disposeall);
            this.Load += new System.EventHandler(this.TalkServer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox monitor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label stat;
        private System.Windows.Forms.Label typeStat;
        private System.Windows.Forms.ListBox list;
    }
}

