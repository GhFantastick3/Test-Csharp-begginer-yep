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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = Form3.ball3;
            double b = Form4.ball4;
            double c = Form5.ball5;
            double d = Form6.ball6;
            double f = Form7.ball7;

            double O = a + b + c + d + f; // Для баллов 
            double A = a + b + c + d + f; // Для оценки

            label3.Text = "ФИО: " + Form1.familia + " " + Form1.ima + " Группа " + Form1.grupa + " \n Ваше количество баллов : " + O.ToString();

             if (A >= 0 && A <= 3) label4.Text = "Ваша оценка: 1".ToString();

             if (A >= 3 && A <= 5) label4.Text = "Ваша оценка: 2".ToString();

             if (A >= 5 && A <= 8) label4.Text = "Ваша оценка: 3".ToString();

             if (A >= 8 && A <= 10) label4.Text = "Ваша оценка: 4".ToString();

             if (A > 10) label4.Text = "Ваша оценка: 5".ToString();
            

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
