using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b;
            a = Convert.ToDouble(textBox1.Text); // присваиваем переменной a значение введеное пользователем в первом текст боксе
            b = Convert.ToDouble(textBox2.Text); // присваиваем переменной b значение введеное пользователем во втором текст боксе

            switch (comboBox1.Text) // выбор между операциями в comboBox1
            {
                case "+":
                    textBox3.Text = Convert.ToString(a + b); 
                    break;
                case "-": 
                    textBox3.Text = Convert.ToString(a - b);
                    break;
                case "*":
                    textBox3.Text = Convert.ToString(a * b);
                    break;
                case "/":
                    textBox3.Text = Convert.ToString(a / b);
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close(); // закрывает форму при нажатии кнопки "Выход"
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = ""; // очищает текостовые окна
            textBox3.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
