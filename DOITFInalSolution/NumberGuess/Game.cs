using System.Data;
using System.Text;

namespace NumberGuess
{

    /* 
     * In this game, I use following scoring system:
     * On Easy Mode, if a player wins, his/her score will be 15 - (10 - tries). That is number of tries that he/she needed
     * On Medium Mode -- 25 - (10 - tries)
     * On Hard Mode -- 50 - 3*(10 - tries)
     * There is a one exception, if a player won on the first try, they have maximum score(i.e. nothing is subtracted)
     * 
     * To Sum Up 
     * Easy Mode Min/Max Points:    6/15
     * Medium Mode Min/Max Points: 16/25
     * Hard Mode Min/Max Points:   23/50
     */

    internal class Game
    {

        private static Random rand = new Random();
        private static string path = @"..//..//..//Top10.csv";


        public static void Easy(string name)
        {
            int tries = 10;
            int score = 15;
            int x = rand.Next(1, 15);

            int answer = 0;
            Console.WriteLine("GUESS!\n");
            while (tries > 0)
            {

                if (!int.TryParse(Console.ReadLine(), out answer))
                {
                    Console.WriteLine("Invalid Input! You Must Write A Integer, Try Again!");
                    continue;
                }

                if (answer < x)
                {
                    Console.WriteLine("Higher!");
                    tries--;
                }
                else if (answer > x)
                {
                    Console.WriteLine("Lower!");
                    tries--;
                }
                else
                {
                    Console.WriteLine("You Win!\n");
                    int points = score - (10 - tries);
                    UpdateCSV(name, points);
                    return;
                }
            }

            Console.WriteLine("Try Again!");
        }


        public static void Medium(string name)
        {
            int tries = 10;
            int score = 25;
            int x = rand.Next(1, 25);

            int answer = 0;
            Console.WriteLine("GUESS!\n");
            while (tries > 0)
            {
                if (!int.TryParse(Console.ReadLine(), out answer))
                {
                    Console.WriteLine("Invalid Input! You Must Write A Integer, Try Again!");
                    continue;
                }



                if (answer < x)
                {
                    Console.WriteLine("Higher!");
                    tries--;
                }
                else if (answer > x)
                {
                    Console.WriteLine("Lower!");
                    tries--;
                }
                else
                {
                    Console.WriteLine("You Win!\n");
                    int points = score - (10 - tries);
                    UpdateCSV(name, points);
                    return;
                }
            }
        }


        public static void Hard(string name)
        {
            int tries = 10;
            int score = 50;
            int x = rand.Next(1, 50);

            int answer = 0;
            Console.WriteLine("GUESS!\n");
            while (tries > 0)
            {
                if (!int.TryParse(Console.ReadLine(), out answer))
                {
                    Console.WriteLine("Invalid Input! You Must Write A Integer, Try Again!");
                    continue;
                }

                if (answer < x)
                {
                    Console.WriteLine("Higher!");
                    tries--;
                }
                else if (answer > x)
                {
                    Console.WriteLine("Lower!");
                    tries--;
                }
                else
                {
                    Console.WriteLine("You Win!\n");
                    int points = score - 3 * (10 - tries);
                    UpdateCSV(name, points);
                    return;
                }
            }
        }




        public static void MakeTop10()
        {
            StringBuilder csvContent = new StringBuilder();
            csvContent.AppendLine("Name,Top Score");
            csvContent.AppendLine("Null,0");
            csvContent.AppendLine("Null,0");
            csvContent.AppendLine("Null,0");
            csvContent.AppendLine("Null,0");
            csvContent.AppendLine("Null,0");
            csvContent.AppendLine("Null,0");
            csvContent.AppendLine("Null,0");
            csvContent.AppendLine("Null,0");
            csvContent.AppendLine("Null,0");
            csvContent.AppendLine("Null,0");

            File.WriteAllText(path, csvContent.ToString());
        }


        public static string Top10()
        {
            string[] data = File.ReadAllLines(path);
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
            return "";
        }



        public static void UpdateCSV(string name, int points)
        {
            StringBuilder temp = new StringBuilder();
            temp.AppendLine($"{name},{points.ToString()}");
            File.AppendAllText(path, temp.ToString());
            string[] data = File.ReadAllLines(path);
            IEnumerable<string[]> result = (from item in data.Skip(1)
                                            let line = item.Split(',')
                                            orderby int.Parse(line[1]) descending
                                            select line).Take(10);

            File.WriteAllLines(path, ["Name,Top Score"]);
            foreach (var item in result)
            {
                File.AppendAllText(path, $"{item[0]},{item[1]}\n");
            }
        }



    }
}
