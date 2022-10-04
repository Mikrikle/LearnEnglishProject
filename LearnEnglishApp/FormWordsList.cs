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
    public partial class FormWordsList : Form
    {
        /// <summary>
        /// Occurs when user saved changes
        /// </summary>
        public event Action<bool>? OnSaved = null;
        /// <summary>
        /// Occurs when user modified word
        /// </summary>
        public event Action<bool>? OnModified = null;

        /// <summary>
        /// Position where form will appear after calling Show()
        /// </summary>
        public Point FixLocation { get; set; }
        private List<string> _words = new();

        /// <summary>
        /// Updating the form with words from a file
        /// </summary>
        public void UpdateWords()
        {
            _words = FileController.ReadLines().ToList();
            DisplayWords(_words);
        }

        public FormWordsList()
        {
            InitializeComponent();
        }

        public new void Show()
        {
            base.Show();
            Location = FixLocation;
        }

        /// <summary>
        /// Remove all words from form
        /// </summary>
        private void ClearWords()
        {
            _words.Clear();
            textBox_word.Clear();
            textBox_translate.Clear();
            textBox_find.Clear();
        }

        /// <summary>
        /// Fill in list box element by words
        /// </summary>
        private void DisplayWords(List<string> list)
        {
            int temp = listBox_words.TopIndex;
            listBox_words.Items.Clear();
            foreach (string word in list)
                listBox_words.Items.Add(word);
            if (temp < listBox_words.Items.Count)
                listBox_words.TopIndex = temp;
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            int index = listBox_words.SelectedIndex;
            string? line = listBox_words.SelectedItem?.ToString();
            if (line == null)
            {
                OnModified?.Invoke(false);
                return;
            }
            int realIndex = _words.IndexOf(line);
            _words[realIndex] = $"{textBox_word.Text} - {textBox_translate.Text}";
            DisplayWords(_words);
            OnModified?.Invoke(true);
            listBox_words.SelectedIndex = index;
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            string? line = listBox_words.SelectedItem?.ToString();
            if (line == null)
            {
                OnModified?.Invoke(false);
                return;
            }
            _words.Remove(line);
            DisplayWords(_words);
            OnModified?.Invoke(true);
            textBox_word.Clear();
            textBox_translate.Clear();
        }

        private void textBox_find_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_find.Text))
                DisplayWords(_words);
            else
                DisplayWords(_words.FindAll(s => s.Contains(textBox_find.Text, StringComparison.OrdinalIgnoreCase)));
        }

        private void listBox_words_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? line = listBox_words.SelectedItem?.ToString();
            if (line != null)
            {
                try
                {
                    string[] sline = line.Split(" - ");
                    textBox_word.Text = sline[0];
                    textBox_translate.Text = sline[1];
                }
                catch (Exception)
                {
                    textBox_word.Text = " - ";
                    textBox_translate.Text = " - ";
                }
            }
        }

        private void button_saveChanges_Click(object sender, EventArgs e)
        {
            FileController.Update(_words);
            UpdateWords();
            OnSaved?.Invoke(true);
        }

        private void FormWordsList_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                Hide();

            if (e.Button == MouseButtons.Left)
            {
                listBox_words.SelectedItem = null;
                textBox_word.Clear();
                textBox_translate.Clear();
            }
        }

        private void FormWordsList_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible == true)
            {
                button_window.Show();
                FormBorderStyle = FormBorderStyle.None;
                UpdateWords();
            }
            else
            {
                ClearWords();
            }
        }

        private void button_window_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            ((Button)sender).Hide();
        }

        private void FormWordsList_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}
