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

        static void SwapObjects() { }

        static void GuessingGame(int range = 0)
        {
            Random randomNumber = new Random();
            if (range == 0)
            {
                range = randomNumber.Next(1, 100);
            }
            int num = randomNumber.Next(range);


            while (true)
            {
                try
                {
                    Console.WriteLine("Guess a number?");
                    int input = Convert.ToInt32(Console.ReadLine());

                    if (input == num)
                    {
                        Console.WriteLine("You Guess it!!🎉");
                        break;
                    }
                    else if (input >= num - 2 && input <= num + 2)
                    {
                        Console.WriteLine("You are too close 🤩");

                    }
                    else if (input >= num - 5 && input <= num + 5)
                    {
                        Console.WriteLine("You are close 🫢");

                    }
                    else if (input >= num - 10 && input <= num + 10)
                    {
                        Console.WriteLine("You are far 😥");
                    }
                    else
                    {
                        Console.WriteLine("You are too far 🫠");
                    }
                }
                catch (System.FormatException)
                {
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
        static void Main(string[] args)
        {
            // Challenge 1: String and Number Processor
            Console.WriteLine("Challenge 1: String and Number Processor");
            Console.WriteLine(StringNumberProcessor("Hello", 100, 200, "World"));
            // Expected outcome: "Hello World; 300"

            // Challenge 2: Object Swapper
            // Console.WriteLine("\nChallenge 2: Object Swapper");
            // int num1 = 25, num2 = 30;
            // int num3 = 10, num4 = 30;
            // string str1 = "HelloWorld", str2 = "Programming";
            // string str3 = "Hi", str4 = "Programming";

            // SwapObjects(ref num1, ref num2); // Expected outcome: num1 = 30, num2 = 25  
            // SwapObjects(ref num3, ref num4); // Error: Value must be more than 18

            // SwapObjects(str1, str2); // Expected outcome: str1 = "Programming", str2 = "HelloWorld"
            // SwapObjects(str3, str4); // Error: Length must be more than 5

            // SwapObjects(true, false); // Error: Upsupported data type
            // SwapObjects(ref num1, str1); // Error: Objects must be of same types

            // Console.WriteLine($"Numbers: {num1}, {num2}");
            // Console.WriteLine($"Strings: {str1}, {str2}");

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
            catch (System.Exception)
            {

                throw;
            }
            
            // Challenge 4: Simple Word Reversal
            Console.WriteLine("\nChallenge 4: Simple Word Reversal");
            string sentence = "This is the original sentence!";
            string reversed = ReverseWords(sentence);
            Console.WriteLine(reversed); // Expected outcome: "sihT si eht lanigiro !ecnetnes"
        }
    }
}
