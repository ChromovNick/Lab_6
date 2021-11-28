using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку для определения самого длинного слова");
            string sentence = Console.ReadLine();
            sentence = sentence.ToLower();
            string[] stringArray = sentence.Split(new Char[] { ' ', ',', '.', ':', '!', '?', ';' }, StringSplitOptions.RemoveEmptyEntries);
            int max = 0;
            int wordnumber = 0;
            for (int i = 0; i < stringArray.Length; i++)
            {
                if (stringArray[i].Length > max)
                {
                    wordnumber = i;
                    max = stringArray[i].Length;
                }
            }
            Console.WriteLine("Самое длинное слово в строке: {0}", stringArray[wordnumber]);
            Console.ReadKey();

        }
    }
}
