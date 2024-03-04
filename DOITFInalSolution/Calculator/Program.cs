namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!\nThis is console calculator where you can use operators:+,-,*,/\n" +
                "Firstly, you must write first number on which you want to do mathematical" +
                " operation,\nthen second number and then the operation that you wish to do.\n" +
                "If you want to close calculator, just write 'exit'");
            string inp = "";
            float first = 0;
            float second = 0;

            while (true)
            {
                Console.Write("\nWrite First Number: ");
                inp = Console.ReadLine();


                // Checking Validation For First Number
                while (true)
                {
                    try
                    {
                        if (inp == "exit")
                        {
                            Console.WriteLine("\nBye!");
                            return;
                        }

                        first = float.Parse(inp);
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.Write("Invalid Input. Try Again: ");
                        inp = Console.ReadLine();
                    }
                }


                Console.Write("Write Second Number:");
                inp = Console.ReadLine();

                // Checking Validation For Second Number
                while (true)
                {
                    try
                    {
                        if (inp == "exit")
                        {
                            Console.WriteLine("\nBye!");
                            return;
                        }

                        second = float.Parse(inp);
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.Write("Invalid Input. Try Again: ");
                        inp = Console.ReadLine();
                    }
                }


                Console.Write("Write Mathematical Operator(+,-,*,/):");
                inp = Console.ReadLine();

                // Checking Validation For Mathematical Operator
                while (true)
                {
                    try
                    {
                        if (inp == "exit")
                        {
                            Console.WriteLine("\nBye!");
                            return;
                        }
                        if (inp != "+" && inp != "-" && inp != "*" && inp != "/")
                        {
                            throw new Exception();

                        }

                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.Write("Invalid Input. Try Again: ");
                        inp = Console.ReadLine();
                    }
                }

                switch (inp)
                {
                    case "+":
                        Console.WriteLine($"{first} + {second} = {first + second}");
                        break;
                    case "-":
                        Console.WriteLine($"{first} - {second} = {first - second}");
                        break;
                    case "*":
                        Console.WriteLine($"{first} * {second} = {first * second}");
                        break;
                    case "/":
                        Console.WriteLine($"{first} / {second} = {first / second}");
                        break;

                }


            }


        }
    }
}
