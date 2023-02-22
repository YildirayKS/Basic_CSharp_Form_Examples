using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pratik_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float price;
        private void processor_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (processor_combobox.Text == "i5")
            {
                price += 10;
            }
            else if (processor_combobox.Text == "Ryzen 3")
            {
                price += 5;
            }
            else if (processor_combobox.Text == "i9")
            {
                price += 20;
            }
        }

        private void ram_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ram_combobox.Text == "8 GB")
            {
                price += 3;
            }
            else if (ram_combobox.Text == "16 GB")
            {
                price += 4;
            }
        }

        private void graphicCard_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (graphicCard_combobox.Text == "RTX 3060 Ti")
            {
                price += 25;
            }
            else if (graphicCard_combobox.Text == "RTX 3070")
            {
                price += 30;
            }
            else if (graphicCard_combobox.Text == "RTX 3090")
            {
                price += 50;
            }
        }

        private void price_button_Click(object sender, EventArgs e)
        {
            price_label.Text = price.ToString() + " Dollars";

            price = 0;
            processor_combobox.Text = null;
            ram_combobox.Text = null;
            graphicCard_combobox.Text = null;
        }
    }
}
