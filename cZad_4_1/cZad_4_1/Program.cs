using System;

namespace cZad_4_1
{
    class Program
    {
        static double f(double b, double b1, int m, int n)
        {
            if (n == 2)
            {
                return 2;
            }
            if (n == 1)
            {
                return -10;
            }
            if (m==n)
            {
                return (Math.Abs(b) - 6 * b1);
            }
            return f(b1, (Math.Abs(b) - 6 * b1), ++m, n);
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите номер элемента: ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine($"Результат: {f(-10, 2, 3, n)}");
            }
            catch(Exception exc)
            {
                Console.WriteLine(exc.Message);
            }            
        }
    }
}
