using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_task_5
{
    internal class Program
    {
        /// <summary>
        /// Разделяет строку на слова
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static string[] SplitText(string text)
        {
            int j = 0;
            string[] arrayOfWords = new string[text.Length];
            char[] n = new char[text.Length];
            n = text.ToCharArray();
            for (int i = 0; i < text.Length; i++)
            {
                if (n[i] != ' ') arrayOfWords[j] += n[i].ToString();
                else j++;
            }
            return arrayOfWords;
        }
        /// <summary>
        /// Выводит слова на экран
        /// </summary>
        /// <param name="arrayOfWords"></param>
        static void Print(string[] arrayOfWords)
        {
            Console.WriteLine();
            for (int i = 0; i < arrayOfWords.Length; i++)
            {
                if (arrayOfWords[i] != null) Console.WriteLine(arrayOfWords[i]);
                else break;
            }
        }
        static void Main(string[] args)
        {
            //Задание 1.Метод разделения строки на слова
            Console.Write("Введите предложение: ");
            string text = Console.ReadLine();
            string[] arrayOfWords = SplitText(text);
            Print(arrayOfWords);
            Console.ReadKey();
        }
    }
}
