using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Тест_по_Литературе
{
    public partial class Form7 : Form
    {
        public static double ball7;
        public Form7()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            ball7 = 0;
            if (radioButton2.Checked == true) ball7 += 1;
            if (radioButton4.Checked == true) ball7 += 1;
            if (radioButton7.Checked == true) ball7 += 1;

            Form8 fm8 = new Form8();
            fm8.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 fm6 = new Form6();
            fm6.Show();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
