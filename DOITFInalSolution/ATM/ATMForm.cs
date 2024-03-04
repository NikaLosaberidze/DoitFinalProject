

using ATM.Logger;

namespace ATM
{
    public partial class ATMForm : Form
    {
        private Customer customer;

        public ATMForm(Customer customer)
        {
            this.customer = customer;
            InitializeComponent();
        }
        private void ATMForm_Load(object sender, EventArgs e)
        {
            balanceBox.Text = $"{customer.Balance}";
            hiddenPass.Text = customer.Password;
            hiddenPass.UseSystemPasswordChar = true;

            string data = File.ReadAllText(@"..//..//..//transactions.json");
            string[] array = data.Split("\"");
            for (int i = 1; i < array.Length; i += 2)
            {
                string[] temp = array[i].Split(".");
                if (temp[0] == customer.Auto_ID)
                {
                    transactionsList.Items.Add(array[i]);
                }
            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // If Checkbox is checked then password is visible, else it's not
            if (hiddenPass.UseSystemPasswordChar)
            {
                hiddenPass.UseSystemPasswordChar = false;
            }
            else
            {
                hiddenPass.UseSystemPasswordChar = true;
            }
        }

        private void withdrawBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(withdrawBox.Text, out int result))
            {
                if (result <= int.Parse(balanceBox.Text))
                {
                    balanceBox.Text = $"{int.Parse(balanceBox.Text) - result}";
                    WithdrawLogger withdrawLogger = new WithdrawLogger();
                    withdrawLogger.WithdrawLog(this, customer);
                    return;
                }
            }

            MessageBox.Show("Error");

        }

        private void depositBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(depositBox.Text, out int result))
            {
                balanceBox.Text = $"{int.Parse(balanceBox.Text) + result}";
                DepositLogger depositLogger = new DepositLogger();
                depositLogger.DepositLog(this, customer);
                return;
            }

            MessageBox.Show("Error");
        }

        private void hiddenPass_TextChanged(object sender, EventArgs e)
        {

        }

        public TextBox BalanceBox
        {
            get { return balanceBox; }
            set { balanceBox = value; }
        }

        public TextBox DepostiBox
        {
            get { return depositBox; }
            set { depositBox = value; }
        }
        public TextBox WithdrawBox
        {
            get { return withdrawBox; }
            set { withdrawBox = value; }
        }
        
        public void TransactionsListAdd(string transaction)
        {
            transactionsList.Items.Add(transaction);
        }

    }
}
