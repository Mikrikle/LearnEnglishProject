using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LearnEnglishNotify
{
    public static class FileController
    {
        public static string DirectoryName { get; set; } = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "LearnEnglishWords");

        public static string FileName { get; set; } = "words.txt";

        public static string FullFileName { get; set; } = Path.Combine(DirectoryName, FileName);

        public static void Add(string text)
        {
            if(!Directory.Exists(DirectoryName))
                Directory.CreateDirectory(DirectoryName);

            using (StreamWriter sw = new StreamWriter(FullFileName, true))
            {
                sw.WriteLine(text);
            }
        }
        
        public static IEnumerable<string> Read()
        {
            if (!File.Exists(FullFileName))
                return Array.Empty<string>();
            return File.ReadLines(FullFileName);
        }

        public static void Update(IEnumerable<string> text)
        {
            using (StreamWriter sw = new StreamWriter(FullFileName, false))
            {
                foreach (string line in text)
                    sw.WriteLine(line);
            }               
        }

        public static void Update(string text)
        {
            File.WriteAllText(FullFileName, text);
        }
    }
}
