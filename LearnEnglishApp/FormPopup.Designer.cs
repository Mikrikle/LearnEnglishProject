namespace LearnEnglishNotify
{
    partial class FormPopup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_text = new System.Windows.Forms.Label();
            this.timer_close = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label_text
            // 
            this.label_text.BackColor = System.Drawing.Color.Black;
            this.label_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_text.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_text.ForeColor = System.Drawing.Color.Red;
            this.label_text.Location = new System.Drawing.Point(1, 1);
            this.label_text.Name = "label_text";
            this.label_text.Size = new System.Drawing.Size(278, 58);
            this.label_text.TabIndex = 0;
            this.label_text.Text = "label1";
            this.label_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_close
            // 
            this.timer_close.Interval = 1500;
            this.timer_close.Tick += new System.EventHandler(this.timer_close_Tick);
            // 
            // FormPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(280, 60);
            this.Controls.Add(this.label_text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPopup";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.TopMost = true;
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormPopup_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label_text;
        private System.Windows.Forms.Timer timer_close;
    }
}