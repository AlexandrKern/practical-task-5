using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_task_5._1
{
    internal class Program
    {
        /// <summary>
        /// Меняет слова местами в обратной последовательности. 
        /// </summary>
        /// <param name="inputPhrase"></param>
        static void ReversWords(string inputPhrase)
        {
            string[] revers = SplitText(inputPhrase);
            Console.WriteLine();
            for (int i = revers.Length - 1; i >= 0; i--)
            {
                Console.Write($"{revers[i]} ");
            }
        }
        /// <summary>
        /// Разделяет строку на слова
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static string[] SplitText(string text)
        {
            string[] arrayOfWords = text.Split();
            Console.WriteLine();
            for (int i = 0; i < arrayOfWords.Length; i++)
            {
                Console.WriteLine(arrayOfWords[i]);
            }
            return arrayOfWords;
        }
        static void Main(string[] args)
        {
            //Задание 2.Перестановка слов в предложении
            Console.Write("Введите предложение: ");
            string inputPhrase = Console.ReadLine();
            ReversWords(inputPhrase);
            Console.ReadKey();
        }
    }
}
