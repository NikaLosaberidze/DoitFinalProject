namespace ATM
{
    partial class ATMForm
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
            transactionsList = new ListBox();
            depositBox = new TextBox();
            withdrawBox = new TextBox();
            balanceLabel = new Label();
            balanceBox = new TextBox();
            depositBtn = new Button();
            withdrawBtn = new Button();
            transactionLabel = new Label();
            hiddenPass = new TextBox();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // transactionsList
            // 
            transactionsList.FormattingEnabled = true;
            transactionsList.HorizontalScrollbar = true;
            transactionsList.ItemHeight = 25;
            transactionsList.Location = new Point(4, 298);
            transactionsList.Name = "transactionsList";
            transactionsList.Size = new Size(1305, 254);
            transactionsList.TabIndex = 0;
            // 
            // depositBox
            // 
            depositBox.Location = new Point(438, 156);
            depositBox.Name = "depositBox";
            depositBox.Size = new Size(150, 31);
            depositBox.TabIndex = 1;
            // 
            // withdrawBox
            // 
            withdrawBox.Location = new Point(725, 156);
            withdrawBox.Name = "withdrawBox";
            withdrawBox.Size = new Size(150, 31);
            withdrawBox.TabIndex = 2;
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Location = new Point(1230, 9);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(71, 25);
            balanceLabel.TabIndex = 3;
            balanceLabel.Text = "Balance";
            // 
            // balanceBox
            // 
            balanceBox.BorderStyle = BorderStyle.None;
            balanceBox.Enabled = false;
            balanceBox.Location = new Point(1200, 37);
            balanceBox.Name = "balanceBox";
            balanceBox.Size = new Size(101, 24);
            balanceBox.TabIndex = 4;
            balanceBox.TextAlign = HorizontalAlignment.Right;
            // 
            // depositBtn
            // 
            depositBtn.Location = new Point(459, 193);
            depositBtn.Name = "depositBtn";
            depositBtn.Size = new Size(112, 34);
            depositBtn.TabIndex = 5;
            depositBtn.Text = "Deposit";
            depositBtn.UseVisualStyleBackColor = true;
            depositBtn.Click += depositBtn_Click;
            // 
            // withdrawBtn
            // 
            withdrawBtn.Location = new Point(746, 193);
            withdrawBtn.Name = "withdrawBtn";
            withdrawBtn.Size = new Size(112, 34);
            withdrawBtn.TabIndex = 6;
            withdrawBtn.Text = "Withdraw";
            withdrawBtn.UseVisualStyleBackColor = true;
            withdrawBtn.Click += withdrawBtn_Click;
            // 
            // transactionLabel
            // 
            transactionLabel.AutoSize = true;
            transactionLabel.Enabled = false;
            transactionLabel.Location = new Point(569, 270);
            transactionLabel.Name = "transactionLabel";
            transactionLabel.Size = new Size(162, 25);
            transactionLabel.TabIndex = 7;
            transactionLabel.Text = "Transaction History";
            // 
            // hiddenPass
            // 
            hiddenPass.BorderStyle = BorderStyle.None;
            hiddenPass.Enabled = false;
            hiddenPass.Location = new Point(21, 36);
            hiddenPass.Name = "hiddenPass";
            hiddenPass.Size = new Size(65, 24);
            hiddenPass.TabIndex = 8;
            hiddenPass.TextChanged += hiddenPass_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 6F);
            checkBox1.Location = new Point(0, 9);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(87, 21);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "show pass";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // ATMForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 564);
            Controls.Add(checkBox1);
            Controls.Add(hiddenPass);
            Controls.Add(transactionLabel);
            Controls.Add(withdrawBtn);
            Controls.Add(depositBtn);
            Controls.Add(balanceBox);
            Controls.Add(balanceLabel);
            Controls.Add(withdrawBox);
            Controls.Add(depositBox);
            Controls.Add(transactionsList);
            Name = "ATMForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += ATMForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox transactionsList;
        private TextBox depositBox;
        private TextBox withdrawBox;
        private Label balanceLabel;
        private TextBox balanceBox;
        private Button depositBtn;
        private Button withdrawBtn;
        private Label transactionLabel;
        private TextBox hiddenPass;
        private CheckBox checkBox1;
    }
}