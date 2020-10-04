using System;


namespace Calculator
{
    class Program
    {
       
        static void Main(string[] args){

            //Display title as the Calculator App.
                // does "title" mean to just print this to the terminal window?

            //Declare 3 variables and set to empty.
            //*Hint* 
            string numInput1, numInput2, result;
            numInput1 = numInput2 = result = "";



            //Ask the user to type the first number
            numInput1 = GetStringFromUser_withMessage("Type a number, and then press Enter: ");



            //Ask the user to type the second number.
            numInput2 = GetStringFromUser_withMessage("Type a number, and then press Enter: ");


            //Ask the user to the user to choose an operator.
            string operation = GetStringFromUser_withMessage("Choose an operator (+  -  /  *): ");



            //If a non-numeric is entered add try/catch block to handle the exception.



            //Use a switch statement to do the calculations
            // possible operators
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
                    break;
                case division:
                    //TODO
                    break;
                case multiplication:
                    //TODO
                    break;
                default:
                    result = "0"; //I guess?
                    break;
            }

            //Wait for the user to respond before closing.
            // TODO



            // just to indicate that the application has finished
            Console.WriteLine("\nFinished");
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
