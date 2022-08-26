using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnEnglishNotify
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            textBox_fileName.Text = FileController.WordsFileName;
            FileController.OnFileNameChanged += (string name) => { textBox_fileName.Text = name; };
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                base.WndProc(ref m);
                if ((int)m.Result == 0x1)
                    m.Result = (IntPtr)0x2;
                return;
            }

            base.WndProc(ref m);
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox_fileName_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new())
            {
                saveFileDialog.InitialDirectory = Path.GetDirectoryName(FileController.WordsFileName);
                saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileController.WordsFileName = saveFileDialog.FileName;
                }
            }
        }

        private void button_removeDuplicates_Click(object sender, EventArgs e)
        {
            FileController.RemoveDuplicates();
        }
    }
}
