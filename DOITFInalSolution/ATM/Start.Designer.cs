namespace ATM
{
    partial class Start
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
            logInBtn = new Button();
            signUpBtn = new Button();
            SuspendLayout();
            // 
            // logInBtn
            // 
            logInBtn.Location = new Point(123, 93);
            logInBtn.Name = "logInBtn";
            logInBtn.Size = new Size(112, 34);
            logInBtn.TabIndex = 0;
            logInBtn.Text = "Log In";
            logInBtn.UseVisualStyleBackColor = true;
            logInBtn.Click += logInBtn_Click;
            // 
            // signUpBtn
            // 
            signUpBtn.Location = new Point(123, 201);
            signUpBtn.Name = "signUpBtn";
            signUpBtn.Size = new Size(112, 34);
            signUpBtn.TabIndex = 1;
            signUpBtn.Text = "Sign Up";
            signUpBtn.UseVisualStyleBackColor = true;
            signUpBtn.Click += signUpBtn_Click;
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 358);
            Controls.Add(signUpBtn);
            Controls.Add(logInBtn);
            Name = "Start";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ATM";
            ResumeLayout(false);
        }

        #endregion

        private Button logInBtn;
        private Button signUpBtn;
    }
}