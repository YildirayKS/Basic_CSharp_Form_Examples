using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pratik_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float price;
        private void button1_Click(object sender, EventArgs e)
        {
            price_label.Text = price.ToString() + " Dollars";
        }

        private void producs_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (producs_combobox.Text == "Intel Core i7 Processor")
            {
                price = 20;
            }
            else if (producs_combobox.Text == "AMD RX580 Graphics Card")
            {
                price = 35;
            }
            else if (producs_combobox.Text == "8 GB DDR4 Ram")
            {
                price = 5;
            }
        }
    }
}
