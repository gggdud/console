using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cZad_2_1
{
    class Program
    {
        static string f(double x, double y)
        {
            if ((x < 40 && x > -40) && (y < 40 && y > -40))
            {
                return "Точка находится вне";
            }
            else if (((x == 40 || x == -40) && (y <= 40 && y >= -40)) || ((y == 40 || y == -40) && (x <= 40 && x == -40)))
            {
                return "Точка находится на границе";
            }
            return "Точка находится внутри";
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите х: ");
                double x = Double.Parse(Console.ReadLine());
                Console.Write("Введите y: ");
                double y = Double.Parse(Console.ReadLine());
                Console.WriteLine(f(x, y));
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}