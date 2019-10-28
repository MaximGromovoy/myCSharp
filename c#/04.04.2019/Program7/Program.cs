using System;

namespace Program7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            /* Вводим значение n */
            Console.WriteLine("Enter n:");
            n = int.Parse(Console.ReadLine());

            /* Считаем значение функции и выводим его */
            double S = Func(n);
            Console.WriteLine("S = " + S);
        }

        static public double Func(int _n)
        {
            /* sum - суммарное значение всех cos^2(...) */
            double sum = 0;
            /* tmp - предел суммирования для значеия аргумента cos(...) */
            int tmp = 1;
            /* prog - сумма прогрессии в аргументе cos(...) */
            int prog = 0;

            /* Считаем сумму прогрессии */
            for (int j = 0; j < _n; j++)
            {
                /* Считаем сумму аргумента cos(...) */
                for (int i = 1; i <= tmp; i++)
                {
                    prog += i;
                }
                /* Подставляем это значение в член прогрессии */
                sum += Math.Pow(Math.Cos(prog),2);
                tmp++;
                /* обнуляем значение prog для повторного расчета */
                prog = 0;
            }
            /* Подставляем сумму в формулу и возвращаем значение */
            return sum;
        }
    }
}
