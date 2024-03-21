using System;
using System.Text;

namespace FunctionChallenges
{
    class Program
    {
        static string StringNumberProcessor(params object[] Value)
        {
            string sentence = "";
            int number = 0;

            foreach (var item in Value)
            {
                if (item is int num)
                {
                    number += num;
                }
                else if (item is string str)
                {
                    sentence += $"{str} ";
                }
            }
            return $"{sentence}{number}";
        }

        static void SwapObjects<T>(ref T obj1, ref T obj2)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            if (typeof(T) == typeof(string))
            {
                string str1 = obj1 as string;
                string str2 = obj2 as string;

                if (str1.Length <= 5 || str2.Length <= 5)
                {
                    Console.WriteLine("Error: Length must be more than 5");
                    return;
                }
            }
            else if (typeof(T) == typeof(int))
            {
                int num1 = Convert.ToInt32(obj1);
                int num2 = Convert.ToInt32(obj2);

                if (num1 <= 18 || num2 <= 18)
                {
                    Console.WriteLine("Error: Value must be more than 18");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Error: Unsupported type");
                return;
            }
            // Swap the objects
            T temp = obj1;
            obj1 = obj2;
            obj2 = temp;
        }

        static void GuessingGame(int range = 0)
        {
            Random randomNumber = new Random();
            if (range == 0)
            {
                range = randomNumber.Next(1, 100);
            }
            int num = randomNumber.Next(1, range + 1);

            while (true)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"Guess a number between 1 - {range}?");
                    int input = Convert.ToInt32(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;
                    if (input == num)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You guessed it! 🎉");
                        break;
                    }
                    else if (input >= num - 2 && input <= num + 2)
                    {
                        Console.WriteLine("You're very close! 🤩");

                    }
                    else if (input >= num - 5 && input <= num + 5)
                    {
                        Console.WriteLine("You're getting closer! 🫢");

                    }
                    else if (input >= num - 10 && input <= num + 10)
                    {
                        Console.WriteLine("You're still far away. 😥");
                    }
                    else
                    {
                        Console.WriteLine("You're very far. 🫠");
                    }
                    Console.WriteLine("");

                }
                catch (System.FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Enter a number");

                }
                catch (System.Exception)
                {
                    throw;
                }
            }

        }

        static string ReverseWords(string str)
        {//enter wrong commit and i couldn't know how to change it
            StringBuilder reversed = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed.Append(str[i]);
            }
            string[] strArray = reversed.ToString().Split(" ");
            Array.Reverse(strArray);
            str = String.Join(' ', strArray);
            return str;
        }

        static void PrintDivider()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(".:*~*:._.:*~*:._.:*~*:._.:*~*:._.:*~*:._.:*~*:._.:*~*:._.:*~*:.");
        }
        static void Main(string[] args)
        {
            // Title 
            string title = @"            ('-. .-.   ('-.                           ('-.       .-') _               ('-.    .-')    
           ( OO )  /  ( OO ).-.                     _(  OO)     ( OO ) )            _(  OO)  ( OO ).  
   .-----. ,--. ,--.  / . --. / ,--.      ,--.     (,------.,--./ ,--,'  ,----.    (,------.(_)---\_) 
  '  .--./ |  | |  |  | \-.  \  |  |.-')  |  |.-')  |  .---'|   \ |  |\ '  .-./-')  |  .---'/    _ |  
  |  |('-. |   .|  |.-'-'  |  | |  | OO ) |  | OO ) |  |    |    \|  | )|  |_( O- ) |  |    \  :` `.  
 /_) |OO  )|       | \| |_.'  | |  |`-' | |  |`-' |(|  '--. |  .     |/ |  | .--, \(|  '--.  '..`''.) 
 ||  |`-'| |  .-.  |  |  .-.  |(|  '---.'(|  '---.' |  .--' |  |\    | (|  | '. (_/ |  .--' .-._)   \ 
(_'  '--'\ |  | |  |  |  | |  | |      |  |      |  |  `---.|  | \   |  |  '--'  |  |  `---.\       / 
   `-----' `--' `--'  `--' `--' `------'  `------'  `------'`--'  `--'   `------'   `------' `-----'  ";


            Console.WriteLine("");
            Console.WriteLine(title);
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.White;
            // Challenge 1: String and Number Processor
            Console.WriteLine("Challenge 1: String and Number Processor");
            Console.WriteLine(StringNumberProcessor("Hello", 100, 200, "World"));
            // Expected outcome: "Hello World; 300"

            PrintDivider();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            // Challenge 2: Object Swapper
            Console.WriteLine("\nChallenge 2: Object Swapper");
            int num1 = 25, num2 = 30;
            int num3 = 10, num4 = 30;
            string str1 = "HelloWorld", str2 = "Programming";
            string str3 = "Hi", str4 = "Programming";

            SwapObjects(ref num1, ref num2); // Expected outcome: num1 = 30, num2 = 25  
            SwapObjects(ref num3, ref num4); // Error: Value must be more than 18

            SwapObjects(ref str1, ref str2); // Expected outcome: str1 = "Programming", str2 = "HelloWorld"
            SwapObjects(ref str3, ref str4); // Error: Length must be more than 5

            bool b1 = true;
            bool b2 = false;
            SwapObjects(ref b1, ref b2); // Error: Upsupported data type
            // SwapObjects(ref num1, str1); // Error: Objects must be of same types
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Numbers: {num1}, {num2}");
            Console.WriteLine($"Strings: {str1}, {str2}");

            PrintDivider();
            Console.ForegroundColor = ConsoleColor.Magenta;
            // Challenge 3: Guessing Game
            Console.WriteLine("\nChallenge 3: Guessing Game");
            try
            {
                Console.WriteLine("Enter number range: ");
                int numberRange = int.Parse(Console.ReadLine());
                // Uncomment to test the GuessingGame method
                GuessingGame(numberRange); // Expected outcome: User input until the correct number is guessed or user inputs `Quit`
            }
            catch (System.FormatException)
            {
                Console.WriteLine("You didn't enter number range so it will be random 😛");
                GuessingGame();
            }
        
            PrintDivider();
            Console.ForegroundColor = ConsoleColor.Cyan;
            // Challenge 4: Simple Word Reversal
            Console.WriteLine("\nChallenge 4: Simple Word Reversal");
            string sentence = "This is the original sentence!";
            string reversed = ReverseWords(sentence);
            Console.WriteLine(reversed); // Expected outcome: "sihT si eht lanigiro !ecnetnes"
            Console.WriteLine("");

        }
    }
}
