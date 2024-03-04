

namespace Hangman
{
    public partial class Form1 : Form
    {
        private string userName;

        private static List<string> words = new List<string>
        {
            "apple", "banana", "orange", "grape", "kiwi",
            "strawberry", "pineapple", "blueberry", "peach", "watermelon"
        };

        private static Random rand = new Random();
        private static int tries = 6;
        private string word = "";
        private int score = 6;

        private static string startHangman = "\t\t\t\t\t\t\t\t\t\t  +---+\r\n  |   |\r\n      |\r\n      |\r\n      |\r\n      |\r\n=========\r\n";
        private static string hangman1 = "\t\t\t\t\t\t\t\t\t\t  +---+\r\n  |   |\r\n  O   |\r\n      |\r\n      |\r\n      |\r\n=========\r\n";
        private static string hangman2 = "\t\t\t\t\t\t\t\t\t\t  +---+\r\n  |   |\r\n  O   |\r\n  |   |\r\n      |\r\n      |\r\n=========\r\n";
        private static string hangman3 = "\t\t\t\t\t\t\t\t\t\t  +---+\r\n  |   |\r\n  O   |\r\n /|   |\r\n      |\r\n      |\r\n=========\r\n";
        private static string hangman4 = "\t\t\t\t\t\t\t\t\t\t  +---+\r\n  |   |\r\n  O   |\r\n /|\\ |\r\n      |\r\n      |\r\n=========\r\n";
        private static string hangman5 = "\t\t\t\t\t\t\t\t\t\t  +---+\r\n  |   |\r\n  O   |\r\n /|\\ |\r\n /    |\r\n      |\r\n=========\r\n";
        private static string finalHangman = "\t\t\t\t\t\t\t\t\t\t  +---+\r\n  |   |\r\n  O   |\r\n /|\\ |\r\n / \\ |\r\n      |\r\n=========\r\n";
        private static string[] hangmanList = [startHangman,hangman1,hangman2,hangman3,hangman4,hangman5,finalHangman];

        public Form1(string userName)
        {
            this.userName = userName;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            window.Text = startHangman;
            int wordNum = rand.Next(0, 9);
            word = words[wordNum];

            wordBox.Text = "";
            for (int i = 0; i < word.Length; i++)
            {

                wordBox.Text += "-";
            }

        }

        private void wordBtn_Click(object sender, EventArgs e)
        {
              
            if (tries > 0)
            {

                if (character.Text == word) // Input word is same as the hidden word
                {
                    wordBox.Text = word;
                    MessageBox.Show("Congratulations! You Won!");
                    // Creating object for records
                    User user = new User();
                    user.name = userName;
                    user.score = score;
                    user.serializer(@"..//..//..//records.xml");


                    //From here, game starts again
                    window.Text = startHangman;
                    int wordNum = rand.Next(0, 9);
                    word = words[wordNum];

                    wordBox.Text = "";
                    for (int i = 0; i < word.Length; i++)
                    {

                        wordBox.Text += "-";
                    }
                    character.Text = "";
                    tries = 6;
                    score = 6;
                    return;
                }


                string temp = "";
                if (word.Contains(character.Text))
                {
                    for(int i = 0;i < word.Length;i++)
                    {
                        if (wordBox.Text[i].ToString() != "-") // so this character is a letter
                        {
                            temp += wordBox.Text[i];
                            continue;
                        }
                        if (word[i].ToString() == character.Text) // in this case character is '-' and our letter(in input) is correct
                        {
                            temp += word[i];


                        }
                        else
                        {
                            temp += "-"; // our letter(in input) is incorrect
                            
                        }
                    }

                    if (temp == word) // checking if client has won or not
                    {
                        wordBox.Text = temp;
                        MessageBox.Show("Congratulations! You Won!");
                        User user = new User();
                        user.name = userName;
                        user.score = score;
                        user.serializer(@"..//..//..//records.xml");

                        //From here, game starts again
                        window.Text = startHangman;
                        int wordNum = rand.Next(0, 9);
                        word = words[wordNum];

                        wordBox.Text = "";
                        for (int i = 0; i < word.Length; i++)
                        {

                            wordBox.Text += "-";
                        }
                        character.Text = "";
                        tries = 6;
                        score = 6;
                        return;
                    }

                    wordBox.Text = temp;

                }
                else
                {
                    tries--;
                    score--;
                    window.Text = hangmanList[6-tries];
                }
                
                
                character.Text = "";
            }
            
            else
            {
                window.Text = hangmanList[6];
                MessageBox.Show($"You Lost!\nWord Was {word}");


                //From here, game starts again
                window.Text = startHangman;
                int wordNum = rand.Next(0, 9);
                word = words[wordNum];

                wordBox.Text = "";
                for (int i = 0; i < word.Length; i++)
                {

                    wordBox.Text += "-";
                }
                character.Text = "";
                tries = 6;
                score = 6;
            }
            


        }


    }
}
