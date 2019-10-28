using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * m и n - целые положительные числа
             * Array - вводимый массив с числами
             * Array_tmp - требуемая матрица
             */
            int m = 4;
            int n = 3;
            int[] Array = new int[n];
            int[,] Array_tmp = new int[m, n];
            /* Вводим массив */
            InputArray(ref Array, n);

            for (int i = 0; i < m; i++)
            {
                Console.Write(i + "::");
                /* Построчно переписываем значения из Array в Array_tmp */
                for (int j = 0; j < n; j++)
                {
                    Array_tmp[i, j] = Array[j];
                    Console.Write(Array_tmp[i, j]);
                }
                Console.WriteLine();
            }

        }

        /* Функция для заполнения массива числами */
        static void InputArray(ref int[] _Array, int _n)
        {
            for (int i = 0; i < _n; i++)
            {

                Console.Write("Input element #" + i + " : ");
                _Array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
