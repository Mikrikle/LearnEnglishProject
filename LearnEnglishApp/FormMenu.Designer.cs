namespace LearnEnglishNotify
{
    partial class FormMenu
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
            this.button_close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_removeDuplicates = new System.Windows.Forms.Button();
            this.textBox_fileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Location = new System.Drawing.Point(727, 9);
            this.button_close.Margin = new System.Windows.Forms.Padding(0);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(64, 32);
            this.button_close.TabIndex = 0;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_removeDuplicates);
            this.panel1.Location = new System.Drawing.Point(491, 44);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(300, 394);
            this.panel1.TabIndex = 1;
            // 
            // button_removeDuplicates
            // 
            this.button_removeDuplicates.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_removeDuplicates.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_removeDuplicates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_removeDuplicates.Location = new System.Drawing.Point(10, 10);
            this.button_removeDuplicates.Name = "button_removeDuplicates";
            this.button_removeDuplicates.Size = new System.Drawing.Size(280, 50);
            this.button_removeDuplicates.TabIndex = 0;
            this.button_removeDuplicates.Text = "Remove duplicates";
            this.button_removeDuplicates.UseVisualStyleBackColor = false;
            this.button_removeDuplicates.Click += new System.EventHandler(this.button_removeDuplicates_Click);
            // 
            // textBox_fileName
            // 
            this.textBox_fileName.Location = new System.Drawing.Point(13, 67);
            this.textBox_fileName.Name = "textBox_fileName";
            this.textBox_fileName.PlaceholderText = "fileName";
            this.textBox_fileName.ReadOnly = true;
            this.textBox_fileName.Size = new System.Drawing.Size(472, 27);
            this.textBox_fileName.TabIndex = 2;
            this.textBox_fileName.Click += new System.EventHandler(this.textBox_fileName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Path to words file";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Menu";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_fileName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenu";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "FormMenu";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_close;
        private Panel panel1;
        private Button button_removeDuplicates;
        private TextBox textBox_fileName;
        private Label label1;
        private Label label2;
    }
}