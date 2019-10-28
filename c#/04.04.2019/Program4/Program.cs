using System;

namespace Program4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Число повторов ввода значений */
            int n = 5;
            /* Итоговая длина в метрах */
            double lenght = 0;

            for (int i = 0; i<n; i++)
            {
                Console.WriteLine("Enter the num of element and length:");
                /* При помощи метода конвертируем введенные еденицы в метры */
                lenght = Measurement_methods.Conversion_to_Meters(
                        int.Parse(Console.ReadLine()),
                        double.Parse(Console.ReadLine()));
                /* Выводим значение */
                Console.WriteLine("Lenght in meters: " + lenght);
            }

        }

        class Measurement_methods
        {
            /* Метод преобразования различных размерностей в метры */
            static public double Conversion_to_Meters(int num_of_element, double _length)
            {
                switch (num_of_element)
                {
                    case 1:
                        Console.WriteLine("(From decimeter)");
                        return _length * 0.1;
                    case 2:
                        Console.WriteLine("(From kilometer)");
                        return _length * 1000;
                    case 3:
                        Console.WriteLine("(From meters)");
                        return _length;
                    case 4:
                        Console.WriteLine("(From millimeter)");
                        return _length * 0.001;
                    case 5:
                        Console.WriteLine("(From centimeter)");
                        return _length * 0.01;
                        /* Случай, если num_of_element не входит в диапазон от 1 до 5 */
                    default:
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("Num_of_ements not in [1;5]!\nNull will be returned");
                        Console.WriteLine("---------------------------");
                        return 0;
                }
            }
        }
    }
}
