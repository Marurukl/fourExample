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
                int size = 10;
                int startRange = 1, endRange = 10;
                Random rnd = new Random();
                int[] arr = new int[size];
                for (int i = 0; i <= size ; i++)
                {
                    arr[i] = rnd.Next(startRange, endRange);
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
