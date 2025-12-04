using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            string id = textBox_ID.Text;
            string password = textBox_Pass.Text;

            if (id == "" || password == "")
            {
                button_Connect.BackColor = Color.Red;
                MessageBox.Show("Please enter both ID and Password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                button_Disconnect.Enabled = true;
                button_Send.Enabled = true;
               textBox_Message.Enabled = true; 
                button_Connect.BackColor = Color.LightGreen;
            }
        }

        private void button_Disconnect_Click(object sender, EventArgs e)
        {
            button_Disconnect.Enabled = false;
            button_Connect.Enabled = true;
            button_Send.Enabled = false;
            textBox_Message.Enabled = false;

            button_Connect.BackColor = SystemColors.Control;
            button_Connect.UseVisualStyleBackColor = true;
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            string id = textBox_ID.Text;
            string message = textBox_Message.Text;

            richTextBox_Out.Text = id + ": " + message + "\n";
            textBox_Message.Clear();
        }
    }
}
