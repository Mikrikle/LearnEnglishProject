using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnEnglishApp
{
    public partial class FormPopup : Form
    {
        public static bool IsShown = false;

        public FormPopup(string text, Color color)
        {   
            InitializeComponent();
            label_text.Text = text;
            label_text.ForeColor = color;
            timer_close.Start();
        }

        public void ShowPopup()
        {
            if (!IsShown)
            {
                IsShown = true;
                Show();
            }
        }

        private void FormPopup_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void timer_close_Tick(object sender, EventArgs e)
        {
            Close();
        }

        private void FormPopup_FormClosed(object sender, FormClosedEventArgs e)
        {
            IsShown = false;
        }
    }
}
