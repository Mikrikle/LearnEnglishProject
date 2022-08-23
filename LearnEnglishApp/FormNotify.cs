namespace LearnEnglishNotify
{
    public partial class Form_Add : System.Windows.Forms.Form
    {
        private readonly FormWordsList formWordsList = new();
        private readonly FormPopup popup = new();

        public Form_Add()
        {
            InitializeComponent();
            SetPosition();

            popup.FixLocation = new Point(this.Location.X, this.Location.Y - popup.Height - 10);
            formWordsList.FixLocation = new Point(this.Location.X - formWordsList.Width - 10,
                    this.Location.Y + this.Height - formWordsList.Height);

            formWordsList.VisibleChanged += (object? sender, EventArgs e) =>
            {
                if (sender is not FormWordsList f) return;
                if (f.Visible)
                    button_words.Text = "Close";
                else
                    button_words.Text = "Words";
            };

            formWordsList.OnSave += (bool state) => { if (state) popup.ShowSuccess("Saved"); };
            formWordsList.OnUpdate += (bool state) =>
            {
                if (state)
                    popup.ShowSuccess("Updated");
                else
                    popup.ShowError("Select item");
            };

        }

        private void ShowWordsList()
        {
            if (!formWordsList.Visible)
            {
                formWordsList.Show();
            }
        }

        private void Form_Notify_Shown(object sender, EventArgs e)
        {
            textBox_word.Focus();
        }

        private void Form_Notify_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                Hide();
        }

        private void SetPosition()
        {
            int boundWidth = Screen.PrimaryScreen.Bounds.Width;
            int boundHeight = Screen.PrimaryScreen.Bounds.Height;
            int x = boundWidth - Width;
            int y = boundHeight - Height;
            Location = new Point(x - 10, y - 50);
        }

        private void notifyIcon_app_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Visible)
                    Hide();
                else
                    Show();
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
                popup.ShowError("Empty input");
                return;
            }

            FileController.Add($"{textBox_word.Text} - {textBox_translate.Text}");
            textBox_word.Clear();
            textBox_translate.Clear();
        }

        private void button_words_Click(object sender, EventArgs e)
        {
            if (!formWordsList.Visible)
            {
                ShowWordsList();
            }
            else
            {
                formWordsList.Hide();
            }
        }
    }
}