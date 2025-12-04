using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            string isim = textBox_Add.Text;
            listView.Items.Add(isim);
            textBox_Add.Clear();
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            string isim = textBox_Remove.Text;
            foreach (ListViewItem item in listView.Items)
            {
                if (item.Text == isim)
                {
                    listView.Items.Remove(item);
                    break;
                }
            }
            textBox_Remove.Clear();
        }
    }
}
