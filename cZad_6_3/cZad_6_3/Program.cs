using System;
namespace cZad_6_3
{
    class Program
    {
        static void Main(string[] args)
        {
                try
                {
                    Console.Write("Введите размер двумерной матрицы NxN: ");
                    Task3 t = new Task3(int.Parse(Console.ReadLine()));
                    Console.WriteLine($"Матрица:\n{t.Show()}");
                    Console.WriteLine($"Норма: {t.Norm}");
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }
        }
    }
    class Task3
    {
        int[,] arr;
        int norm = 0;
        public Task3(int n)
        {
            Random r = new Random();
            arr = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = r.Next(-20, 20);
                }
            }
            for (int i =0; i<arr.GetLength(0); i++)
            {
                //Console.WriteLine(Max(i));
                norm += Max(i);
            }
        }
        public int Norm
        {
            get
            {
                return norm;
            } 
        }
        
        public string Show()
        {
            string str = "";
            for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < arr.GetUpperBound(1) + 1; j++)
                {
                    str += arr[i, j] + " ";
                }
                str += '\n';
            }
            return str;
        }
        int Max(int n)
        {
            int max = arr[n,0];
            for (int i=1; i<arr.GetLength(1); i++)
            {
                if (arr[n,i]>max)
                {
                    max = arr[n,i];
                }
            }
            return max;
        }
    }
}
