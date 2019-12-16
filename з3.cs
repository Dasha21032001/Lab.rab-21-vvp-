using System;

namespace з3
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Введите строку:");
                string s = Console.ReadLine();
                char k = (char)s[0];
                char[] s1 = new char[s.Length];
                s1[0] = (char)s[0];
                for (int i = 1; i < s.Length; i++)
                {
                    if ((char)s[i] == k)
                        s1[i] = '.';
                    else
                        s1[i] = (char)s[i];
                }
                Console.WriteLine("Полученная строка:");
                for (int i = 0; i < s.Length; i++)
                    Console.Write(s1[i]);
                Console.ReadLine();
        }
    }
}
