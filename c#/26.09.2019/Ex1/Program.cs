using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* n - размерность массива
               a - первый элемент
               b - второй элемент
               i,k - счетчики
               Array[] - массив
             */
            int n = 10;
            int A = 5;
            int B = 15;

            int k = 0;
            int[] Array = new int[n];

            /* Присваиваем значения A и B */
            Array[0] = A;
            Array[1] = B;
            /* Выводим первые два значения */
            Console.WriteLine("Element #0 = " + Array[0]);
            Console.WriteLine("Element #1 = " + Array[1]);
            /* В цикле проходим по всему массиву */
            for (int i = 2; i < n; i++)
            {
                /* Считаем сумму всех k элементов до i-го элемента */
                while (k < i)
                {
                    Array[i] += Array[k];
                    k++;
                }
                /* Обнуляем k для повтора цикла выше и выводим значение */
                k = 0;
                Console.WriteLine("Element #" + i + " = " + Array[i]);
            }
        }
    }
}
