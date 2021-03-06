﻿using System;


namespace Calculator
{
    class Program
    {
       
        static void Main(string[] args){

            //Display title as the Calculator App.
                // does "title" mean to just print this to the terminal window?

            //Declare 3 variables and set to empty.
            //*Hint* 
            string stringInput1, stringInput2; // don't need stringResult, right?  stringResult;
            stringInput1 = stringInput2 = ""; // don't need stringResult? stringResult = "";



            //Ask the user to type the first number
            stringInput1 = GetStringFromUser_withMessage("Type a number, and then press Enter: ");



            //Ask the user to type the second number.
            stringInput2 = GetStringFromUser_withMessage("Type a number, and then press Enter: ");


            //Ask the user to the user to choose an operator.
            string operation = GetStringFromUser_withMessage("Choose an operator (+  -  /  *): ");


            // to convert string inputs to integer values
            int integerInput1, integerInput2, intResult;
            //If a non-numeric is entered add try/catch block to handle the exception.
            integerInput1 = TryToConvertToInt(stringInput1);
            integerInput2 = TryToConvertToInt(stringInput2);
            intResult = 0; // just to assign it to something



            //Use a switch statement to do the calculations
            // possible operators:
            const string addition = "+";
            const string subtraction = "-";
            const string division = "/";
            const string multiplication = "*";

            switch (operation)
            {
                case addition:
                    //TODO
                    break;
                case subtraction:
                    intResult = integerInput1 - integerInput2;
                    break;
                case division:
                    intResult = integerInput1 / integerInput2;
                    break;
                case multiplication:
                    //TODO
                    break;
                default:
                    intResult = 0; //I guess?
                    break;
            }

            //Wait for the user to respond before closing.
            // TODO


            // Display the result of the operation
            Console.WriteLine($"{integerInput1} {operation} {integerInput2} = {intResult}");

        } // (end of Main method)


        // (Begin helper methods)


        /*
         * Tries to parse an integer from the input string
         * Prints an error message if the input is not able to be parsed
         * Asks the user to try again until valid input (integer) is provided
         */
        private static int TryToConvertToInt(string stringInput)
        {
            int convertedInteger;
            try
            {
                convertedInteger = int.Parse(stringInput);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Sorry... {ex.Message}");

                string tryAgain = GetStringFromUser_withMessage($"{stringInput} is not an INTEGER! Try again: ");

                convertedInteger = TryToConvertToInt(tryAgain);
            }
            return convertedInteger;
        }


        /*
         * This is to streamline the message/input process
         */
        static string GetStringFromUser_withMessage(string message)
        {
            Console.WriteLine(message);
            string userInput = Console.ReadLine();
            return userInput;
        }


    }
}
