using System;

namespace Task_1_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, dVal;
            string val;
            try
            {
                Console.Write("Введите число A: ");
                A = Double.Parse(Console.ReadLine());
                Console.Write("Введите двузначное число: ");
                dVal = Double.Parse(Console.ReadLine());
                val = dVal.ToString();
                if (val.Length != 2) 
                {
                    throw new Exception();
                }
                if ((Convert.ToDouble(val[0].ToString()) + Convert.ToDouble(val[1].ToString())) % A == 0)
                {
                    Console.WriteLine($"Сумма цифр числа {dVal} кратна числу {A}");
                } 
                else
                {
                    Console.WriteLine($"Сумма цифр числа {dVal} не кратна числу {A}");
                }
            }
            catch(System.FormatException)
            {
                Console.WriteLine("Введено что-то не то");
            }
            catch(Exception)
            {
                Console.WriteLine("Введено не двузначное число");
            }
        }
    }
}
