using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pratik_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float visa_point = Convert.ToInt16(visa_textbox.Text);
            float final_point = Convert.ToInt16(final_textbox.Text);

            float grade;

            grade = (visa_point * 40 / 100) + (final_point * 60 / 100);

            grade_label.Text = grade.ToString() + " Point";
        }
    }
}
