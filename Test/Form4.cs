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
    public partial class Form4 : Form
    {
       public static double ball4;
      
        public Form4()

        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 fm3 = new Form3();
            fm3.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            ball4 = 0;
            if (radioButton3.Checked == true) ball4 += 1;
            
            Form5 fm5 = new Form5();
            fm5.Show();
            this.Hide();  
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
