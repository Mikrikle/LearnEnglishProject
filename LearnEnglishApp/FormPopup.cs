using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace LearnEnglishNotify
{
    public partial class FormPopup : Form
    {
        public Point FixLocation { get; set; }

        public FormPopup()
        {
            InitializeComponent();
        }

        public void ShowError(string text)
        {
            Show(text, Color.Red);
        }

        public void ShowSuccess(string text)
        {
            Show(text, Color.Green);
        }

        private void Show(string text, Color color)
        {
            label_text.Text = text;
            label_text.ForeColor = color;
            timer_close.Start();
            Show();
            Location = FixLocation;
        }

        private void FormPopup_MouseClick(object sender, MouseEventArgs e)
        {
            timer_close.Stop();
            Hide();
        }

        private void timer_close_Tick(object sender, EventArgs e)
        {
            timer_close.Stop();
            Hide();
        }
    }
}
