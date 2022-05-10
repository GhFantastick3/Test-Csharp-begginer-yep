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
    public partial class Form6 : Form
    {
        public static double ball6;
        public Form6()

        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ball6 = 0;
            if (radioButton2.Checked == true) ball6 += 1;

            Form7 fm7 = new Form7();
            fm7.Show();
            this.Hide();
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 fm5 = new Form5();
            fm5.Show();
        }
    }
}
