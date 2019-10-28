using System;

namespace Program10
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMath();
        }

        public static void MyMath()
        {
            int num;
            int n;

            int calc1 = 0;
            int calc2 = 1;
            int calc3 = 0;
            /* Вводим кол-во чисел */
            Console.WriteLine("Enter n:");
            n = int.Parse(Console.ReadLine());

            /* В цикле вводим значения и сразу их проверяем */
            for (int i = 0;i < n; i++)
            {
                /* Вводим число */
                num = int.Parse(Console.ReadLine());

                /* Пункт а) */
                if (((num % 10) == 3) || ((num % 10)== 4))
                {
                    calc1 += num;
                }

                /* Пункт б) */
                if ((num % 5 == 0) && (num % 3 != 0))
                {
                    calc2 *= num;
                }

                /* Пункт в) */
                /* Запоминаем введенное числов в новую переменную */
                int tmp = num;

                /* В цикле доходим до первого символа числа */
                while (tmp/10 != 0)
                {
                    tmp /= 10;
                    Console.WriteLine("Tmp/10 = " + tmp);
                }
                /* Проверяем, равно ли это число еденице */
                if (tmp == 1) calc3++;
                /* Обнуляем значения для повторного ввода */
                num = 0;
                tmp = 0;
            }
            /* Если подходяших чисел для пункта "б)" не было, то произведие будет равно нулю */
            if (calc2 == 1) calc2 = 0;
            /* Вывод результа */
            Console.WriteLine("A) " + calc1);
            Console.WriteLine("B) " + calc2);
            Console.WriteLine("C) " + calc3);
        }
    }
}
