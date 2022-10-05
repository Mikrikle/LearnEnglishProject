namespace LearnEnglishNotify
{
    public partial class Form_Add : System.Windows.Forms.Form
    {
        /// <summary>
        /// Window with the wordlist
        /// </summary>
        private readonly FormWordsList _formWordsList = new();
        /// <summary>
        /// Information pop-up window
        /// </summary>
        private readonly FormPopup _popup = new();
        /// <summary>
        /// Settings and tools window
        /// </summary>
        private readonly FormMenu _menu = new FormMenu();

        public Form_Add()
        {
            InitializeComponent();
            SetPosition();

            // create context menu
            notifyIcon_app.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip();
            notifyIcon_app.ContextMenuStrip.Items.Add("Open", null,
                (object? sender, EventArgs e) => { Show(); });
            notifyIcon_app.ContextMenuStrip.Items.Add("Menu", null,
                (object? sender, EventArgs e) => { if (!_menu.Visible) _menu.ShowDialog(); });
            notifyIcon_app.ContextMenuStrip.Items.Add("Exit", null,
                (object? sender, EventArgs e) => { Application.Exit(); });

            // setting position relative to this form
            _formWordsList.FixLocation = new Point(this.Location.X - _formWordsList.Width - 10,
                    this.Location.Y + this.Height - _formWordsList.Height);

            // setting events
            _formWordsList.VisibleChanged += (object? sender, EventArgs e) =>
            {
                if (sender is not FormWordsList f) return;
                button_words.Text = f.Visible ? "Close" : "Words";
            };

            _formWordsList.OnSaved += (bool sucsess) =>
            {
                if (sucsess)
                    _popup.ShowSuccess("Saved", _formWordsList);
            };
            _formWordsList.OnModified += (bool sucsess) =>
            {
                if (sucsess)
                    _popup.ShowSuccess("Successful", _formWordsList);
                else
                    _popup.ShowError("Please select item", _formWordsList);
            };

        }

        /// <summary>
        /// Writes word and translate into file
        /// </summary>
        private void Add()
        {
            if (String.IsNullOrWhiteSpace(textBox_translate.Text)
                || String.IsNullOrWhiteSpace(textBox_translate.Text))
            {
                _popup.ShowError("Empty input", this);
                return;
            }

            FileController.Add($"{textBox_word.Text} - {textBox_translate.Text}");
            textBox_word.Clear();
            textBox_translate.Clear();
            _popup.ShowSuccess("Added", this);
            _formWordsList.UpdateWords();
        }

        /// <summary>
        /// Places the form in the lower right corner
        /// </summary>
        private void SetPosition()
        {
            int boundWidth = Screen.PrimaryScreen.Bounds.Width;
            int boundHeight = Screen.PrimaryScreen.Bounds.Height;
            int x = boundWidth - Width;
            int y = boundHeight - Height;
            Location = new Point(x - 10, y - 50);
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
            Add();
        }

        private void button_words_Click(object sender, EventArgs e)
        {
            if (!_formWordsList.Visible)
                _formWordsList.Show();
            else
                _formWordsList.Hide();
        }
    }
}