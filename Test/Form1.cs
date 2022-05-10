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
    public partial class Form1 : Form
    {
        public static string ima;
        public static string familia;
        public static string grupa;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ima = textBox1.Text;
            familia = textBox2.Text;
            grupa = comboBox1.Text;



            if (textBox1.Text == "" || textBox2.TextLength == 0 || comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Не всё поля заполнены", "Внимание",MessageBoxButtons.OK,MessageBoxIcon.Error);
                
            }
            else
            {
                MessageBox.Show("Вам " + familia + " " + ima + " предлогается пройти тест из 12 вопросов по Литературе \n Желаю удачно пройти тест","Приветствие"); ;
                Hide();

                Form3 fm3 = new Form3();
                fm3.Show();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }
    }
}
