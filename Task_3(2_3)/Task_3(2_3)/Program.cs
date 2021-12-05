using System;

namespace Task_3_2_3_
{    
    class Program
    {
        static void f(double a, double b, double h)
        {
            for (double x = a; x <= b; x += h)
            {
                if (x<=5)
                {
                    Console.WriteLine($"f({x}) = {x*x+5}");
                }
                else if (x<20)
                {
                    Console.WriteLine($"f({x}) = 0");
                }
                else
                {
                    Console.WriteLine($"f({x}) = 1");
                }
            }
        }
        static void f(double x, out double y)
        {
            if (x <= 5)
            {
                y = x * x + 5;
            }
            else if (x < 20)
            {
                y = 0;
            }
            else
            {
                y = 1;
            }
        }
        static void Main(string[] args)
        {
            double a, b, h;
            try
            {
                Console.Write("Введите a: ");
                a = Double.Parse(Console.ReadLine());
                Console.Write("Введите b: ");
                b = Double.Parse(Console.ReadLine());
                Console.Write("Введите h: ");
                h = Double.Parse(Console.ReadLine());
                f(a, b, h);

                Console.Write("\nЧасть 3\n");
                for (double x = a; x <= b; x += h)
                {
                    double y;
                    f(x, out y);
                    Console.Write("{0} ", y);
                }
            }
            catch(System.FormatException)
            {
                Console.WriteLine("Введено что-то не то");
            }
        }
    }
}
