namespace ChatClient
{
    partial class Form2_EnterName
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
            this.tb_UserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_UserName = new System.Windows.Forms.Button();
            this.lbl_BadUserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_UserName
            // 
            this.tb_UserName.Location = new System.Drawing.Point(15, 25);
            this.tb_UserName.MaxLength = 32;
            this.tb_UserName.Name = "tb_UserName";
            this.tb_UserName.Size = new System.Drawing.Size(189, 20);
            this.tb_UserName.TabIndex = 0;
            this.tb_UserName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter your user name.";
            // 
            // btn_UserName
            // 
            this.btn_UserName.Location = new System.Drawing.Point(210, 23);
            this.btn_UserName.Name = "btn_UserName";
            this.btn_UserName.Size = new System.Drawing.Size(75, 23);
            this.btn_UserName.TabIndex = 2;
            this.btn_UserName.Text = "OK";
            this.btn_UserName.UseVisualStyleBackColor = true;
            this.btn_UserName.Click += new System.EventHandler(this.btn_UserName_Click);
            // 
            // lbl_BadUserName
            // 
            this.lbl_BadUserName.AutoSize = true;
            this.lbl_BadUserName.Location = new System.Drawing.Point(129, 9);
            this.lbl_BadUserName.Name = "lbl_BadUserName";
            this.lbl_BadUserName.Size = new System.Drawing.Size(139, 13);
            this.lbl_BadUserName.TabIndex = 3;
            this.lbl_BadUserName.Text = "Invalid user name, try again.";
            this.lbl_BadUserName.Visible = false;
            // 
            // Form2_EnterName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 63);
            this.Controls.Add(this.lbl_BadUserName);
            this.Controls.Add(this.btn_UserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_UserName);
            this.Name = "Form2_EnterName";
            this.Text = "User name";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_EnterName_FormClosing);
            this.Load += new System.EventHandler(this.Form2_EnterName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_UserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_UserName;
        private System.Windows.Forms.Label lbl_BadUserName;
    }
}