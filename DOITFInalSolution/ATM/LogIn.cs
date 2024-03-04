
using System.Data;
using System.Text.Json;

namespace ATM
{
    public partial class LogIn : Form
    {
        private readonly string path = @"..//..//..//Customers.json";
        private readonly string transactionsPath = @"..//..//..//transactions.json";

        public LogIn()
        {
            InitializeComponent();
        }

        private void logingInBtn_Click(object sender, EventArgs e)
        {
            string ID = logInIDBox.Text;
            string password = logInPasswordBox.Text;

            try
            {
                var customerData = File.ReadAllText(path);
                List<Customer>? customerList = JsonSerializer.Deserialize<List<Customer>>(customerData);
                var IDs = customerList.Select(customer => customer.Id);
                Customer currentCustomer = customerList.Find(customer => customer.Id == ID);

                if (IDs.Contains(ID))
                {

                    if (password != currentCustomer.Password)
                    {
                        throw new Exception(); // throwing exception because password is incorrect
                    }
                }
                else
                {
                    throw new Exception(); // throwing exception because ID is incorrect
                }

                // After this everything is correct and ATM form must be opened.

                ATMForm aTMForm = new ATMForm(currentCustomer);
                string history = $"    \"{currentCustomer.Auto_ID}. მომხმარებელი სახელად {currentCustomer} დალოგინდა {DateTime.Now}-ში\"";

                string data = File.ReadAllText(transactionsPath);
                data = data.Insert(data.IndexOf("]") - 1, ",\n" + history);
                File.WriteAllText(transactionsPath, data);

                Hide();
                aTMForm.ShowDialog();
                data = File.ReadAllText(transactionsPath);
                history = $"    \"{currentCustomer.Auto_ID}. მომხმარებელი სახელად {currentCustomer} დალოგაუთდა {DateTime.Now}-ში\"";

                data = data.Insert(data.IndexOf("]") - 1, ",\n" + history);
                File.WriteAllText(transactionsPath, data);


                Close();

            }
            catch (Exception ex) // Case when Id or Password is incorrect or does not account does not exist
            {
                MessageBox.Show("ID or Password is incorrect");
            }
        }
    }
}
