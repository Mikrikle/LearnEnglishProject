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
            NotifyIcon.Text = "LearnEnglishApp";
            NotifyIcon.Icon = new Icon(Path.Combine("icons", "appicon.ico"));
            NotifyIcon.ContextMenuStrip = new();
            NotifyIcon.Visible = true;
        }
    }
}
