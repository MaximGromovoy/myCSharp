using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Задаем n и m */
            int n = 5;
            int m = 5;
            /* массив с числами */
            int[,] Array = new int[m, n];
            /* служебная переменная */
            int tmp = 0;

            
            InputArray(ref Array, n, m);

            /*
             * max - максимальное число
             * min - минимальное число
             * num_max / num_min - номера столбцов с элементами выше
             */
            int max = 0;
            int min = 0;
            int num_max = 0;
            int num_min = 0;

            /* В цикле ищем нужные нам столбцы с мин и макс элементами */
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (Array[i, j] > max)
                    {
                        max = Array[i, j];
                        num_max = j;
                    }
                    if (Array[i, j] < min)
                    {
                        min = Array[i, j];
                        num_min = j;
                    }
                }
            }

            /* Если это разные столбцы, то меняем их местами */
            if (num_max != num_min)
            {
                for (int i = 0; i < m; i++)
                {
                    tmp = Array[i, num_max];
                    Array[i, num_max] = Array[i, num_min];
                    Array[i, num_min] = tmp;
                }
            }
            else
                Console.WriteLine("num_min = num_max!");

            /* Вывод в матричной форме */
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(Array[i, j] + " | ");
                }
                Console.WriteLine();
            }

        }

        /* Заполнение массива */
        static void InputArray(ref int[,] _Array, int _n, int _m)
        {
            for (int i = 0; i < _m; i++)
            {
                for (int j = 0; j < _n; j++)
                {
                    Console.Write("Input element #" + i + ":" + j + "=");
                    _Array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}
