using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Вводим строку */            
            string str = Console.ReadLine();
            /* i - счетчик символов */
            int i = 0;

            /* В цикле проходим по каждому символу */
            while(i < str.Length)
            {
                /* Если символ - пробел, то удаляем его и проходим строку заново, чтобы не пропустить двойные и более пробелы */
                if (str[i] == ' ')
                {
                    str = str.Remove(i,1);
                    i = 0;
                }
                i++;
            }
            /* Выводим строку */
            Console.WriteLine("Str = " + str);
        }
    }
}
