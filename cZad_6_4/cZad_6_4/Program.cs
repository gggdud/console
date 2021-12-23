using System;
namespace cZad_6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите размер массива NxN: ");
                Task4 t = new Task4(int.Parse(Console.ReadLine()));
                Console.WriteLine($"Массив:\n{t.Show()}");
                Console.WriteLine($"Новый массив с номерами: {t.ShowNewArr()}");
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
    class Task4
    {
        int[][] arr;
        int[] newArr;
        public Task4(int N)
        {
            Random r = new Random();
            arr = new int[N][];
            newArr = new int[N];
            for (int i = 0; i < N; i++)
            {

                arr[i] = new int[N];
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = r.Next(-10, 10);
                    //arr[i][j] = 2;
                }
            }
            NewArr();
        }
        public string Show()
        {
            string str = "";
            foreach (int[] i in arr)
            {
                foreach (int a in i)
                {
                    str += a + " ";
                }
                str += '\n';
            }
            return str;
        }
        void NewArr()
        {
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = -1;
                for (int j =arr[i].Length-1; j>=0; j--)
                {
                    if (arr[j][i]%2==0)
                    {
                        newArr[i] = j+1;
                        break;
                    }
                    if (newArr[i]==-1)
                    {
                        throw new Exception("В одном из столбцов не оказалось четного элемента");
                    }
                }
            }
        }
        public string ShowNewArr()
        {
            string str = "";
            foreach (int a in newArr)
            {
                str += a + " ";
            }
            return str;
        }
        
    }
}
    
