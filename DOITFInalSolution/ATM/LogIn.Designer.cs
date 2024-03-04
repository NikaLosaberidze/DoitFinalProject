namespace ATM
{
    partial class LogIn
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
            logInIDBox = new TextBox();
            logInPasswordBox = new TextBox();
            logInIDLabel = new Label();
            passwordLabel = new Label();
            logingInBtn = new Button();
            SuspendLayout();
            // 
            // logInIDBox
            // 
            logInIDBox.Location = new Point(128, 77);
            logInIDBox.Name = "logInIDBox";
            logInIDBox.Size = new Size(150, 31);
            logInIDBox.TabIndex = 1;
            // 
            // logInPasswordBox
            // 
            logInPasswordBox.Location = new Point(128, 181);
            logInPasswordBox.Name = "logInPasswordBox";
            logInPasswordBox.PasswordChar = '*';
            logInPasswordBox.Size = new Size(150, 31);
            logInPasswordBox.TabIndex = 2;
            // 
            // logInIDLabel
            // 
            logInIDLabel.AutoSize = true;
            logInIDLabel.Location = new Point(128, 49);
            logInIDLabel.Name = "logInIDLabel";
            logInIDLabel.Size = new Size(30, 25);
            logInIDLabel.TabIndex = 3;
            logInIDLabel.Text = "ID";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(128, 153);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(87, 25);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Password";
            // 
            // logingInBtn
            // 
            logingInBtn.Location = new Point(143, 249);
            logingInBtn.Name = "logingInBtn";
            logingInBtn.Size = new Size(112, 34);
            logingInBtn.TabIndex = 5;
            logingInBtn.Text = "Log In";
            logingInBtn.UseVisualStyleBackColor = true;
            logingInBtn.Click += logingInBtn_Click;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 358);
            Controls.Add(logingInBtn);
            Controls.Add(passwordLabel);
            Controls.Add(logInIDLabel);
            Controls.Add(logInPasswordBox);
            Controls.Add(logInIDBox);
            Name = "LogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox logInIDBox;
        private TextBox logInPasswordBox;
        private Label logInIDLabel;
        private Label passwordLabel;
        private Button logingInBtn;
    }
}