using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Слабое место программы - нули, которые может ввести пользователь в массив Array, т.к. массив Array_tmp изначально ими заполнен */
            /* Вводим количество элементов */
            Console.Write("Input N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            /* Два массива: Array - вводимый пользователем массив, Array_tmp - хранит только различные значения из массива Array */
            int[] Array = new int[n];
            int[] Array_tmp = new int[n];
            /* nums - количиство различных элементов */
            int nums = 0;
            /* логическая переменная для проверки, есть ли уже элемент из Array в Array_tmp */
            bool exist = false;
            /* вводим массив Array */
            InputArray(ref Array, n);

            /* в цикле проходим по всем элементам Array */
            for (int i = 0; i < n; i++)
            {
                /* Сверяем каждый элемент Array со всеми элементами Array[tmp] */
                for (int j = 0; j < n; j++)
                {
                    /* Проверяем, есть ли элемент из Array в Array_tmp */
                    if (Array[i] == Array_tmp[j])
                    {
                        /* Если да, не записываем его в Array_tmp */
                        exist = true;
                    }               
                }
                /* Если элемента из Array нет в Array_tmp, то записываем его */
                if (exist == false)
                {
                    Array_tmp[nums] = Array[i];
                    nums++;
                }
                exist = false;
            }
            /* Выводим количество различных элементов */
            Console.WriteLine("Nums = " + nums);
        }

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
