using System;

namespace Program6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Объект класса СК */
            Coordinate_system main_system = new Coordinate_system(0, 0);

            int n = 0;

            /* Ввод количества точек */
            Console.WriteLine("Enter the number of points:");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the X and Y coordinates of the point:");
                Console.WriteLine("The value was returned: " + main_system.Check_point(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())));
            }
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
            /* 
                Возвращает:
                1 - если точка попала в нужную область
                0 - если точка вне области
             */

            /* Правая верхняя четверть СК */
            if ( 
                (
                 (_x <= (10 + x)) && (_x >= (0 + x)) && 
                 (_y <= 10 + y) && (_y >= 0 + y)
                ) && (_y <= (-1 * (_x + x) + (10 + y)))) return 1;
            /* Левая верхняя четверть СК */
            if (
                (_x >= -5 + x) && (_x <= 0 + x) &&
                (_y >= 0 + y) && (_y <= 10 + y)
                ) return 1;
            /* Нижняя часть СК */
            if (
                (
                 (_x <= 10 + x) && (_x >= -10 + x) &&
                 (_y <= 0 + y) && (_y >= -5 + y)
                ) && ( Math.Pow(( Math.Pow((_x - x),2) + Math.Pow((_y - y), 2)),0.5) <= 10)
               ) return 1;

            return 0;
        }
    }

}
