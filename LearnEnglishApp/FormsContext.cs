using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEnglishNotify
{
    /// <summary>
    /// Main application class
    /// </summary>
    public class FormsContext : ApplicationContext
    {
        /// <summary>
        /// Window with the wordlist
        /// </summary>
        private readonly FormWordsList _formWordsList = new();
        /// <summary>
        /// Information pop-up window
        /// </summary>
        private readonly FormPopup _formPopup = new();
        /// <summary>
        /// Settings and tools window
        /// </summary>
        private readonly FormMenu _formMenu = new();
        /// <summary>
        /// Add words window
        /// </summary>
        private readonly FormAdd _formAdd = new();
        /// <summary>
        /// Notify icon
        /// </summary>
        private readonly FormNotify _formNotify = new();

        /// <summary>
        /// Places forms on the window relative to each other
        /// </summary>
        private void SetFormsPositions()
        {
            _formAdd.Location = new Point(
                Screen.PrimaryScreen.Bounds.Width - _formAdd.Width - 10,
                Screen.PrimaryScreen.Bounds.Height - _formAdd.Height - 50
                );

            _formWordsList.FixLocation = new Point(_formAdd.Location.X - _formWordsList.Width - 10,
                    _formAdd.Location.Y + _formAdd.Height - _formWordsList.Height);
        }

        /// <summary>
        /// Sets all events in the application
        /// </summary>
        private void SetFormsEvents()
        {
            _formAdd.button_words.Click += (object? sender, EventArgs e) =>
            {
                if (!_formWordsList.Visible)
                    _formWordsList.Show();
                else
                    _formWordsList.Hide();
            };
            _formAdd.OnAdd += (bool success) =>
            {
                if (success)
                {
                    _formPopup.ShowSuccess("Added", _formAdd);
                    _formWordsList.UpdateWords();
                }
                else
                {
                    _formPopup.ShowError("Empty input", _formAdd);
                }
            };

            _formWordsList.VisibleChanged += (object? sender, EventArgs e) =>
            {
                if (sender is not FormWordsList f) return;
                _formAdd.button_words.Text = f.Visible ? "Close" : "Words";
            };

            _formWordsList.OnSave += (bool sucsess) =>
            {
                if (sucsess)
                    _formPopup.ShowSuccess("Saved", _formWordsList);
            };
            _formWordsList.OnModify += (bool sucsess) =>
            {
                if (sucsess)
                    _formPopup.ShowSuccess("Successful", _formWordsList);
                else
                    _formPopup.ShowError("Please select item", _formWordsList);
            };
        }

        /// <summary>
        /// Sets the drop-down menu and events for NotifyIcon
        /// </summary>
        private void SetNotifyIcon()
        {
            _formNotify.NotifyIcon.ContextMenuStrip.Items.Add(
                "Show", null, (object? sender, EventArgs e) => { _formAdd.Show(); } );
            _formNotify.NotifyIcon.ContextMenuStrip.Items.Add("Menu", null,
                (object? sender, EventArgs e) => { if (!_formMenu.Visible) _formMenu.ShowDialog(); });
            _formNotify.NotifyIcon.ContextMenuStrip.Items.Add("Exit", null,
                (object? sender, EventArgs e) => { Application.Exit(); });

            _formNotify.NotifyIcon.MouseClick += (object? sender, MouseEventArgs e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    _formAdd.Show();
                }
            };
        }

        public FormsContext()
        {
            SetFormsPositions();
            SetFormsEvents();
            SetNotifyIcon();
            _formAdd.Show();
        }
    }
}
