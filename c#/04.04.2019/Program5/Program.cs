using System;

namespace Program5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Число повторов ввода значений */
            int n = 5;
            /* Итоговое значение функции */
            double f = 0;
            /* Вывод числа Пи */
            Console.WriteLine("Pi = " + Math.PI);


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter X:");
                /* При помощи метода вычисляем значение функции */
                f = Functios.Func1(double.Parse(Console.ReadLine()));
                /* Выводим значение функции */
                Console.WriteLine("f = " + f);
            }
        }

        class Functios
        {
            static public double Func1(double _x)
            {
                /* Первый случай по заданию */
                if (_x > (-1 * (Math.PI / 2)) && _x < (Math.PI / 2)) return (Math.Tan(Math.PI * _x));
                /* Второй случай по заданию */
                if (_x <= (-1 * (Math.PI / 2))) return (1 / _x);
                /* Третий случай по заданию */
                if (_x >= (Math.PI / 2)) return (Math.Sqrt(Math.Pow(_x,3) - 1));
                return 0;
            }
        }
    }
}
