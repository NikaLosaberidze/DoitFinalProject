namespace ATM
{
    partial class SignUp
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
            firstNameBox = new TextBox();
            lastNameBox = new TextBox();
            IDBox = new TextBox();
            fnameLabel = new Label();
            lnameLabel = new Label();
            idLabel = new Label();
            submitBtn = new Button();
            SuspendLayout();
            // 
            // firstNameBox
            // 
            firstNameBox.Location = new Point(32, 73);
            firstNameBox.Name = "firstNameBox";
            firstNameBox.Size = new Size(150, 31);
            firstNameBox.TabIndex = 0;
            // 
            // lastNameBox
            // 
            lastNameBox.Location = new Point(217, 73);
            lastNameBox.Name = "lastNameBox";
            lastNameBox.Size = new Size(150, 31);
            lastNameBox.TabIndex = 1;
            // 
            // IDBox
            // 
            IDBox.Location = new Point(125, 155);
            IDBox.Name = "IDBox";
            IDBox.Size = new Size(150, 31);
            IDBox.TabIndex = 3;
            // 
            // fnameLabel
            // 
            fnameLabel.AutoSize = true;
            fnameLabel.Location = new Point(32, 32);
            fnameLabel.Name = "fnameLabel";
            fnameLabel.Size = new Size(89, 25);
            fnameLabel.TabIndex = 4;
            fnameLabel.Text = "Firstname";
            // 
            // lnameLabel
            // 
            lnameLabel.AutoSize = true;
            lnameLabel.Location = new Point(217, 32);
            lnameLabel.Name = "lnameLabel";
            lnameLabel.Size = new Size(87, 25);
            lnameLabel.TabIndex = 5;
            lnameLabel.Text = "Lastname";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(125, 116);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(30, 25);
            idLabel.TabIndex = 6;
            idLabel.Text = "ID";
            // 
            // submitBtn
            // 
            submitBtn.Location = new Point(143, 227);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(112, 34);
            submitBtn.TabIndex = 8;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submitBtn_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 358);
            Controls.Add(submitBtn);
            Controls.Add(idLabel);
            Controls.Add(lnameLabel);
            Controls.Add(fnameLabel);
            Controls.Add(IDBox);
            Controls.Add(lastNameBox);
            Controls.Add(firstNameBox);
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign Up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstNameBox;
        private TextBox lastNameBox;
        private TextBox IDBox;
        private Label fnameLabel;
        private Label lnameLabel;
        private Label idLabel;
        private Button submitBtn;
    }
}
