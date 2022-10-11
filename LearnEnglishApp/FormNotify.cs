using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnEnglishNotify
{
    public partial class FormNotify : Form
    {
        /// <summary>
        /// Get NotifyIcon
        /// </summary>
        public NotifyIcon NotifyIcon { get; private set; } = new();

        public FormNotify()
        {
            SetIcon();
            NotifyIcon.Text = "LearnEnglishApp";
            NotifyIcon.ContextMenuStrip = new();
            NotifyIcon.Visible = true;
        }

        /// <summary>
        /// Check the existence .ico and set it or warning
        /// </summary>
        private void SetIcon()
        {
            string iconPath = Path.Combine("icons", "appicon.ico");
            if (File.Exists(iconPath))
            {
                NotifyIcon.Icon = new Icon(iconPath);
            }
            else
            {
                NotifyIcon.Icon = new Icon(SystemIcons.Exclamation, 40, 40);
                MessageBox.Show($"Warning: {iconPath} not found.", "Warning");
            }
        }
    }
}
