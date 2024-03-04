
using System.Text.Json;


namespace ATM.Logger
{
    internal class CustomerLogger : ILogger
    {
        private readonly string path = @"..//..//..//Customers.json";
        public void CustomerLog(Customer customer)
        {
            string data = File.ReadAllText(path);

            var forIndent = new JsonSerializerOptions(); // creating new class in order to give indent json text
            forIndent.WriteIndented = true;

            string serializedCustomer = JsonSerializer.Serialize(customer, forIndent);


            if (data.Contains("{")) // Case when Customer.json is not empty
            {
                data = data.Insert(data.IndexOf("]") - 1, ",\n" + serializedCustomer);
            }
            else // Case when Customer.json is empty
            {
                data = data.Insert(data.IndexOf("]"), serializedCustomer + "\n");
            }


            File.WriteAllText(path, data);
        }


        public void WithdrawLog(ATMForm aTMForm, Customer customer)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong usage of Log");
            }
        }

        public void DepositLog(ATMForm aTMFrom, Customer customer)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong usage of DepositLog");
            }
        }
    }
}
