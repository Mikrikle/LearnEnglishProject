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
        /// <param name="isHideForm">will the form be hidden after adding an record</param>
        private void Add(bool isHideForm = false)
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
            if(isHideForm) Hide();
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
            Add(e is not MouseEventArgs);
        }

        private void button_words_Click(object sender, EventArgs e)
        {
        }
    }
}