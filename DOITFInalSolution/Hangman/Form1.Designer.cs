namespace Hangman
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
            window = new TextBox();
            character = new TextBox();
            wordBtn = new Button();
            wordBox = new TextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // window
            // 
            window.BackColor = Color.Azure;
            window.BorderStyle = BorderStyle.None;
            window.Enabled = false;
            window.Font = new Font("Segoe UI", 10F);
            window.ForeColor = SystemColors.InfoText;
            window.Location = new Point(-2, -3);
            window.Multiline = true;
            window.Name = "window";
            window.ReadOnly = true;
            window.Size = new Size(390, 341);
            window.TabIndex = 0;
            window.TextAlign = HorizontalAlignment.Center;
            // 
            // character
            // 
            character.BackColor = SystemColors.Control;
            character.BorderStyle = BorderStyle.None;
            character.Location = new Point(424, 221);
            character.Name = "character";
            character.Size = new Size(150, 24);
            character.TabIndex = 1;
            character.TextAlign = HorizontalAlignment.Center;
            // 
            // wordBtn
            // 
            wordBtn.BackColor = Color.FromArgb(192, 255, 192);
            wordBtn.Location = new Point(443, 258);
            wordBtn.Name = "wordBtn";
            wordBtn.Size = new Size(111, 34);
            wordBtn.TabIndex = 2;
            wordBtn.Text = "Submit";
            wordBtn.UseVisualStyleBackColor = false;
            wordBtn.Click += wordBtn_Click;
            // 
            // wordBox
            // 
            wordBox.BackColor = Color.Azure;
            wordBox.BorderStyle = BorderStyle.None;
            wordBox.Enabled = false;
            wordBox.Font = new Font("Segoe UI", 12F);
            wordBox.Location = new Point(394, 79);
            wordBox.Name = "wordBox";
            wordBox.Size = new Size(209, 32);
            wordBox.TabIndex = 3;
            wordBox.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Azure;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 11F);
            textBox1.Location = new Point(394, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(209, 30);
            textBox1.TabIndex = 4;
            textBox1.Text = "Word";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(615, 340);
            Controls.Add(textBox1);
            Controls.Add(wordBox);
            Controls.Add(wordBtn);
            Controls.Add(character);
            Controls.Add(window);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox window;
        private TextBox character;
        private Button wordBtn;
        private TextBox wordBox;
        private TextBox textBox1;
    }
}
