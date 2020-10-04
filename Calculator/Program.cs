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

            //*Hint*
            Console.WriteLine("Type a number, and then press Enter: ");
            numInput1 = Console.ReadLine();


            //Ask the user to type the second number.
            //Ask the user to the user to choose an operator.
            //If a non-numeric is entered add try/catch block to handle the exception.
            //Use a switch statement to do the calculations
            //Wait for the user to respond before closing.

            Console.WriteLine("\nFinished");
        }


    }
}