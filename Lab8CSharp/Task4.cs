using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8CSharp
{
    internal class Task4
    {
        private string filePath;

        public Task4(string filePath)
        {
            this.filePath = filePath;
        }

        public void WriteWordsToFile(string[] words)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
            {
                foreach (string word in words)
                    writer.Write(word);
            }
        }

        public void ReadWordsByLength(int length)
        {
            using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                while (reader.BaseStream.Position < reader.BaseStream.Length)
                {
                    string word = reader.ReadString();
                    if (word.Length == length)
                        Console.WriteLine(word);

                }
            }
        }
    }
}
