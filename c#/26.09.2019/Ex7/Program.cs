using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 0;
            int n = 0;

            /* Цикл, который проверяет введенное значение M, которое должно быть кратно двум */
            while ((m <= 0) || (m % 2 != 0))
            {
                Console.WriteLine("M%2 == 0!");
                Console.Write("Input M: ");
                m = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input N: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            /* Array - массив чисел */
            int[,] Array = new int[m, n];
            int sum = 0;
            /* Вводим массив */
            InputArray(ref Array, n, m);

            /*
            * Вывод массива в матричном виде
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write( Array[i,j] + "|" );
                }
                Console.WriteLine();
            }
            */
            /* В цикле изменяем переменную столбца j на два, игнорируя таким образом нечетные столбцы */
            for (int j = 0; j < m; j += 2)
            {
                for (int i = 0; i < n; i++)
                {
                    /* Суммируем значения столбца */
                    sum += Array[i, j];
                }
                /* Выводим сумму столбца */
                Console.WriteLine("sum#" + j + " = " + sum);
                sum = 0;
            }

        }

        /* Функция для ввода массива */
        static void InputArray(ref int[,] _Array, int _n, int _m)
        {
            for (int i = 0; i < _m; i++)
            {
                for (int j = 0; j < _n; j++)
                {
                    Console.Write("Input element #" + i + ":" + j + "=");
                    _Array[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

    }
}
