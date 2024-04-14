using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace Lab8CSharp
{
    internal class Task2
    {
        private string inputFilePath;
        private string outputFilePath;

        public Task2(string inputFilePath, string outputFilePath)
        {
            this.inputFilePath = inputFilePath;
            this.outputFilePath = outputFilePath;
        }

        public void FilterWordsByLength(int length)
        {
            try
            {
                // Зчитуємо вміст вхідного файлу
                string inputText = File.ReadAllText(inputFilePath);

                // Розділяємо текст на слова
                string[] words = Regex.Split(inputText, @"\W+");

                // Фільтруємо слова за заданою довжиною
                List<string> filteredWords = new List<string>();
                foreach (string word in words)
                    if (word.Length == length)
                        filteredWords.Add(word);

                // Записуємо фільтровані слова у вихідний файл
                File.WriteAllLines(outputFilePath, filteredWords);

                Console.WriteLine($"Слова довжиною {length} були вилучені у файл {outputFilePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Виникла помилка: " + ex.Message);
            }
        }
    }

}

