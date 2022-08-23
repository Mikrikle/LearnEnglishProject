namespace LearnEnglishNotify
{
    partial class FormWordsList
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
            this.button_update = new System.Windows.Forms.Button();
            this.textBox_word = new System.Windows.Forms.TextBox();
            this.listBox_words = new System.Windows.Forms.ListBox();
            this.textBox_translate = new System.Windows.Forms.TextBox();
            this.textBox_find = new System.Windows.Forms.TextBox();
            this.button_saveChanges = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.Location = new System.Drawing.Point(5, 460);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(68, 32);
            this.button_update.TabIndex = 3;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // textBox_word
            // 
            this.textBox_word.Location = new System.Drawing.Point(5, 394);
            this.textBox_word.Name = "textBox_word";
            this.textBox_word.PlaceholderText = "new text";
            this.textBox_word.Size = new System.Drawing.Size(390, 27);
            this.textBox_word.TabIndex = 1;
            // 
            // listBox_words
            // 
            this.listBox_words.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_words.FormattingEnabled = true;
            this.listBox_words.ItemHeight = 20;
            this.listBox_words.Location = new System.Drawing.Point(5, 48);
            this.listBox_words.Name = "listBox_words";
            this.listBox_words.Size = new System.Drawing.Size(390, 340);
            this.listBox_words.TabIndex = 5;
            this.listBox_words.SelectedIndexChanged += new System.EventHandler(this.listBox_words_SelectedIndexChanged);
            // 
            // textBox_translate
            // 
            this.textBox_translate.Location = new System.Drawing.Point(5, 427);
            this.textBox_translate.Name = "textBox_translate";
            this.textBox_translate.PlaceholderText = "new translate";
            this.textBox_translate.Size = new System.Drawing.Size(390, 27);
            this.textBox_translate.TabIndex = 2;
            // 
            // textBox_find
            // 
            this.textBox_find.Location = new System.Drawing.Point(5, 8);
            this.textBox_find.Name = "textBox_find";
            this.textBox_find.PlaceholderText = "find";
            this.textBox_find.Size = new System.Drawing.Size(200, 27);
            this.textBox_find.TabIndex = 0;
            this.textBox_find.TextChanged += new System.EventHandler(this.textBox_find_TextChanged);
            // 
            // button_saveChanges
            // 
            this.button_saveChanges.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_saveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_saveChanges.Location = new System.Drawing.Point(275, 460);
            this.button_saveChanges.Name = "button_saveChanges";
            this.button_saveChanges.Size = new System.Drawing.Size(120, 32);
            this.button_saveChanges.TabIndex = 4;
            this.button_saveChanges.Text = "Save changes";
            this.button_saveChanges.UseVisualStyleBackColor = false;
            this.button_saveChanges.Click += new System.EventHandler(this.button_saveChanges_Click);
            // 
            // FormWordsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.button_saveChanges);
            this.Controls.Add(this.textBox_find);
            this.Controls.Add(this.textBox_translate);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.listBox_words);
            this.Controls.Add(this.textBox_word);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormWordsList";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowInTaskbar = false;
            this.Text = "FormWordsList";
            this.TopMost = true;
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormWordsList_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button_update;
        private TextBox textBox_word;
        private ListBox listBox_words;
        private TextBox textBox_translate;
        private TextBox textBox_find;
        private Button button_saveChanges;
    }
}