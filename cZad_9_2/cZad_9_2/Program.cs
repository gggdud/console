using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cZad_9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {                
                Console.Write("Введите длину нужной строки: ");
                Task2 t = new Task2(int.Parse(Console.ReadLine()));
                t.F();
                Console.WriteLine($"Считанные строки:\n{t.Show()}");
                Console.WriteLine($"Строки с заданной длиной:\n{t.F()}");
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
    class Task2
    {
        string path = AppDomain.CurrentDomain.BaseDirectory + "\\file.txt";
        string[] strArr;
        int len;
        public Task2(int len)
        {
            this.len = len;
            strArr = File.ReadAllLines(path, Encoding.Default);
        }
        public string F()
        {
            string str = "";
            for (int i = 0; i < strArr.Length; i++)
            {                
                if (strArr[i].Length==len)
                {
                    str += $"{strArr[i]}\n";
                }
            }
            return str != "" ? str:"Строк с заданной длиной нет";
        }
        public string Show()
        {
            return String.Join('\n'.ToString(), strArr);
        }
    }
}
