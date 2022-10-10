namespace LearnEnglishNotify
{
    public partial class FormAdd : System.Windows.Forms.Form
    {
        /// <summary>
        /// Occurs when user add new record
        /// </summary>
        public event Action<bool>? OnAdd = null;

        public FormAdd()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Writes word and translate into file
        /// </summary>
        private void Add()
        {
            if (String.IsNullOrWhiteSpace(textBox_translate.Text)
                || String.IsNullOrWhiteSpace(textBox_translate.Text))
            {
                OnAdd?.Invoke(false);
                return;
            }

            FileController.Add($"{textBox_word.Text} - {textBox_translate.Text}");
            textBox_word.Clear();
            textBox_translate.Clear();
            OnAdd?.Invoke(true);
        }

        private void FormAdd_Shown(object sender, EventArgs e)
        {
            textBox_word.Focus();
        }

        private void FormAdd_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                Hide();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void button_words_Click(object sender, EventArgs e)
        {
        }
    }
}