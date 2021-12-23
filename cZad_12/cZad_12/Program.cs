using System;

namespace p12
{
    class Point
    {
        int x, y;

        public Point()
        {
            x = 0;
            y = 0;
        }

        public Point(int a, int b)
        {
            x = a;
            y = b;
        }

        public void pointShow()
        {
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
        }

        public double distance()
        {
            double d = Math.Sqrt(x * x + y * y);
            return d;
        }

        public void vector(int a, int b)
        {
            x = x + a;
            y = y + b;
        }

        public int coordX
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public int coordY
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public int multiply
        {
            set
            {
                x = x * value;
                y = y * value;
            }
        }

        public int this[int i]
        {
            get
            {
                if (i == 0) return x;
                else if (i == 1) return y;
                else throw new Exception("Ошибка");
            }
        }

        public static Point operator ++(Point p)
        {
            p.x = p.x + 1;
            p.y = p.y + 1;

            return p;
        }

        public static Point operator --(Point p)
        {
            p.x = p.x - 1;
            p.y = p.y - 1;

            return p;
        }

        public static bool operator true(Point p)
        {
            if (p.x == p.y) return true;
            else return false;
        }

        public static bool operator false(Point p)
        {
            if (p.x != p.y) return false;
            else return true;
        }

        public static Point operator +(Point p, int n)
        {
            p.x = p.x + n;
            p.y = p.y + n;
            return p;
        }

        public static explicit operator Point(string str)
        {
            string[] buf = str.Split(';');
            if (buf.Length == 2)
            {
                int x1 = int.Parse(buf[0]);
                int y1 = int.Parse(buf[1]);
                Point p = new Point(x1, y1);
                return p;
            }
            else throw new Exception("Неверный формат ввода");
        }

        public static explicit operator string(Point p)
        {
            string str = $"{p.x};{p.y}";
            return str;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x, y, a, b, n, i;
                Console.WriteLine("Координаты точки Р1 нулевые");
                Point p1 = new Point();
                Console.WriteLine("Введите координаты точки Р2:");
                Console.Write("x = ");
                x = int.Parse(Console.ReadLine());
                Console.Write("y = ");
                y = int.Parse(Console.ReadLine());
                Point p2 = new Point(x, y);
                Console.WriteLine("\nP1:");
                p1.pointShow();
                Console.WriteLine("\nP2:");
                p2.pointShow();

                Console.WriteLine("\nДлина от начала координат до P1:");
                Console.WriteLine($"d = {Math.Round(p1.distance(), 2)}");
                Console.WriteLine("\nДлина от начала координат до P2:");
                Console.WriteLine($"d = {Math.Round(p2.distance(), 2)}");

                Console.WriteLine("\nПереместить P2 на вектор v:");
                Console.Write("a = ");
                a = int.Parse(Console.ReadLine());
                Console.Write("b = ");
                b = int.Parse(Console.ReadLine());
                p2.vector(a, b);
                Console.WriteLine("\nP2 перемещена на вектор v:");
                p2.pointShow();

                Console.WriteLine("\nУстановить новые координаты P1:");
                Console.Write("x = ");
                x = int.Parse(Console.ReadLine());
                Console.Write("y = ");
                y = int.Parse(Console.ReadLine());
                p1.coordX = x;
                p1.coordY = y;

                Console.Write("\nУмножить координаты P2 на: ");
                n = int.Parse(Console.ReadLine());
                p2.multiply = n;

                Console.WriteLine($"\nКоординаты P1: {p1.coordX};{p1.coordY}");
                Console.WriteLine($"Координаты P2: {p2.coordX};{p2.coordY}");

                Console.Write("\nВведите индекс P1: ");
                i = int.Parse(Console.ReadLine());
                Console.WriteLine($"Индекс соответствует полю: {p1[i]}");

                Console.WriteLine("\nP1++");
                p1++;
                p1.pointShow();
                Console.WriteLine("\nP2--");
                p2--;
                p2.pointShow();

                if (p1)
                {
                    Console.WriteLine("\nP1: x и y совпадают");
                }
                else
                {
                    Console.WriteLine("\nP1: x и y не совпадают");
                }
                if (p2)
                {
                    Console.WriteLine("P2: x и y совпадают");
                }
                else
                {
                    Console.WriteLine("P2: x и y не совпадают");
                }

                Console.Write("\nУвеличить поля P2 на: ");
                n = int.Parse(Console.ReadLine());
                p2 = p2 + n;
                p2.pointShow();

                Console.WriteLine("\nПреобразование P1 в строку P1str:");
                string str = (string)p1;
                Console.WriteLine(str);
                Console.WriteLine("\nПреобразование P1str в класс P1:");
                p1 = (Point)str;
                p1.pointShow();
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }
    }
}
