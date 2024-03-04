

namespace ATM
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }


        private void logInBtn_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            Hide();
            logIn.ShowDialog();
            Show();
        }


        private void signUpBtn_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            Hide();
            signUp.ShowDialog();
            Show();
        }

    }
}
