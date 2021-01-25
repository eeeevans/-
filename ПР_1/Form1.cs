using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_8;

namespace ПР_1
{
    public partial class Form1 : Form
    {
        int max; // Описываем max глобальный эллемент
        public Form1()
        {
            InitializeComponent();
        }

        // Кнопка о программе

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Практическая работа №1\n" +
                "Разработка и оформление алгоритма циклической структуры.\n" +
                "Болдаков Никита Евгеньевич\n" +
                "Группа ИСП-31\n" +
                "Найти максимум из n целых случайных чисел X, распределенных в диапазоне от 0 до n." +
                "Вывести на экран на одной строке сгенерированные числа, на другой строке результат.\n");
        }

        // Кнопка Выход

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Строка Ввода n

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Строка сгенерированые числа

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        // Строка Результат

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        // Кнопка Расчёт

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear(); // Очищаем строку
            int n; // Описываем переменную n как кол-во сгенерированных чисел
            // Проверяем вводимое значение
            bool f1;
            f1 = Int32.TryParse(textBox1.Text, out n);
            if (f1 == true)
            {
                // Вызываем функцию
                Max.InitGen(Convert.ToInt32(textBox1.Text), out max, ref textBox2);
                textBox3.Text = Convert.ToString(max);
            }
        }

        // Кнопка очистить

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Очищаем строки
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
