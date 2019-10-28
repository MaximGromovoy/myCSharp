using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex11
{
    class Program
    {

        class Shape
        {
            /* Имя */
            private string name;
            /* Радиус */
            private double r;
            /* Высота */
            private double h;
            /* Площадь полной поверхности */
            private double s;
            /* Объем */
            private double v;
            /* Первый конструктор */
            public Shape(string _name, double _r, double _h)
            {
                this.name = _name;
                this.r = _r;
                this.h = _h;
                this.s = 0;
                this.v = 0;
            }
            /* Второй конструктор */
            public Shape()
            {
                this.name = "Shape";
                this.r = 0;
                this.h = 0;
                this.s = 0;
                this.v = 0;
            }
            /* Консольный ввод */
            public void Input()
            {
                Console.Write("Name = ");
                this.name = Console.ReadLine();
                Console.Write("R = ");
                this.r = Convert.ToDouble(Console.ReadLine());
                Console.Write("H = ");
                this.h = Convert.ToDouble(Console.ReadLine());
            }
            /* Консольный вывод */
            public void Out()
            {
                Console.WriteLine("Name = " + this.name);
                Console.WriteLine("R = " + this.r);
                Console.WriteLine("H = " + this.h);
                Console.WriteLine("S = " + this.s);
                Console.WriteLine("V = " + this.v);
            }
            /* Расчет площади полной поверхности*/
            public void Square()
            {
                this.s = 3.14 * r *(r + Math.Sqrt(r * r + h * h));
                Console.WriteLine("S = " + s);
            }
            /* Расчет объема */
            public void Volume()
            {
                this.v = (3.14 * r * r * h)/3;
                Console.WriteLine("V = " + v);
            }
            /* Функции для возврата значений в целях безопасного использования данных программы */
            public string Name()
            {
                return this.name;
            }
            public double R()
            {
                return this.r;
            }
            public double H()
            {
                return this.h;
            }
            public double S()
            {
                return this.s;
            }
            public double V()
            {
                return this.v;
            }
            /* Функции для ввода значений */
            public void Name_input(string _name)
            {
                this.name = _name;
            }
            public void R_input(double _r)
            {
                this.r = _r;
            }
            public void H_input(double _h)
            {
                this.h = _h;
            }
        }

        static void Main(string[] args)
        {
            /* Часть 1 */
            Console.WriteLine("Ex1:");
            Shape One = new Shape();
            One.Input();
            One.Square();
            One.Volume();
            
            /* Часть 2 */
            Console.WriteLine("Ex2:");
            Shape sh_1 = new Shape();
            Shape sh_2 = new Shape();

            Console.WriteLine("Input shape1:");
            sh_1.Input();
            sh_1.Square();
            sh_1.Volume();

            Console.WriteLine("Input shape2:");
            sh_2.Input();
            sh_2.Square();
            sh_2.Volume();

            /* Наибольший объем */
            if (sh_1.V() > sh_2.V()) Console.WriteLine("Volume of shape1 > shape2 (V =" + sh_1.V() + ")");
            else if (sh_1.V() < sh_2.V()) Console.WriteLine("Volume of shape2 > shape1 (V =" + sh_2.V() + ")");
            else Console.WriteLine("Volume of shape1 = shape2 (V =" + sh_1.V() + ")");
            /* Какая из площадей ближе к 100 */
            if ((Math.Abs(sh_1.S()) - 100) > (Math.Abs(sh_2.S()) - 100)) Console.WriteLine("Square of shape2 closer to 100");
            else if ((Math.Abs(sh_1.S()) - 100) < (Math.Abs(sh_2.S()) - 100)) Console.WriteLine("Square of shape1 closer to 100"); 
            else Console.WriteLine("Square of shape1 = shape2");

            /* Часть 3 */
            Console.WriteLine("Ex3:");
            Shape shp_1 = new Shape("1",1,1);
            Shape shp_2 = new Shape("2",2,2);
            Shape shp_3 = new Shape("3",3,3);
            Shape shp_4 = new Shape("4",4,4);
            Shape shp_5 = new Shape("5",5,5);

            Console.WriteLine("Shape1:");
            shp_1.Square();
            shp_1.Volume();
            Console.WriteLine("Shape2:");
            shp_2.Square();
            shp_2.Volume();
            Console.WriteLine("Shape3:");
            shp_3.Square();
            shp_3.Volume();
            Console.WriteLine("Shape4:");
            shp_4.Square();
            shp_4.Volume();
            Console.WriteLine("Shape5:");
            shp_5.Square();
            shp_5.Volume();
            /* Минимальный объем */
            if ((shp_1.V() < shp_2.V()) && (shp_1.V() < shp_3.V()) && (shp_1.V() < shp_4.V()) && (shp_1.V() < shp_5.V())) Console.WriteLine("Min V is shape1 = " + shp_1.V());
            if ((shp_2.V() < shp_1.V()) && (shp_2.V() < shp_3.V()) && (shp_2.V() < shp_4.V()) && (shp_2.V() < shp_5.V())) Console.WriteLine("Min V is shape2 = " + shp_2.V());
            if ((shp_3.V() < shp_1.V()) && (shp_3.V() < shp_2.V()) && (shp_3.V() < shp_4.V()) && (shp_3.V() < shp_5.V())) Console.WriteLine("Min V is shape3 = " + shp_3.V());
            if ((shp_4.V() < shp_1.V()) && (shp_4.V() < shp_2.V()) && (shp_4.V() < shp_3.V()) && (shp_4.V() < shp_5.V())) Console.WriteLine("Min V is shape4 = " + shp_4.V());
            if ((shp_5.V() < shp_1.V()) && (shp_5.V() < shp_2.V()) && (shp_5.V() < shp_3.V()) && (shp_5.V() < shp_4.V())) Console.WriteLine("Min V is shape5 = " + shp_5.V());
            /* Сумма объемов */
            Console.WriteLine("Sum of V shapes = " + (shp_1.V() + shp_2.V() + shp_3.V() + shp_4.V() + shp_5.V()));
            /* Ср. ариф. площадей */
            Console.WriteLine("Sum of S shapes / 5 = " + ((shp_1.S() + shp_2.S() + shp_3.S() + shp_4.S() + shp_5.S())/5));

            /* Часть 4 */
            /* Выбор ввода */
            /* 1 - ввод с консоли
             * 2 - ввод из файла
             */
            Console.WriteLine("Select:");
            Console.WriteLine("1 - console");
            Console.WriteLine("2 - file");
            int tmp = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            /* Массив из элементов класса */
            Shape[] Shapes = new Shape[n];
            /* Счетчики */
            int h = 0;
            int k = 0;

            if (tmp == 1)
            {
                /* Ввод с консоли */
                for (int i = 0; i < n; i++)
                {
                    Shapes[i] = new Shape();
                    Shapes[i].Input();
                }
            }
            if (tmp == 2)
            {
                /* Число n должно быть равно кол-ву конусов в файле */
                k = 0;
                h = 0;
                /* Имя файла на чтение */
                string file = "Shapes.txt";
                /* Поочередно считываем данные из файла в наш массив элементов */
                using (StreamReader sr = new StreamReader(file, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (k == 0)
                        {
                            Shapes[h] = new Shape();
                            Shapes[h].Name_input(line);
                        }
                        if (k == 1)
                        {
                            Shapes[h].R_input(Convert.ToDouble(line));
                        }
                        if (k == 2)
                        {
                            Shapes[h].H_input(Convert.ToDouble(line));
                            h++;
                        }

                        if (k < 2) k++;
                        else k = 0;
                    }
                }
                /* Считаем площадь и объем */
                for (int i = 0; i < n; i++)
                {
                    Shapes[i].Square();
                    Shapes[i].Volume();
                }
            }
            /* Вывод информации по всем конусам */
            Console.WriteLine("All shapes:");
            for (int i = 0; i < n; i++)
            {
                Shapes[i].Out();
            }
            
                h = 0;
                k = 0;
            /* Имя файла на запись */
                string file_to_write = "Result.txt";
            /* Открываем файл на запись и вводим поочередно данные о наших конусах и полученных результатах задания */
            using (StreamWriter sw = new StreamWriter(file_to_write, false, System.Text.Encoding.Default))
            {
                while (h < n)
                {
                    if (k == 0)
                    {
                        sw.WriteLine(Shapes[h].Name());
                    }
                    if (k == 1)
                    {
                        sw.WriteLine(Shapes[h].R());
                    }
                    if (k == 2)
                    {
                        sw.WriteLine(Shapes[h].H());
                    }
                    if (k == 4)
                    {
                        sw.WriteLine(Shapes[h].S());
                    }
                    if (k == 5)
                    {
                        sw.WriteLine(Shapes[h].V());
                        h++;
                    }

                    if (k < 5) k++;
                    else k = 0;
                }
                /* min - минимальная площадь
                 * str_min - короткая надпись
                 * i_min - номер конуса с мин. площ.
                 * i_str_min - аналогично с короткой надписью
                 */

                double min = Shapes[0].S();
                int str_min = Shapes[0].Name().Length;
                int i_min = 0;
                int i_str_min = 0;
                /* Поиск конусов м мин. площадью и самой короткой надписью */
                for (int i = 0; i < n; i++)
                {
                    if (Shapes[i].S() < min)
                    {
                        min = Shapes[i].S();
                        i_min = i;
                    }
                    if (Shapes[i].Name().Length < str_min)
                    {
                        str_min = Shapes[i].Name().Length;
                        i_str_min = i;
                    }
                }
                /* Вывод найденных выше конусов */
                Console.WriteLine("Min S is " + Shapes[i_min].Name() + " = " + Shapes[i_min].S());
                Console.WriteLine("Min Name is " + Shapes[i_str_min].Name());
                sw.WriteLine("Min S is " + Shapes[i_min].Name() + " = " + Shapes[i_min].S());
                sw.WriteLine("Min Name is " + Shapes[i_str_min].Name());
                /* Поиск и вывод конусов с площадью < 15 */
                for (int i = 0; i < n; i++)
                {
                    if (Shapes[i].S() < 15)
                    {
                        Console.WriteLine("S of " + Shapes[i].Name() + " < 15 and = " + Shapes[i].S());
                        sw.WriteLine("S of " + Shapes[i].Name() + " < 15 and = " + Shapes[i].S());
                    }
                }
            }
            
        }
    }
}
