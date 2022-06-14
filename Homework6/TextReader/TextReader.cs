using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text
{
    class TextReader
    {
        string text;
        string FileName;

        public TextReader(string FileName)
        {
            this.FileName = FileName;
        }
        public void TextOutput()
        {
            Console.WriteLine(text);
        }
        public void TextReadFromFile()
        {
            StreamReader streamReader = new StreamReader(FileName);
            text = streamReader.ReadToEnd();
        }

        public void PrintSentencesToFile()
        {
            string Sentence = text;
            Sentence = Sentence.Replace(". ", ".\r\n");
            Sentence = Sentence.Replace("! ", "!\r\n");
            Sentence = Sentence.Replace("? ", "?\r\n");


            using (StreamWriter writer = new StreamWriter("Result.txt", false, Encoding.Default))
            {
                writer.Write(Sentence);
            }
            
        }
        public void SizeWords()
        {
            string[] Sentences = text.Split(new string[] { ". ", "? ", "! ", ".\r\n", "!\r\n", "?\r\n" }, StringSplitOptions.None);
            foreach (string Sentence in Sentences)
            {
                string[] words = Sentence.Split(new string[] { ", ", ": ", " ", "- ", "\"" }, StringSplitOptions.None);
                int idxmin = 0, idxmax = 0;
                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].Length > words[idxmax].Length)
                    {
                        idxmax = i;
                    }
                    if (words[i].Length < words[idxmin].Length)
                    {
                        words[idxmin] = words[i];
                    }
                } 
                Console.WriteLine("Longest word: " + words[idxmax] + "\t \t Shortest word: " + words[idxmin]);
            }

        }
    }
}
