using System.Diagnostics;

namespace LearnEnglishApp
{
    public partial class Form_Add : System.Windows.Forms.Form
    {
        public Form_Add()
        {
            InitializeComponent();
            SetPosition();
        }

        private void ShowInfo(string text, Color color)
        {
            FormPopup fp = new(text, color);
            fp.ShowPopup();
            fp.Location = new Point(this.Location.X, this.Location.Y - fp.Height - 10);
        }

        private void Form_Add_Shown(object sender, EventArgs e)
        {
            textBox_word.Focus();
        }

        private void Form_Add_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Hide();
        }

        private void Form_Add_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                this.Hide();
        }

        private void SetPosition()
        {
            int boundWidth = Screen.PrimaryScreen.Bounds.Width;
            int boundHeight = Screen.PrimaryScreen.Bounds.Height;
            int x = boundWidth - this.Width;
            int y = boundHeight - this.Height;
            this.Location = new Point(x - 10, y - 50);
        }

        private void notifyIcon_app_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.Visible)
                    this.Hide();
                else
                    this.Show();
            }
            else
            {
                Application.Exit();
            }
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox_translate.Text)
                || String.IsNullOrWhiteSpace(textBox_translate.Text))
            {
                ShowInfo("Empty input", Color.Red);
                return;
            }

            FileController.Write($"{textBox_word.Text} - {textBox_translate.Text}");
            textBox_word.Clear();
            textBox_translate.Clear();
        }

        private void button_words_Click(object sender, EventArgs e)
        {
            FileController.OpenWithNotepad();
        }
    }
}