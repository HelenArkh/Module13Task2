using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Module13Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            // читаем весь файл в строку 
            var text = File.ReadAllText(@"C:\Users\alena\Desktop\Text1.txt");
            var characters = text.ToCharArray();
            var noPunctuationText = new string(characters.Where(c => !char.IsPunctuation(c)).ToArray());

            var result = noPunctuationText.Split(" ").GroupBy(x => x).OrderByDescending(x => x.Count())
                .Where(x => !string.IsNullOrWhiteSpace(x.Key))
                .Select(x => x.Key).Take(10).ToList();
            foreach (var r in result)
                Console.WriteLine(r);
        }
    }
}
