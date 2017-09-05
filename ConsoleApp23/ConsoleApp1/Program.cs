using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Random rnd = new Random();
                int[] arr = new int[10];
                for (int i = 0; i < 11 ; i++)
                {
                    arr[i] = rnd.Next(1, 10);
                    Console.WriteLine(arr[i]);
                }
            }
            catch (System.IndexOutOfRangeException)
            {
                Console.WriteLine("Завершение работы массива");
                Console.ReadLine();
            }
        }
    }
}
