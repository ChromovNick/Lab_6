using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите слово или строку для проверки на палиндром");
            string sentence = Console.ReadLine();
            sentence = sentence.ToLower();
            string [] stringArray = sentence.Split(new Char[] { ' ', ',', '.', ':', '!', '?', ';' }, StringSplitOptions.RemoveEmptyEntries);
            string joined = string.Join("", stringArray);
            string empty = String.Empty;
            for (int i = joined.Length - 1; i >= 0; i--)
            {
                empty += joined[i];
            }
            Console.WriteLine(joined.Equals(empty) ? "Вы ввели палиндром!" : "Вы ввели не палиндром!");
            Console.ReadKey();
        }
    }
}
