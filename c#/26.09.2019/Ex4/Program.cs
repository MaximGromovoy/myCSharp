using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{

    class Program
    {
        static void Main(string[] args)
        {

            /* Часть первая */
            /* Вводим катеты */
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            /* Вычисляем S и P */
            Triangle(a,b);

            /* Часть вторая */
            /* Вводим кол-во треугольников */
            Console.WriteLine("Input num of triangles: ");
            int n = Convert.ToInt32(Console.ReadLine());
            /* tmp_s, tmp_p - переменные для промежуточных значений
             * max_p - максимальный периметр
             * sum_s - сумма площадей
             * Array[n,2] - двумерный массив, n - число треугольников, [n,0] первый катет, [n,1] - второй
             */
            double tmp_s = 0;
            double tmp_p = 0;
            double max_p = 0;
            double sum_s = 0;

            double[,] Array = new double[n, 2];
            /* Функция заполнения массива */
            InputArray(ref Array, n);

            /* Проходим массив, т.е. перебираем все пары катетов */
            for (int i = 0; i < n; i++)
            {
                /* Считаем площадь и периметр */
                Triangle(Array[i, 0], Array[i, 1], ref tmp_s, ref tmp_p);
                /* Суммируем площадь */
                sum_s += tmp_s;
                /* Проверяем, новый полученный периметр больше предыдущего или нет */
                if (tmp_p > max_p) max_p = tmp_p;
            }
            /* Выводим результаты */
            Console.WriteLine("Num of triangles = " + n);
            Console.WriteLine("Sum S = " + sum_s);
            Console.WriteLine("Max P = " + max_p);

        }
        /* Функция вычисления гипотенузы, периметра и площади треугольника по катетам */
        static void Triangle(double a, double b)
        {

            double c = Math.Sqrt((a * a) + (b * b));
            double S = (a * b) / 2;
            double P = a + b + c;

            Console.WriteLine("c = " + c);
            Console.WriteLine("S = " + S);
            Console.WriteLine("P = " + P);
        }
        
        /* Перегрузка функции выше
         * Дополнительно отправляем переменные S и P, чтобы вернуть значения, которые вычислит функция
         */
        static void Triangle(double a, double b, ref double S, ref double P)
        {

            double c = Math.Sqrt((a * a) + (b * b));
            S = (a * b) / 2;
            P = a + b + c;
            
            /*
            Console.WriteLine("c = " + c);
            Console.WriteLine("S = " + S);
            Console.WriteLine("P = " + P);
            */
            
        }

        /* Функция для заполнения массива числами */
        static void InputArray(ref double [,] _Array, int _n)
        {
            for (int i = 0; i < _n; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("Input element #" + i + ":" + j + " : " );
                    _Array[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
        }
    }
}
