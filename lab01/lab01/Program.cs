using System;

namespace lab01
{
    class InvalidNumberException : Exception
    {
        public InvalidNumberException(string message) : base(message)
        {
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome to my game! Let's do some math!\n\n");
                StartSequence();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Program is completed.");
            }
        }

        static void StartSequence()
        {
            Console.WriteLine("Please enter a number greater than zero\n");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[size];

            numbers = Populate(numbers);
            int sum = GetSum(numbers);

            int product;
            int selectedIndex;
            product = GetProduct(numbers, sum, out selectedIndex);

            decimal quotient;
            decimal selecteddividend;
            quotient = GetQuotient(product, out selecteddividend);

            Console.WriteLine($"Your array is size: {numbers.Length}");
            Console.WriteLine($"Numbers in the array are {string.Join(", ", numbers)}");
            Console.WriteLine($"The sum of the array is {sum}");
            Console.WriteLine($"{sum} *  {numbers[selectedIndex - 1]} = {product}");
            Console.WriteLine($"{product} / {selecteddividend} = {quotient}");
        }

        static int[] Populate(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Please enter number: {i + 1} of {numbers.Length} \n");
                int inputNumber;
                if (!int.TryParse(Console.ReadLine(), out inputNumber))
                {
                    throw new InvalidNumberException("Invalid number entered.");
                }
                numbers[i] = inputNumber;
            }
            return numbers;
        }

        static int GetSum(int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            if (sum < 20)
            {
                throw new Exception($"Value of {sum} is too low");
            }
            return sum;
        }

        static int GetProduct(int[] numbers, int sum, out int index)
        {
            Console.Write($"Please select a random number between 1 and {numbers.Length} \n");
            index = Convert.ToInt32(Console.ReadLine());

            if (index < 1 || index > numbers.Length)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }

            int product = sum * numbers[index - 1];
            return product;
        }

        static decimal GetQuotient(int product, out decimal dividend)
        {
            Console.Write($"Please enter a number to divide your {product} by\n ");
            dividend = Convert.ToDecimal(Console.ReadLine());

            if (dividend == 0)
            {
                Console.WriteLine("Divide by zero exception occurred");
                return 0;
            }

            decimal quotient = decimal.Divide(product, dividend);
            return quotient;
        }
    }
}