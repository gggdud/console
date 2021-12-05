using System;

namespace Task_3_1_
{
    class Program
    {
        static int f(int x)
        {
            string str = x.ToString();
            if(str.Length==2)
            {
                str = str[1].ToString() + str[0].ToString();
                return Convert.ToInt32(str);
            }
            else
            {
                return x;
            }
        }
        static void Main(string[] args)
        {
            int x;
            try
            {
                Console.Write("Введите х: ");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Итог: {0}", f(x));
            }
            catch(System.FormatException)
            {
                Console.WriteLine("Вы ввели что-то не то");
            }
        }
    }
}
