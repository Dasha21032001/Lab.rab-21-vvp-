using System;

namespace лаб.раб__21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string s = Console.ReadLine();
            int k = 1;
            for (int i = 0; i < s.Length-1; i++)
            {

                if ((s[i] == ' ') && (s[i + 1] != ' '))
                {
                    k++;
                }
            }
            Console.WriteLine("Кол-во слов в строке: " +k);
            Console.ReadLine();
        }
    }
}
