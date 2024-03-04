namespace Hangman
{
    partial class Form2
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
            nameLabel = new Label();
            nameBox = new TextBox();
            nameBtn = new Button();
            recordList = new ListBox();
            recLabel = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(374, 107);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(99, 25);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Your Name";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(350, 135);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(150, 31);
            nameBox.TabIndex = 1;
            // 
            // nameBtn
            // 
            nameBtn.Location = new Point(374, 172);
            nameBtn.Name = "nameBtn";
            nameBtn.Size = new Size(99, 34);
            nameBtn.TabIndex = 2;
            nameBtn.Text = "Enter";
            nameBtn.UseVisualStyleBackColor = true;
            nameBtn.Click += nameBtn_Click;
            // 
            // recordList
            // 
            recordList.FormattingEnabled = true;
            recordList.ItemHeight = 25;
            recordList.Location = new Point(12, 12);
            recordList.Name = "recordList";
            recordList.Size = new Size(205, 279);
            recordList.TabIndex = 3;
            // 
            // recLabel
            // 
            recLabel.AutoSize = true;
            recLabel.Enabled = false;
            recLabel.Location = new Point(59, 294);
            recLabel.Name = "recLabel";
            recLabel.Size = new Size(75, 25);
            recLabel.TabIndex = 4;
            recLabel.Text = "Records";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 6F);
            textBox1.Location = new Point(356, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(247, 16);
            textBox1.TabIndex = 5;
            textBox1.Text = "Records will show up after restarting the game";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 340);
            Controls.Add(textBox1);
            Controls.Add(recLabel);
            Controls.Add(recordList);
            Controls.Add(nameBtn);
            Controls.Add(nameBox);
            Controls.Add(nameLabel);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private TextBox nameBox;
        private Button nameBtn;
        private ListBox recordList;
        private Label recLabel;
        private TextBox textBox1;
    }
}