using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace LearnEnglishApp
{
    public static class FileController
    {
        public static string DirectoryName { get; set; } = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "LearnEnglishWords");

        public static string FileName { get; set; } = "words.txt";

        public static string FullFileName { get; set; } = Path.Combine(DirectoryName, FileName);

        public static void Write(string text)
        {
            if(!Directory.Exists(DirectoryName))
                Directory.CreateDirectory(DirectoryName);

            using (StreamWriter sw = new StreamWriter(FullFileName, true))
            {
                sw.WriteLine(text);
            }
        }

        public static void OpenWithNotepad()
        {
            if (!File.Exists(FullFileName))
                File.Create(FullFileName).Close();
            Process.Start("notepad.exe", FullFileName);
        }

    }
}
