using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Submit_Click(object sender, EventArgs e)
        {
            string message = "";
            if (checkBox_cake.Checked && checkBox_ice.Checked)
            {
                richTextBox_Out.AppendText("I Like All! \n" +
                    "");
            }
            else if (checkBox_ice.Checked)
            {
                richTextBox_Out.AppendText("I Like Ice Cream! \n" +
                    "");
            }
            else if (checkBox_cake.Checked)
            {
                richTextBox_Out.AppendText("I Like Cake! \n" +
                    "");
            }
            else
            {
                richTextBox_Out.AppendText("I Don't Like Either! \n" +
                    "");
            }

        }

        private void Button_Clear_Click(object sender, EventArgs e)
        {
            richTextBox_Out.Clear();
        }
    }
}
