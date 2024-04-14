using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab8CSharp
{
    internal class Task3
    {
        private string inputFilePath;
        private string outputFilePath;

        public Task3(string inputFilePath, string outputFilePath)
        {
            this.inputFilePath = inputFilePath;
            this.outputFilePath = outputFilePath;
        }

        public void RemoveWordsWithOddLength()
        {
            try
            {
                // Зчитуємо вміст вхідного файлу
                string inputText = File.ReadAllText(inputFilePath);

                // Розділяємо текст на слова
                string[] words = Regex.Split(inputText, @"\W+");

                // Фільтруємо слова за парністю довжини
                List<string> filteredWords = new List<string>();
                foreach (string word in words)
                {
                    if (word.Length % 2 != 0)
                    {
                        filteredWords.Add(word);
                    }
                }

                // Записуємо фільтровані слова у вихідний файл
                File.WriteAllLines(outputFilePath, filteredWords);

                Console.WriteLine("Слова непарної довжини були вилучені у файл " + outputFilePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Виникла помилка: " + ex.Message);
            }
        }
    }
}
