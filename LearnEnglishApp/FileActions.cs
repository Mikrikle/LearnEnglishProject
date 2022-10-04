using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEnglishNotify
{
    public static class FileActions
    {
        public static void RemoveDuplicates()
        {
            List<string> lines = FileController.ReadLines().ToList();
            FileController.Update(lines.Distinct());
        }
    }
}
