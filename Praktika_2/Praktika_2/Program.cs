using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Введите строку для нахождения f");
                string word = Console.ReadLine();
                string[] words = { };
                int schet = 0;
                for (int i = 0; i < word.Length; i++)
                {
                    words = word.Split('f');
                    if (words.Length == 1)
                    {
                        break;
                    }
                    if (i > 0 && i < 2) schet += words[i].Length;
                }
                if (words.Length == 1) Console.WriteLine("-2");
                if (words.Length == 2) Console.WriteLine("-1");
                if (words.Length > 2) Console.WriteLine(schet + 2);
                Console.Read();
            }

            {
                char[] rus = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
                string[] eng = { "a", "b", "v", "g", "d", "e", "yo", "j", "z", "i", "I", "k", "l", "m", "n", "o", "p", "r", "s", "t", "y", "f", "h", "ce", "che", "sha", "shya", "▬b", "i", "b", "e", "yu", "ya" };
                Console.WriteLine("Введите слово, которое хотите перевести в транслит");
                string translit = "";
                string word = Console.ReadLine();
                for (int i = 0; i < word.Length; i++)
                {
                    for (int C = 0; C < rus.Length; C++)
                    {
                        if (word[i] == rus[C])
                        {
                            translit += eng[C];
                        }
                    }
                }
                Console.WriteLine(translit);
                Console.Read();
            }

            {
                Console.WriteLine("Введите строку");
                string word = Console.ReadLine();
                string[] words = { };
                words = word.Split('h');
                int i;
                for (i = 0; i < words.Length; i++)
                {
                    words = word.Split('h');
                }
                int j = 1;
                while(j< words.Length - 1)
                {
                    if (j != 0 && j != words.Length-2)
                    {
                        words[j] += "H";
                    }
                    j++ ;
                }
                words[0] += "h";
                words[i - 2] += "h";
                string stroka = "";
                for (int g = 0; g < words.Length; g ++)
                {
                    stroka += words[g];
                }
                Console.WriteLine(stroka);
                Console.Read();
            }
        }
    }
}
