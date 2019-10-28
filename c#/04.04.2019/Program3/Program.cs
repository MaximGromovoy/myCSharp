using System;

namespace Program3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Объект класса СК */
            Coordinate_system main_system = new Coordinate_system(0, 0);

            /* Число повторов ввода значений */
            int n = 5;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the X and Y coordinates of the point:");
                Console.WriteLine("The value was returned: " + main_system.Check_point(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())));
            }
        }

        class Coordinate_system
        {
            /*
                Класс, которой в качестве объекта создает дек-ю СК.
                x,y - начало СК, можно использовать при работе с глобальной СК.
                Метод Coordinate_system(...) - констуктор класса. В случае отстутсвия аргументов,
                создает СК с началом в координатах (0;0).
                ChangeXY(...) - позволяет сместить СК отностильно "глобальной" СК.
                CheckPoint(...) - проверяет точку в соответствии с заданием.
            */

            protected double x, y;
            public Coordinate_system()
            {
                x = 0;
                y = 0;
            }
            public Coordinate_system(double _x, double _y)
            {
                x = _x;
                y = _y;
            }
            public void ChangeXY(double _x, double _y)
            {
                x = _x;
                y = _y;
            }
            public int Check_point(double _x, double _y)
            {
                if (_x == x && _y == y) return 0;
                if (_x == x) return 1;
                if (_y == y) return 2;
                return 3;
            }
        }
    }
}
