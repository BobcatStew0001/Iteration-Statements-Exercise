using System;
using System.Linq;

namespace IterationStatements
{
    public class Program
    {
        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        //    - Method Signature: void PrintNumbers()
        public static void PrintNumbers()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        // 2. Write a method that prints every third number from 3 to 999 to the console.
        //    - Method Signature: void PrintEveryThirdNumber()
        public static void PrintEveryThirdNumber()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        //    - Method Signature: bool AreNumbersEqual(int num1, int num2)
        //    - Returns true if the numbers are equal, false otherwise.
        public static bool AreNumbersEqual(int num1, int num2)
        {
            if (num1 == num2)
            {
                return true;
            }
            else
            {
                return false; 

            }
        }

        // 4. Write a method that checks if a given number is even or odd.
        //    - Method Signature: bool IsEven(int number)
        //    - Returns true if the number is even, false if odd.
        public static bool IsEven(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            else
            {
               return  false;
            }
        }
    




    // 5. Write a method that checks if a given number is positive or negative.
        //    - Method Signature: bool IsPositive(int number)
        //    - Returns true if the number is positive, false if negative.
        public static bool IsPositive(int num)
        {
            if (num > 0)
            {
                return true;
            }
            
            else
            {
                return false;
            }

       
        }

        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        //    - Method Signature: bool CanVote(int age)
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.
        public static bool CanVote(int age)
        {
            Console.WriteLine("Please enter your age");
            var isValid = int.TryParse(Console.ReadLine(), out int userAge);

            while (isValid == false)
            {
                Console.WriteLine("Please enter your age");
                isValid = int.TryParse(Console.ReadLine(), out  userAge);
            }

            if (userAge >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        //    - Method Signature: bool IsInRange(int number)
        //    - Returns true if the number is within the range, false otherwise.
        public static bool IsInRange(int number)
        {
            if (number >= -10 && number <= 10)
            {
                return true;
            }
            return false;
        }

        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"
        public static void DisplayMultiplicationTable(int number)
        {
            var numbers = Enumerable.Range(1, 12);
            foreach (var num in numbers)
            {
                Console.WriteLine($"{num} * {number} = {num * number}");
            }
        }

            // In the Main method below, call each of your methods to test them.
            // Use various test cases to ensure they work as expected.
            static void Main(string[] args)
            {
                
            
            
                // Testing AreNumbersEqual
                bool equals = AreNumbersEqual(2,2); //Expected true
                Console.WriteLine(equals);
                bool equals2 = AreNumbersEqual(8, 3); //Expected false
                Console.WriteLine(equals2);
                //Testing IsEven
               bool results = IsEven(9); //Expected false
               Console.WriteLine(results);
               bool results2 = IsEven(10); // Expected true
               Console.WriteLine(results2);
                //Testing IsPositive 
                //IsPositive(8); //Expected true 
                //IsPositive(-10); //Expected false
                //IsPositive(0); //Expected false
                //Testing CanVote
               

                //Testing IsInRange
                /*Console.WriteLine("Please enter a number to check if it's between -10 and 10:");
                bool isNumber = int.TryParse(Console.ReadLine(), out int userInput);

                if (isNumber)
                {
                    bool inRange = IsInRange(userInput);
                    Console.WriteLine($"{userInput} is in range: {inRange}");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                }
                

                //Testing DisplayMultiplicationTable
                Console.WriteLine("DisplayMultiplicationTable for 5:");
                DisplayMultiplicationTable(5); //Should return the multiplication table for 5 * 1-12
                Console.WriteLine("DisplayMultiplicationTable for 8:");
                DisplayMultiplicationTable(8); //Should return the multiplication table for 8 * 1-12
                // PrintNumbers();
                // PrintEveryThirdNumber();*//**/
            }

        
    }
}