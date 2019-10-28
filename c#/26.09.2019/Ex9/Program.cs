using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {

            int m = 5;
            int[,] Array = new int[m, m];

            InputArray(ref Array, m, m);
            /* Переменные, используемые для того, чтобы не изменять элементы на побочной диагонали */
            int m_i = m -1;
            int m_j = m -1;
             

            /* В цикле проходим по всем элементам выше главной диагонали, игнорирую дополнительно самый нижний левый и верхний правый элементы */
            for (int i = 0; i < m_i; i++)
            {
                for (int j = 0; j < m_j; j++)
                {
                    Array[i, j] = 0;
                }
                Console.WriteLine(m_j);
                /* Уменьшаем переменную столбца на единицу для каждой новой строки */
                m_j--;
            }
            

            /* Вывод */
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(Array[i, j] + "|");
                }
                Console.WriteLine();
            }

        }

        /* Ввод матрицы */
        static void InputArray(ref int[,] _Array, int _n, int _m)
        {
            for (int i = 0; i < _m; i++)
            {
                for (int j = 0; j < _n; j++)
                {
                    Console.Write("Input element #" + i + ":" + j + "=");
                    _Array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}
