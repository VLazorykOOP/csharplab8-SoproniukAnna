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
                string inputText = File.ReadAllText(inputFilePath);

                string[] words = Regex.Split(inputText, @"\W+");

                List<string> filteredWords = new List<string>();
                foreach (string word in words)
                    if (word.Length % 2 != 0)
                        filteredWords.Add(word);

                File.WriteAllLines(outputFilePath, filteredWords);

                Console.WriteLine("Words of odd length were removed from the file:" + outputFilePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
