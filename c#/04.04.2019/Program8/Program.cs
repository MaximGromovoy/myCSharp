using System;

namespace Program8
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Итоговое значение функции */
            double f = 0;
            /* Вводимые переменные */
            double x = 0;
            double y = 0;
            int n = 0;

            /* Каждое значение вводится на новой строке */
            Console.WriteLine("Enter X,Y,N:");
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());

            /* Расчет и вывод */
            f = Functios.Func1(x, y, n);
            Console.WriteLine("f = " + f);

        }

        class Functios
        {
            static public double Func1(double _x, double _y, int _n)
            {
                double tmp = 0;
                /* Первый случай по заданию */
                if (_n > 10)
                {
                    return ( (5*_x*_y)/(Math.Pow(_n,2)-1) );
                }
                /* Второй случай по заданию */
                else if (_n <= 10)
                {
                    for (int i = 1; i<=_n; i++)
                    {
                        tmp += _x/(Math.Pow(i,2)*_y);
                    }
                    return tmp;
                }
                return 0;
            }
        }
    }
}
