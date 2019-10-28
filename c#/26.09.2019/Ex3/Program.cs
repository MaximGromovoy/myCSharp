using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Аргументы функции */
            float a = 1;
            float b = 2;
            float c = 3;
            float x = 4;
            /* Считаем и выводим значние функции */
            Console.WriteLine("F = " + F(a, b, c, x));
            /* Аналогично предыдущему выводу, только функция также умножается на 2 и к результату прибавляется 10 */
            Console.WriteLine("2 * F + 10 = " + (2 * F(a, b, c, x) + 10));
        }

        static float F(float a, float b, float c, float x)
        {
            /* Первый случай: x < 0 и b != 0 */
            if ((x < 0) && (b != 0))
            {
                return a - (x / (10 + b));
            }
            /* Второй случай: x > 0 и b == 0 */
            else if ((x > 0) && (b == 0))
            {
                return (x - a) / (x - c);
            }
            /* Любой другой исход */
            else
            {
                return 3 * x + (2 / c);
            }
        }
    }
}
