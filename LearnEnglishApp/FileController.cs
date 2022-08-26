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
        public static event Action<string>? OnFileNameChanged = null;

        private static readonly string _defaultDirectory = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "LearnEnglishWords");

        private static string WordsDirectoryName => Path.GetDirectoryName(WordsFileName) ?? _defaultDirectory;

        private static string _fileName = Path.Combine(_defaultDirectory,
            "words.txt");
        public static string WordsFileName {
            get { return _fileName; }
            set { _fileName = value; OnFileNameChanged?.Invoke(value); } 
        } 

        public static void Add(string line)
        {
            if(!Directory.Exists(WordsDirectoryName))
                Directory.CreateDirectory(WordsDirectoryName);

            using (StreamWriter sw = new(WordsFileName, true))
            {
                sw.WriteLine(line);
            }
        }
        
        public static IEnumerable<string> ReadLines()
        {
            if (!File.Exists(WordsFileName))
                return Array.Empty<string>();
            return File.ReadLines(WordsFileName);
        }

        public static void Update(IEnumerable<string> text)
        {
            using (StreamWriter sw = new(WordsFileName, false))
            {
                foreach (string line in text)
                    sw.WriteLine(line);
            }               
        }

        public static void Update(string text)
        {
            File.WriteAllText(WordsFileName, text);
        }

        public static void RemoveDuplicates()
        {
            List<string> lines = ReadLines().ToList();
            Update(lines.Distinct());
        }
    }
}
