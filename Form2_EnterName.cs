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
using System.IO;

namespace ChatClient
{
    public partial class Form2_EnterName : Form
    {
        string userName;

        public string UserName
        {
            get { return userName; }
        }

        public Form2_EnterName()
       {
            userName = "";
            InitializeComponent();
            AcceptButton = btn_UserName;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_EnterName_Load(object sender, EventArgs e)
        {

        }

        private void Form2_EnterName_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (String.IsNullOrEmpty(userName))
            {
                Environment.Exit(0);
            }
        }

        private void btn_UserName_Click(object sender, EventArgs e)
        {

            //todo: Grab user name from text box.
            userName = tb_UserName.Text;

                //Sends userName to formChat if it's not empty.
                if (!String.IsNullOrEmpty(userName))
                {
                    this.Hide();
                }
                else
                {
                    lbl_BadUserName.Visible = true;
                }

        }
    }
}
