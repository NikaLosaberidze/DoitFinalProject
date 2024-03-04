
using System.Xml.Serialization;

namespace Hangman
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void nameBtn_Click(object sender, EventArgs e)
        {
            if (nameBox.Text.Length == 0)
            {
                MessageBox.Show("Invalid Name!");
            }

            Form1 form1 = new Form1(nameBox.Text);
            Hide();
            form1.ShowDialog();
            Show();

        }

        private void Form2_Load(object sender, EventArgs e) // Loading records if they exist
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<User>));

            List<User> userList;


            try
            {
                using (TextReader reader = new StreamReader(@"..//..//..//records.xml"))
                {
                    userList = (List<User>)serializer.Deserialize(reader);
                }
            }
            catch (FileNotFoundException) // In this case files does not exist, so I create new List
            {

                userList = new List<User>();
            }

            foreach (var item in userList)
            {
                recordList.Items.Add(item);
            }
        }
    }
}
