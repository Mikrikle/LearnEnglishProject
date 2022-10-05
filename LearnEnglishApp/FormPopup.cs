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
        public FormPopup()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Show pop-up with red color message 
        /// </summary>
        /// <param name="text">message</param>
        /// <param name="parent">Position is set relative to this object</param>
        public void ShowError(string text, Form parent)
        {
            Show(text, Color.Red, parent);
        }

        /// <summary>
        /// Show pop-up with green color message 
        /// </summary>
        /// <param name="text">message</param>
        /// <param name="parent">Position is set relative to this object</param>
        public void ShowSuccess(string text, Form parent)
        {
            Show(text, Color.Green, parent);
        }

        /// <summary>
        /// Show pop-up with message
        /// </summary>
        /// <param name="text">message</param>
        /// <param name="color">text color</param>
        /// <param name="parent">Position is set relative to this object</param>
        private void Show(string text, Color color, Form parent)
        {
            label_text.Text = text;
            label_text.ForeColor = color;
            timer_close.Stop();
            timer_close.Start();
            Show();
            this.Width = parent.Width;
            Point location = new(parent.Location.X, parent.Location.Y - this.Height - 10);
            if(location.Y < 0) 
                location.Y = 0;
            Location = location;
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
