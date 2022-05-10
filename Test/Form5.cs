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
    public partial class Form5 : Form
    {
        public static double ball5;
        public Form5()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 fm4 = new Form4();
            fm4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ball5 = 0;

            if (comboBox1.SelectedIndex == 1) ball5 += 1;
            if (comboBox2.SelectedIndex == 1) ball5 += 1;

            Form6 fm6 = new Form6();
            fm6.Show();
            this.Hide();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
