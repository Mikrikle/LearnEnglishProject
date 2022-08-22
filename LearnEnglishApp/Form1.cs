namespace LearnEnglishApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetPosition();
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
            this.Show();
        }

        private void notifyIcon_app_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Hide();
        }
    }
}