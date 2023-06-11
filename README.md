# Lab01-Numbers Game

## Purpose
The Numbers Game is a math game program that takes user input, performs calculations, and demonstrates error handling. It allows users to input a sequence of numbers, calculates the sum, product, and quotient, and displays the results.

## How to Run the Program
To run the program, follow the steps below:

1. Ensure that you have the .NET Core runtime installed on your machine.
2. Download or clone the project repository to your local machine.
3. Open a command-line interface (e.g., Command Prompt, Terminal).
4. Navigate to the project's root directory.
5. Run the program by running the following command: `dotnet run`
6. Follow the prompts displayed in the console to interact with the program.
7. Review the results and any error messages that may appear.

## Program Description
The Numbers Game program consists of several methods to perform different tasks:

- `Main` method: The entry point of the program. It calls the `StartSequence` method and handles exceptions.
- `StartSequence` method: Prompts the user to enter a number, creates an array based on the input, calls other methods to populate the array and perform calculations, and displays the results.
- `Populate` method: Takes an integer array as input and prompts the user to input values for each element in the array.
- `GetSum` method: Calculates the sum of all the numbers in the array and throws a custom exception if the sum is less than 20.
- `GetProduct` method: Multiplies the sum by a randomly selected element in the array and returns the product.
- `GetQuotient` method: Prompts the user to input a number to divide the product by, calculates the quotient, and handles the divide-by-zero exception.

## Visual Representation
When you run the program, it will display prompts and messages in the console, allowing you to input numbers and view the calculated results. Here's an example of how the program will look in the console:

---

Welcome to my game! Let's do some math!


Please enter a number greater than zero

6


Please enter number: 1 of 6


10


Please enter number: 2 of 6


6


Please enter number: 3 of 6


4


Please enter number: 4 of 6


9


Please enter number: 5 of 6


8


Please enter number: 6 of 6


7


Please select a random number between 1 and 6


3


Please enter a number to divide your 176 by


 20
 
 
Your array is size: 6


Numbers in the array are 10, 6, 4, 9, 8, 7


The sum of the array is 44


44 *  4 = 176


176 / 20 = 8.8


Program is completed.

---


Finally, feel free to explore and enjoy playing the Numbers Game!




