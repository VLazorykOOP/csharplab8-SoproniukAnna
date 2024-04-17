using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System;
using System.IO;

namespace Lab8CSharp
{
    internal class Task1
    {
        private string inputFilePath;
        private string outputFilePath;

        public Task1(string inputFilePath, string outputFilePath)
        {
            this.inputFilePath = inputFilePath;
            this.outputFilePath = outputFilePath;
        }

        public void ProcessText()
        {
            try
            {
                string inputText = File.ReadAllText(inputFilePath);

                string processedText = ProcessText(inputText);

                File.WriteAllText(outputFilePath, processedText);

                Console.WriteLine("Processing is complete. The results are saved in a file: " + outputFilePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private string ProcessText(string text)
        {
            string pattern = @"\b(?:\d{1,3}\.){3}\d{1,3}\b";

            int count = Regex.Matches(text, pattern).Count;

            string replacedText = Regex.Replace(text, pattern, "REPLACED_IP_ADDRESS");

            replacedText = $"{count} IP adress in text:\n{replacedText}";
            
            return replacedText;
        }

    }

}

