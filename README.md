# Data type & function challeneges

## Challenge 1: String and Number Processor
- Objective: Create a function that processes a mix of string and number inputs.
- Description: Concatenate string inputs into a single sentence and sum up all number inputs. The function should print the final concatenated string and the sum of numbers.
- Test Case: StringNumberProcessor("Hello", 100, 200, "World")
- Expected Outcome: "Hello World; 300"
  
## Challenge 2: Object Swapper
- Objective: Write a function to swap two objects with specific conditions.
- Description: The function should only swap objects if they are of the same type. For strings, their lengths must be more than 5, and for numbers, they must be more than 18.
- Test Cases:
  - SwapObjects(ref num1, ref num2) with num1 = 25, num2 = 30 // Numbers after swap: 30, 25
  - SwapObjects(str1, str2) with str1 = "HelloWorld", str2 = "Programming" // Strings after swap: "Programming", "HelloWorld"
  - SwapObjects(ref num1, str 1) // Error: Objects must be of same types
  - SwapObjects(true, false) // Error: Unsuported type

## Challenge 3: Guessing Game
- Objective: Implement a number guessing game.
- Description: The function generates a random number and prompts the user to guess it. It provides feedback and continues until the correct guess is made.
- Execution: Uncomment GuessingGame() in Main to test.
- Expected Outcome: The game continues with user input until the correct number is guessed.

## Challenge 4: Simple Word Reversal
- Objective: Reverse each word in a given sentence.
- Description: The function takes a string and reverses each word in it. Words are separated by spaces, and punctuation remains attached to the word.
- Test Case: ReverseWords("This is the original sentence!")
- Expected Outcome: "sihT si eht lanigiro !ecnetnes"
