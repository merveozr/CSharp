using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            string age;
            String gender;
            string smoker;

            if (radioButton_child.Checked)
            {
                age = "child";
            }
            else if (radioButton_adult.Checked)
            {
                age = "adult";
            }
            else 
            {
                age = "old";
            }



            if (radioButton_female.Checked)
            {
                gender = "female";
            }
            else 
            {
                gender = "mele";
            }



            if (radioButton_smoker.Checked)
            {
                smoker = "smoker";
            }
            else 
            {
                smoker = "non-smoker";
            }

            richTextBox_out.AppendText("This is a/an " + age + " " + gender + " " + smoker  +"\n");
        }
    }
}
