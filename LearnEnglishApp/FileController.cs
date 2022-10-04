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
        /// <summary>
        /// Occurs when WordsFileName changed
        /// </summary>
        public static event Action<string>? OnFileNameChanged = null;

        private static readonly string _defaultDirectory = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "LearnEnglishWords");

        private static string WordsDirectoryName => Path.GetDirectoryName(WordsFileName) ?? _defaultDirectory;

        private static string? _fileName = null;

        public static string WordsFileName {
            get 
            {
                if (_fileName == null)
                {
                    string? savedName = Properties.Settings.Default["FileName"]?.ToString();
                    if (savedName == null || !Directory.Exists(Path.GetDirectoryName(savedName)))
                        _fileName = Path.Combine(_defaultDirectory, "words.txt");
                    else
                        _fileName = savedName;
                } 
                return _fileName; 
            }
            set 
            { 
                _fileName = value; 
                OnFileNameChanged?.Invoke(value);
                Properties.Settings.Default["FileName"] = value;
                Properties.Settings.Default.Save();
            } 
        }

        /// <summary>
        /// Add a new record to the file
        /// </summary>
        /// <param name="line">string and translation</param>
        public static void Add(string line)
        {
            if(!Directory.Exists(WordsDirectoryName))
                Directory.CreateDirectory(WordsDirectoryName);

            using (StreamWriter sw = new(WordsFileName, true))
            {
                sw.WriteLine(line);
            }
        }
        
        /// <summary>
        /// Read all records from file
        /// </summary>
        public static IEnumerable<string> ReadLines()
        {
            if (!File.Exists(WordsFileName))
                return Array.Empty<string>();
            return File.ReadLines(WordsFileName);
        }

        /// <summary>
        /// Overwrite file with new data
        /// </summary>
        /// <param name="text">new file data</param>
        public static void Update(IEnumerable<string> text)
        {
            using (StreamWriter sw = new(WordsFileName, false))
            {
                foreach (string line in text)
                    sw.WriteLine(line);
            }               
        }

        /// <summary>
        /// Overwrite file with new data
        /// </summary>
        /// <param name="text">new file data</param>
        public static void Update(string text)
        {
            File.WriteAllText(WordsFileName, text);
        }
    }
}
