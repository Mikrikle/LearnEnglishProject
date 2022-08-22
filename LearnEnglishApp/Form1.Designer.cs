namespace LearnEnglishApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon_app = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_translate = new System.Windows.Forms.TextBox();
            this.textBox_word = new System.Windows.Forms.TextBox();
            this.label_word = new System.Windows.Forms.Label();
            this.button_ok = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon_app
            // 
            this.notifyIcon_app.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon_app.Icon")));
            this.notifyIcon_app.Text = "LearnEnglish";
            this.notifyIcon_app.Visible = true;
            this.notifyIcon_app.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_app_MouseClick);
            this.notifyIcon_app.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_app_MouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_translate);
            this.panel1.Controls.Add(this.textBox_word);
            this.panel1.Controls.Add(this.label_word);
            this.panel1.Location = new System.Drawing.Point(14, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 127);
            this.panel1.TabIndex = 0;
            // 
            // textBox_translate
            // 
            this.textBox_translate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_translate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox_translate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox_translate.Location = new System.Drawing.Point(0, 79);
            this.textBox_translate.Multiline = true;
            this.textBox_translate.Name = "textBox_translate";
            this.textBox_translate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_translate.Size = new System.Drawing.Size(252, 48);
            this.textBox_translate.TabIndex = 3;
            // 
            // textBox_word
            // 
            this.textBox_word.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_word.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_word.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox_word.Location = new System.Drawing.Point(0, 20);
            this.textBox_word.Multiline = true;
            this.textBox_word.Name = "textBox_word";
            this.textBox_word.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_word.Size = new System.Drawing.Size(252, 48);
            this.textBox_word.TabIndex = 1;
            // 
            // label_word
            // 
            this.label_word.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_word.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_word.Location = new System.Drawing.Point(0, 0);
            this.label_word.Name = "label_word";
            this.label_word.Size = new System.Drawing.Size(252, 20);
            this.label_word.TabIndex = 0;
            this.label_word.Text = "Add menu";
            this.label_word.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_ok
            // 
            this.button_ok.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ok.Location = new System.Drawing.Point(226, 149);
            this.button_ok.Margin = new System.Windows.Forms.Padding(5);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(40, 32);
            this.button_ok.TabIndex = 1;
            this.button_ok.Text = "Ok";
            this.button_ok.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(280, 200);
            this.ControlBox = false;
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "LearnEnglish";
            this.TopMost = true;
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private NotifyIcon notifyIcon_app;
        private Panel panel1;
        private Label label_word;
        private TextBox textBox_word;
        private TextBox textBox_translate;
        private Button button_ok;
    }
}