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
        public event Action<bool>? OnSave = null;
        public event Action<bool>? OnUpdate = null;

        private List<string> words = new();
        public Point FixLocation { get; set; }

        private void UpdateWords()
        {
            words = FileController.Read().ToList();
            DisplayWords(words);
        }

        public new void Show()
        {
            base.Show();
            Location = FixLocation;
        }

        private void DisplayWords(List<string> list)
        {
            int temp = listBox_words.TopIndex;
            listBox_words.Items.Clear(); 
            foreach(string word in list)
                listBox_words.Items.Add(word);
            if(temp < listBox_words.Items.Count)
                listBox_words.TopIndex = temp;
        }

        public FormWordsList()
        {
            InitializeComponent();
            UpdateWords();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            string? line = listBox_words.SelectedItem.ToString();
            if (line == null)
            {
                OnUpdate?.Invoke(false);
                return;
            }
            int realIndex = words.IndexOf(line);
            words[realIndex] = $"{textBox_word.Text} - {textBox_translate.Text}";
            DisplayWords(words);
            OnUpdate?.Invoke(true);
        }

        private void textBox_find_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_find.Text))
                DisplayWords(words);
            else
                DisplayWords(words.FindAll(s => s.Contains(textBox_find.Text, StringComparison.OrdinalIgnoreCase)));
        }

        private void listBox_words_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? line = listBox_words.SelectedItem.ToString();
            if(line != null)
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
            FileController.Update(words);
            UpdateWords();
            OnSave?.Invoke(true);
        }

        private void FormWordsList_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                Hide();
        }
    }
}
