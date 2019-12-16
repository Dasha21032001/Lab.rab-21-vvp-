using System;
using System.Linq;
namespace з6
{
    class Program
    {
        static void Main(string[] args)
        {
            string adress = @"D:\Лаба\скрин\скрин1.jpg";
            string[] mas = adress.Split('\\');
            if (mas.Count() > 1 && mas[1] != "")
            {
                Console.Write(mas[mas.Count() - 1]);
            }
            else
            {
                Console.WriteLine("\\");
            }

            Console.ReadLine();
        }
    }
}
