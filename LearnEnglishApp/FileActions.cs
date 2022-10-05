using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LearnEnglishNotify
{
    public static class FileActions
    {
        public static void RemoveDuplicates()
        {
            List<string> lines = FileController.ReadLines().ToList();
            FileController.Update(lines.Distinct());
        }

        public static void ShowFileInExplorer()
        {
            try
            {
                Process.Start("Explorer.exe", $"/select,\"{FileController.WordsFileName}\"");
            }
            catch (Exception)
            {
                MessageBox.Show("Explorer.exe not found");
            }

        }

        public static void OpenFile()
        {
            try
            {
                Process.Start("Explorer.exe", $"\"{FileController.WordsFileName}\"");
            }
            catch (Exception)
            {
                MessageBox.Show("Explorer.exe not found");
            }

        }

    }
}
