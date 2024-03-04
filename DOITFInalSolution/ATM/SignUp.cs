using ATM.Logger;
using System.Text.Json;



namespace ATM
{
    public partial class SignUp : Form
    {
        private readonly string path = @"..//..//..//Customers.json";
        private readonly string transactionsPath = @"..//..//..//transactions.json";
        private Random rand = new Random();
        private CustomerLogger customerLogger = new CustomerLogger();


        public SignUp()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string name = firstNameBox.Text;
            string lastName = lastNameBox.Text;
            string ID = IDBox.Text;

            if (!int.TryParse(ID,out int idResult) || name == "" || name == null ||
                lastName == "" || lastName == null) // Little validation for name lastname and ID
            {
                MessageBox.Show("Your firstname,lastname or ID is invalid");
                return;
            }

            
            try 
            {
                File.ReadAllText(path); // Testing reading json file, if it gives us error, that means that file does not exist

            }
            catch(Exception ex) 
            {
                File.WriteAllText(path,"[\n]"); // Creating new JSon file
                string currentData = File.ReadAllText(path);

                int randPass = rand.Next(1000,9999);

                Customer cust = new Customer("1", name, lastName, ID, $"{randPass}");
                
                customerLogger.CustomerLog(cust);

                // Saving history below...
                // In This Case File Is Not Created


                string History = $"    \"{cust.Auto_ID}. მომხმარებელი სახელად {cust} დალოგინდა {DateTime.Now}-ში\""; 
                File.WriteAllText(transactionsPath, "[\n]");
                string Data = File.ReadAllText(transactionsPath);
                currentData = currentData.Insert(currentData.IndexOf("]"), History + "\n");
                File.WriteAllText(transactionsPath, currentData);
            



                Hide();
                ATMForm aTMForm = new ATMForm(cust);
                aTMForm.ShowDialog();

                currentData = File.ReadAllText(transactionsPath);
                History = $"    \"{cust.Auto_ID}. მომხმარებელი სახელად {cust} დალოგაუთდა {DateTime.Now}-ში\"";
                currentData = currentData.Insert(currentData.IndexOf("]") - 1, ",\n" + History);
                File.WriteAllText(transactionsPath, currentData);

                Close();
                return; // New Customer Is Added
            }




            var customerData = File.ReadAllText(path);

            List<Customer>? customerList = JsonSerializer.Deserialize<List<Customer>>(customerData);

            string currAuto_Id = customerList.Last().Auto_ID;
            string newAuto_Id = $"{int.Parse(currAuto_Id)+1}";


            var ids = customerList.Select(customer => customer.Id);
            if (ids.Contains(ID)) // Case when someone in sing up uses used ID
            {
                MessageBox.Show("User is already registered");
                return;
            }


            var passwords = customerList.Select(customer => customer.Password);
            int newPass = rand.Next(1000,9999);
            while(passwords.Contains($"{newPass}")) // In order to all customers have distinct passwords 
            {
                newPass = rand.Next(1000, 9999);
            }

            Customer newCustomer = new Customer(newAuto_Id,name,lastName,ID,$"{newPass}");
            customerLogger.CustomerLog(newCustomer);
            

            

            // Saving history below...
            
            string history = $"    \"{newCustomer.Auto_ID}. მომხმარებელი სახელად {newCustomer} დალოგინდა {DateTime.Now}-ში\"";
            string data = File.ReadAllText(transactionsPath);
            data = data.Insert(data.IndexOf("]") - 1, ",\n" + history);
            File.WriteAllText(transactionsPath,data);
        
            

            Hide();
            ATMForm newATMForm = new ATMForm(newCustomer);
            newATMForm.ShowDialog();
            data = File.ReadAllText(transactionsPath);
            history = $"    \"{newCustomer.Auto_ID}. მომხმარებელი სახელად {newCustomer} დალოგაუთდა {DateTime.Now}-ში\"";
            data = data.Insert(data.IndexOf("]")-1, ",\n" + history);
            File.WriteAllText(transactionsPath, data);

            Close();
            return; // New Customer Is Added
        }
    }
}
