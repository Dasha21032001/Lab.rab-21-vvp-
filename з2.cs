using System;

namespace з2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string s = Console.ReadLine();
            int kmin = 9999999;
            int knach = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    if ((knach < kmin) && (s[i - 1] != ' '))
                    {
                        kmin = knach;
                    }
                    knach = 0;
                }
                else
                {
                    knach++;
                }
            }
            Console.WriteLine("Длина самого короткого слова: " + kmin);
            Console.ReadLine();
        }
    }
}
