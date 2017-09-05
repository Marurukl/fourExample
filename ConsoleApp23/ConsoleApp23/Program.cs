using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                  WebClient webClient = new WebClient();
                  webClient.OpenRead(@"http://www.professoweb.ru/");

            }
            catch (System.Net.WebException)
            {
                Console.WriteLine("Введено не правльная ссылка !");
            }
            Console.ReadLine();
        }
    }
}
