using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pratik_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            values_listbox.Items.Add("Name: " + name_textbox.Text + " / " + " Surname: " + surname_textbox.Text + " / " + " Phone Number: " + phonenumber_maskedbox.Text);

            name_textbox.Clear();
            surname_textbox.Clear();
            phonenumber_maskedbox.Clear();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            values_listbox.Items.Clear();
            name_textbox.Clear();
            surname_textbox.Clear();
            phonenumber_maskedbox.Clear();
        }
    }
}
