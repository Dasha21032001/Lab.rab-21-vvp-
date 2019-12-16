using System;

namespace з4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] s = new char[20] { 'а', 'о', 'и', 'е', 'ё', 'э', 'ы', 'у', 'ю', 'я', 'А', 'О', 'И', 'Е', 'Ё', 'Э', 'Ы', 'У', 'Ю', 'Я' };

            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            int k = 0;
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[j] == str[i]) { k++; }
                }
            }
            Console.WriteLine("кол-во гласных в строке: " +k);
            Console.ReadLine();
        }
    }
}
