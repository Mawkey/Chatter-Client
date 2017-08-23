namespace ChatClient
{
    partial class Form1_Chat
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
            this.rt_Chat = new System.Windows.Forms.RichTextBox();
            this.tb_Send = new System.Windows.Forms.TextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_SetUserName = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_ConnectToServer = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_About = new System.Windows.Forms.ToolStripMenuItem();
            this.list_Users = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rt_Chat
            // 
            this.rt_Chat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rt_Chat.BackColor = System.Drawing.Color.White;
            this.rt_Chat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rt_Chat.HideSelection = false;
            this.rt_Chat.Location = new System.Drawing.Point(250, 32);
            this.rt_Chat.Name = "rt_Chat";
            this.rt_Chat.ReadOnly = true;
            this.rt_Chat.Size = new System.Drawing.Size(424, 210);
            this.rt_Chat.TabIndex = 0;
            this.rt_Chat.Text = "";
            this.rt_Chat.TextChanged += new System.EventHandler(this.rt_Chat_TextChanged);
            // 
            // tb_Send
            // 
            this.tb_Send.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Send.Enabled = false;
            this.tb_Send.Location = new System.Drawing.Point(250, 248);
            this.tb_Send.MaxLength = 5000;
            this.tb_Send.Multiline = true;
            this.tb_Send.Name = "tb_Send";
            this.tb_Send.Size = new System.Drawing.Size(342, 102);
            this.tb_Send.TabIndex = 1;
            this.tb_Send.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Send_KeyDown);
            // 
            // btn_Send
            // 
            this.btn_Send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Send.BackColor = System.Drawing.Color.LightCyan;
            this.btn_Send.Enabled = false;
            this.btn_Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Send.ForeColor = System.Drawing.Color.LightBlue;
            this.btn_Send.Location = new System.Drawing.Point(598, 248);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(75, 101);
            this.btn_Send.TabIndex = 2;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = false;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Azure;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.ts_About});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_SetUserName,
            this.ts_ConnectToServer});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem1.Text = "Options";
            // 
            // ts_SetUserName
            // 
            this.ts_SetUserName.Name = "ts_SetUserName";
            this.ts_SetUserName.Size = new System.Drawing.Size(167, 22);
            this.ts_SetUserName.Text = "Set user name";
            this.ts_SetUserName.Click += new System.EventHandler(this.ts_SetUserName_Click);
            // 
            // ts_ConnectToServer
            // 
            this.ts_ConnectToServer.Enabled = false;
            this.ts_ConnectToServer.Name = "ts_ConnectToServer";
            this.ts_ConnectToServer.Size = new System.Drawing.Size(167, 22);
            this.ts_ConnectToServer.Text = "Connect to server";
            this.ts_ConnectToServer.Click += new System.EventHandler(this.ts_ConnectToServer_Click);
            // 
            // ts_About
            // 
            this.ts_About.Name = "ts_About";
            this.ts_About.Size = new System.Drawing.Size(52, 20);
            this.ts_About.Text = "About";
            this.ts_About.Click += new System.EventHandler(this.ts_About_Click);
            // 
            // list_Users
            // 
            this.list_Users.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.list_Users.FormattingEnabled = true;
            this.list_Users.Location = new System.Drawing.Point(12, 32);
            this.list_Users.Name = "list_Users";
            this.list_Users.Size = new System.Drawing.Size(232, 316);
            this.list_Users.TabIndex = 4;
            // 
            // Form1_Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(684, 362);
            this.Controls.Add(this.list_Users);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.tb_Send);
            this.Controls.Add(this.rt_Chat);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1_Chat";
            this.Text = "Chat Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_Chat_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rt_Chat;
        private System.Windows.Forms.TextBox tb_Send;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ts_SetUserName;
        private System.Windows.Forms.ToolStripMenuItem ts_ConnectToServer;
        private System.Windows.Forms.ToolStripMenuItem ts_About;
        private System.Windows.Forms.ListBox list_Users;
    }
}

