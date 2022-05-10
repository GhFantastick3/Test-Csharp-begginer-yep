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
    public partial class Form3 : Form
    {
        public static double ball3;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            


            ball3 = 0;
            if (radioButton9.Checked == true) ball3 += 1;
            if (radioButton6.Checked == true) ball3 += 1;
            if (radioButton12.Checked == true) ball3 += 1;
            if (radioButton16.Checked == true) ball3 += 1;
            if (checkBox3.Checked == true) ball3 += 0.5;
            if (checkBox5.Checked == true) ball3 += 0.5;

          
            Form4 fm4 = new Form4();
            fm4.Show();
            this.Hide();

            
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
