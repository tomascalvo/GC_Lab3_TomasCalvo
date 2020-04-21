using System;

namespace GC_Lab3_TomasCalvo
{
    class Program
    {
        static void Main(string[] args)
        {
            // WELCOME MESSAGE
            Console.WriteLine("Decision Maker online.");

            //INPUT USERNAME
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Welcome to Decision Maker, {userName}.");

            //BEGIN PROGRAM LOOP
            bool programComplete = false;
            while (programComplete == false)
            {

                //VALIDATE USER INPUT
                string validationMessage = $"Please enter an integer between 1 and 100, {userName}.";
                string userInput;
                int parsedInput;
                Console.WriteLine(validationMessage);
                userInput = Console.ReadLine();
                parsedInput = int.Parse(userInput);
                bool validation = false;
                while (validation == false)
                {
                    if (parsedInput >= 1 && parsedInput <= 100)
                    {
                        validation = true;
                    }
                    else {
                        validation = false;
                        Console.WriteLine($"Invalid entry. {validationMessage}");
                        userInput = Console.ReadLine();
                        parsedInput = int.Parse(userInput);
                    }
                }

                //PROCESS INPUT
                bool isOdd = parsedInput % 2 == 1;
                bool range2to25 = parsedInput >= 2 && parsedInput <= 25;
                bool range26to60 = parsedInput >= 26 && parsedInput <= 60;
                bool rangeOver60 = parsedInput > 60;

                //PRINT RESULTS
                if (isOdd)
                {
                    Console.WriteLine($"{parsedInput} Odd.");
                } else if (!isOdd && range2to25)
                {
                    Console.WriteLine("Even and less than 25.");
                } else if (!isOdd && range26to60) {
                    Console.WriteLine("Even.");
                }
                else if (!isOdd && rangeOver60)
                {
                    Console.WriteLine($"{parsedInput} Even.");
                } else
                {
                    Console.WriteLine($"Invalid input. {validationMessage}");
                }

                //REPEAT OR COMPLETE PROGRAM
                string completionQuery = $"Would you like to make another decision, {userName}?";
                bool queryAnswered = false;
                while (!queryAnswered)
                {
                    Console.WriteLine(completionQuery);
                    string completionResponse = Console.ReadLine();
                    string lowerResponse = completionResponse.ToLower();
                    if (lowerResponse == "y" || lowerResponse == "yes")
                    {
                        queryAnswered = true;
                        programComplete = false;
                    } else if (lowerResponse == "n" || lowerResponse == "no")
                    {
                        queryAnswered = true;
                        programComplete = true;
                    } else /*VALIDATE USER INPUT*/
                    {
                        queryAnswered = false;
                        Console.WriteLine("I'm not sure what you mean.");
                    }
                }
            }

            Console.WriteLine($"Thank you for using Decision Maker, {userName}.");

        }
    }
}
