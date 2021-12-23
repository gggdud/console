using System;
using System.IO;

namespace cZad_9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите число элементов: ");
                Task1 t = new Task1(int.Parse(Console.ReadLine()));
                Console.WriteLine($"Числа:\n{t.Show(1)}\n");
                Console.WriteLine($"Результат:\n{t.Show(2)}\n");
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
    class Task1
    {
        string path = AppDomain.CurrentDomain.BaseDirectory + "\\task1.bin";
        double[] arr, arr2;        
        public Task1(int N)
        {
            Random random = new Random();
            arr = new double[N];
            arr2 = new double[N];
            for (int i=0; i<arr.Length; i++)
            {
                arr[i] = random.Next(-5, 5) + random.NextDouble();
            }
            Write();
            Read();
        }
        void Write()
        {
            using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                foreach (double a in arr)
                {
                    binaryWriter.Write(a);
                }                
                binaryWriter.Close();
            }
        }
        void Read()
        {
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                for (int i=0; i<arr2.Length; i++)
                {
                    arr2[i] = reader.ReadDouble();
                }
                reader.Close();
            }
        }
        public string Show(int i)
        {
            string str = "";
            switch(i)
            {
                case 1:
                    foreach(double a in arr)
                    {
                        str += $"{a} ";
                    }
                    break;
                case 2:
                    foreach (double a in arr2)
                    {
                        if (a>=0)
                        {
                            str += $"{a} ";
                        }                        
                    }
                    break;
            }
            return str!=""?str:"Нет таких чисел";
        }
    }
}
