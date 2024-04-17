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
                string inputText = File.ReadAllText(inputFilePath);

                string[] words = Regex.Split(inputText, @"\W+");

                List<string> filteredWords = new List<string>();
                foreach (string word in words)
                    if (word.Length == length)
                        filteredWords.Add(word);

                File.WriteAllLines(outputFilePath, filteredWords);

                Console.WriteLine($"Words of length {length}  were extracted to the file {outputFilePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }

}

