namespace NumberGuess
{
    internal class Program
    {
        static void Main(string[] args)
        {



            try // This checks whether Top10 file had ever been created or not and acts accordingly.
            {

                File.ReadAllLines(@"..//..//..//Top10.csv");

            }
            catch (Exception ex)
            {
                Game.MakeTop10();
            }



            while (true)
            {
                Console.WriteLine("Hello, This Is Number Guessing Game!\n" +
                    "Number Is Random And You Should Guess It!\n" +
                    "You Have 10 Tries!\n");
                string name = "";

                while (true)
                {
                    Console.Write("Type Your Nickname (Except 'Null') : "); //I Forbid 'Null' Because It Interupts My Solution
                    name = Console.ReadLine();
                    if (name == "Null")
                    {
                        Console.WriteLine("Invalid Name!");
                        continue;
                    }
                    break;
                }

                Console.WriteLine("Choose Difficulty: Easy(1-15), Medium(1-25), Hard(1-50)\n" +
                                  "If You Want To See Top10, Print 'TOP'\n" +
                                  "If You Want To Exit, Print 'Exit'");

                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "Easy":
                        Game.Easy(name);
                        break;

                    case "Medium":
                        Game.Medium(name);
                        break;

                    case "Hard":
                        Game.Hard(name);
                        break;

                    case "TOP":
                        Console.WriteLine(Game.Top10());
                        break;

                    case "Exit":
                        return;

                    default:
                        Console.WriteLine("Invalid Input!\n");
                        continue;
                }
            }

        }
    }
}
