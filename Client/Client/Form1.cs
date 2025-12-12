using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        bool connected = false;
        bool terminated = true;
        Socket clientSocket;

        public Form1()
        {
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            clientSocket = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
            string IP = textBox_IP.Text;
            int portNum;
            if(Int32.TryParse(textBox_Port.Text, out portNum))
            {
                try
                {
                    clientSocket.Connect(IP, portNum);
                    button_send.Enabled = true;
                    textBox_Message.Enabled = true;
                    button_connect.Enabled = false;
                    connected = true;
                    clientLogs.AppendText("Connected to the server!\n");
                }
                catch
                {
                    clientLogs.AppendText("Could not connect to the server!\n");
                }
            }

            else
            {
                clientLogs.AppendText("Check the port (must integer) \n");
            }

        }

        private void button_send_Click(object sender, EventArgs e)
        {
            string message = textBox_Message.Text;
            if(message != "" && message.Length <=64)
            {
                try
                {
                    Byte[] buffer = Encoding.Default.GetBytes(message);
                    clientSocket.Send(buffer);
                }
                catch
                {
                    clientLogs.AppendText("A mistake happened while trying to send");
                }

            }

        }
        private void Form1_FormClosing(object sender, System.ComponentModel.CancelEventArgs e) 
        {
            connected = false;
            terminated = true;
            Environment.Exit(0);
        }
    }
}
