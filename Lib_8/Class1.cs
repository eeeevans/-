using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // Использеум библиотеку для использования эл-ов textbox

// Создаём библиотеку

namespace Lib_8
{
    // Создаём класс Max
    public class Max
    {
        
        // Функция по нахождению максимального числа среди сгенерированных чисел
        // n - число случайнвх чисел
        // Выходная переменная max - максимальное число среди сгенерированных
        // Входные-выходные переменные TextBox textbox-ты для ввода и вывода значений

        public static int InitGen(int n, out int max, ref TextBox textbox2)
        {
            Random rnd = new Random(); // Иницируем рандомайзер
            int i, zn; // Описываем счетчик цикла и случайное число
            max = -1; // Описываем переменную для нахождения максимального числа
            // Описываем цикл
            for (i = 0; i < n; i++)
            {
                // Генерируем числа
                zn = rnd.Next(0, 500);
                textbox2.Text += zn + " ";
                // Находим максимальное число из сгенерированных
                if (max <= zn) max = zn;
            }
            // Выводим максимальное число из сгенерированных
            return max; // Возвращаем max
        }

        // Изменено - здесь используются большие числа
    }

}