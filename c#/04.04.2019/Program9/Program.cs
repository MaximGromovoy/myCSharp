using System;

namespace Program9
{
    class Program
    {
        static void Main(string[] args)
        {
            /* s - значение фукнции*/
            double s = 0;
            /* Вводим e - точность */
            double e = double.Parse(Console.ReadLine());
            s = Functions.Func1(e);
            Console.WriteLine("Func1 = " + s);
        }

        class Functions
        {
            static public double Func1(double _e)
            {
                double sum = 1;
                double tmp1 = 0;
                double tmp2 = 0;
                int i = 3;

                do
                {
                    tmp1 = Math.Pow((-1), i) * Math.Abs(Math.Cos(i) / Math.Pow(i, 2));
                    tmp2 = Math.Pow((-1), i - 1) * Math.Abs(Math.Cos(i - 1) / Math.Pow(i - 1, 2));
                    i++;
                    sum += tmp1;
                    Console.WriteLine("i = " + i);
                } while ((Math.Abs(tmp1 - tmp2) > _e));

                return sum;
            }
        }
    }
}
