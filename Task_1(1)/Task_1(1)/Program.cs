using System;

namespace Task_1_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, x3, y1, y2, y3;
            try 
            {
                Console.Write("Введите x1: ");
                x1 = Double.Parse(Console.ReadLine());
                Console.Write("Введите y1: ");
                y1 = Double.Parse(Console.ReadLine());
                Console.Write("Введите x2: ");
                x2 = Double.Parse(Console.ReadLine());
                Console.Write("Введите y2: ");
                y2 = Double.Parse(Console.ReadLine());
                Console.Write("Введите x3: ");
                x3 = Double.Parse(Console.ReadLine());
                Console.Write("Введите y3: ");
                y3 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Площадь тругольника: {0}", Math.Abs(0.5 * ((x1 - x3) * (y2 - y3) - (x2 - x3) * (y1 - y3))));
            }
            catch(System.FormatException)
            {
                Console.WriteLine("Введено что-то не то");
            }
        }
    }
}
