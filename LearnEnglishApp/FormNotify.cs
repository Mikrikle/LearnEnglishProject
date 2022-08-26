namespace LearnEnglishNotify
{
    public partial class Form_Add : System.Windows.Forms.Form
    {
        private readonly FormWordsList _formWordsList = new();
        private readonly FormPopup _popup = new();
        private readonly FormMenu _menu = new FormMenu();

        public Form_Add()
        {
            InitializeComponent();
            SetPosition();

            notifyIcon_app.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip();
            notifyIcon_app.ContextMenuStrip.Items.Add("Open", null, (object? sender, EventArgs e) => { Show(); });
            notifyIcon_app.ContextMenuStrip.Items.Add("Menu", null, (object? sender, EventArgs e) => { _menu.ShowDialog(); });
            notifyIcon_app.ContextMenuStrip.Items.Add("Exit", null, (object? sender, EventArgs e) => { Application.Exit(); });

            _popup.FixLocation = new Point(this.Location.X, this.Location.Y - _popup.Height - 10);
            _formWordsList.FixLocation = new Point(this.Location.X - _formWordsList.Width - 10,
                    this.Location.Y + this.Height - _formWordsList.Height);

            _formWordsList.VisibleChanged += (object? sender, EventArgs e) =>
            {
                if (sender is not FormWordsList f) return;
                if (f.Visible)
                    button_words.Text = "Close";
                else
                    button_words.Text = "Words";
            };

            _formWordsList.OnSave += (bool state) =>
            {
                if (state) 
                    _popup.ShowSuccess("Saved");
            };
            _formWordsList.OnModified += (bool state) =>
            {
                if (state)
                    _popup.ShowSuccess("Successful");
                else
                    _popup.ShowError("Select item");
            };

        }

        private void ShowWordsList()
        {
            if (!_formWordsList.Visible)
            {
                _formWordsList.Show();
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
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox_translate.Text)
                || String.IsNullOrWhiteSpace(textBox_translate.Text))
            {
                _popup.ShowError("Empty input");
                return;
            }

            FileController.Add($"{textBox_word.Text} - {textBox_translate.Text}");
            textBox_word.Clear();
            textBox_translate.Clear();
        }

        private void button_words_Click(object sender, EventArgs e)
        {
            if (!_formWordsList.Visible)
            {
                ShowWordsList();
            }
            else
            {
                _formWordsList.Hide();
            }
        }
    }
}