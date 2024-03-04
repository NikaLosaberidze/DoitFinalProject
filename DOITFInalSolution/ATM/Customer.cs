namespace ATM
{
    public class Customer
    {
        private string auto_Id;
        private string firstName;   
        private string lastName;
        
        private string ID;
        
        private string password;
        private int balance;



        public Customer(string auto_Id,string firstName,string lastName,string ID,string password)
        {
            this.auto_Id = auto_Id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.ID = ID;
            this.password = password;
            balance = 500; // Starting Balance

        }

        public override string ToString()
        {
            return $"{firstName} {lastName}";
        }



        public string Auto_ID
        {
            get { return auto_Id ; }
        }
        public string FirstName
        {
            get { return firstName; }
        }
        public string LastName
        {
            get { return lastName; }
        }
        public string Id
        {
            get { return ID; }
        }
        public string Password
        {
            get { return password; }
        }
        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

    }

}
