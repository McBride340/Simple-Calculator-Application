﻿using System;


namespace Calculator
{
    class Program
    {
       
        static void Main(string[] args){
            
            /// Example to get you started,
            /// Remove the following code below after you run the app to ensure it works.
            
            int a = 49;
            int b = 22;
            int c = a + b;
            Console.WriteLine(c);
            Console.ReadKey();


            //Display title as the Calculator App.

            //Declare 3 variables and set to empty.

            //*Hint* numInput1= ; numInput2= ; result = ;
            //String numbInput1 = "";
            
            float numInput1;
            float numInput2;
            float result;
            String numbInput1 = "";



            //Ask the user to type the first number

            //*Hint*
            //Console.WriteLine("Type a number, and then press Enter: ");
            //inputNumb1 = Console.ReadLine();
            
            Console.WriteLine("Type a number, and then press Enter: ");
            numInput1 = Console.ReadLine();


            //Ask the user to type the second number.
            
            Console.WriteLine("Type another number, and then press Enter: ");
            numInput2 = Console.ReadLine();
            
            //Ask the user to the user to choose an operator.
            //If a non numeric is entered add try/catch block to handle the exception.
            
            Console.WriteLine("Type your opperator (+ - * /), and then press Enter: ");
            numbInput1 = Console.ReadLine();
            while(numbInput1 != "+" or numbInput1 != "-" or numbInput1 != "*" or numbInput1 != "/"){
                Console.WriteLine("Error: Invalid input");
                Console.WriteLine("Type your opperator (+ - * /), and then press Enter: ");
                numbInput1 = Console.ReadLine();
            }
            
            //Use a switch statement to do the calculations
            
            
            
            //Wait for the user to respond before closing.


        }


    }
}
