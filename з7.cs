using System;

namespace з7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string s = Console.ReadLine();
            char[] chet = new char[s.Length];
            char[] nechet = new char[s.Length];
            char[] A = new char[s.Length];
            int i1 = 0, i2 = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 == 0)
                { chet[i1++] = (char)s[i]; }
                else
                { nechet[i2++] = (char)s[i]; }
            }
            int k = 0, j = i2;
            for (int i = 0; i < s.Length; i++)
            {
                if (i < i1)
                { A[i] = nechet[k++]; }
                else
                { A[i] = chet[--j]; }
            }
            if (s.Length % 2 != 0)
            {
                A[s.Length / 2] = chet[i2];
            }
            Console.WriteLine("Изменённая строка: ");
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(A[i] + " " );
            }
            Console.ReadLine();
        }
    }
}