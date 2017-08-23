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

namespace ChatClient
{
    public partial class Form1_Chat : Form
    {
        string userName;
        string toSend;
        Form2_EnterName enterNameForm;
        StreamReader reader;
        StreamWriter writer;
        TcpClient client;
        IPAddress serverIp;
        int port;



        public Form1_Chat()
        {
            enterNameForm = new Form2_EnterName();
            InitializeComponent();
            tb_Send.AcceptsReturn = false;
            this.AcceptButton = btn_Send;

            serverIp = IPAddress.Parse("192.168.1.4");
            port = 54545;
            client = new TcpClient();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string welcomeMessage = "To connect to the server"
                                  + " press Options > Set user name and then Options > "
                                  + "Connect to server.\r\n";

            rt_Chat.AppendText(welcomeMessage);
        }

        public void GetUserName(string userName)
        {
            this.userName = userName;
        }

        private void Form1_Chat_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            //Create the message with user name included.
            toSend = userName + ": " + this.tb_Send.Text;
            //Remove message from tb_Send.
            this.tb_Send.Clear();
            //Send message to server.
            SendMessage(toSend);

            toSend = "";
        }

        private void tb_Send_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Enter)
            {

            }
        }

        private void StartChat()
        {
            ConnectToServer();

            Thread clientThread = new Thread(new ThreadStart(RunChat));
            clientThread.Start();
        }

        private void RunChat()
        {
            string line = "";
            EnableChat();
            while (true)
            {
                //read the curent line
                line = reader.ReadLine();
                AppendToChat(line);
            }
        }

        //For cross thread exception.
        void EnableChat()
        {
            //Action to be performed should be called within { } as like below code
            if (this.tb_Send.InvokeRequired)
                tb_Send.Invoke(new MethodInvoker(() => { tb_Send.Enabled = true;
                                                         btn_Send.Enabled = true;
                                                         ts_SetUserName.Enabled = false;
                                                         ts_ConnectToServer.Enabled = false; }));
        }

        //For cross thread exception. Source: https://stackoverflow.com/questions/5868783/solve-a-cross-threading-exception-in-winforms
        void AppendToChat(string message)
        {
            //Action to be performed should be called within { } as like below code
            if (this.rt_Chat.InvokeRequired)
                rt_Chat.Invoke(new MethodInvoker(() => { rt_Chat.AppendText(message + Environment.NewLine);}));
        }

        public void ConnectToServer()
        {

            client.Connect(serverIp, port);

            writer = new StreamWriter(client.GetStream());
            reader = new StreamReader(client.GetStream());
            bool userNameIsTaken;
            do
            {
                userNameIsTaken = false;
                writer.Write(userName + "\r\n");
                writer.Flush();


                //If user name is taken.
                if (reader.ReadLine() == "true")
                {
                    MessageBox.Show("User name is taken. Enter a new one.");
                    userNameIsTaken = true;
                }
            } while (userNameIsTaken);
        }

        public void SendMessage(string messsage)
        {
            writer.Write(messsage + "\r\n");

            writer.Flush();
        }

        private void rt_Chat_TextChanged(object sender, EventArgs e)
        {

        }

        private void ts_SetUserName_Click(object sender, EventArgs e)
        {
            enterNameForm.ShowDialog();
            userName = enterNameForm.UserName;
            
            if (!String.IsNullOrEmpty(userName))
            {
                ts_ConnectToServer.Enabled = true;
            }
        }

        private void ts_ConnectToServer_Click(object sender, EventArgs e)
        {
            Thread clientThread = new Thread(new ThreadStart(StartChat));
            clientThread.Start();
        }

        private void ts_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The chat was made by Markus! #MERCYMAINBTW");
        }
    }
}
