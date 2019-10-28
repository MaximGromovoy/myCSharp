using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* n - размерность массива
               [k,l] - интверал чилел, прозведение которых мы считаем
               tmp - результат произведения
               Array[] - массив чисел
             */

            Console.Write("Input K: ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input L(> k): ");
            int l = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input N(> k && > l): ");
            int n = Convert.ToInt32(Console.ReadLine());

            int tmp = 1;

            int[] Array = new int[n];

            /* Заполняем массив числами */
            InputArray(ref Array, n);

            /* В цикле считаем произведение всех элементов от k до l включительно */
            for (int i = k; i <= l; i++)
            {
                tmp *= Array[i];
            }
            Console.WriteLine("Result = " + tmp);
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
