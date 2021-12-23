using System;

namespace p11
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
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x, y, a, b, n;
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
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }
    }
}
