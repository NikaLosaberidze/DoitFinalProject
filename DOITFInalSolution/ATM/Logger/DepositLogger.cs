
using System.Text.Json;

namespace ATM.Logger
{
    internal class DepositLogger : ILogger
    {
        private readonly string transactionsPath = @"..//..//..//transactions.json";
        public void DepositLog(ATMForm aTMForm,Customer customer)
        {
            string transaction = $"    \"{customer.Auto_ID}. მომხმარებელმა სახელად {customer} - შეავსო ბალანსი {aTMForm.DepostiBox.Text} ლარით : {DateTime.Now} - ში. მისი მოქმედი ბალანსი შეადგენს {aTMForm.BalanceBox.Text} ლარს\"";
            string data = File.ReadAllText(transactionsPath);
            data = data.Insert(data.IndexOf("]") - 1, ",\n" + transaction);
            File.WriteAllText(transactionsPath,data);

            // Adding transactions while customer is logged in
            aTMForm.TransactionsListAdd($"{customer.Auto_ID}. მომხმარებელმა სახელად {customer} - შეავსო ბალანსი {aTMForm.DepostiBox.Text} ლარით : {DateTime.Now} - ში. მისი მოქმედი ბალანსი შეადგენს {aTMForm.BalanceBox.Text} ლარს");

            aTMForm.DepostiBox.Text = "";


            string jsonContent = File.ReadAllText(@"..//..//..//Customers.json");
            List<Customer>? customerList = JsonSerializer.Deserialize<List<Customer>>(jsonContent);
            var curCustomer = customerList.FirstOrDefault(a => a.Id == customer.Id);
            int index = customerList.IndexOf(curCustomer);
            curCustomer.Balance = int.Parse(aTMForm.BalanceBox.Text);
            customerList[index] = curCustomer;

            string serializedCustomers = JsonSerializer.Serialize(customerList, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            File.WriteAllText(@"..//..//..//Customers.json", serializedCustomers);

            
        }


        public void CustomerLog(Customer customer)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong usage of CustomerLog");
            }
        }

        public void WithdrawLog(ATMForm aTMForm, Customer customer)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong usage of WithdrawLog");
            }
        }
    }
}
