//Q. (User Input) Create a CS program that Requests User Input ,  Accept User Input and Prints it 

using System;

namespace ConsoleAppsbasic
{
    class Program
    {
        static void Main(string[] args)
        {
            string userRequest = " Please enter a number and press enter ";
            Console.WriteLine(userRequest);

            string userInput = Console.ReadLine();

            string printUserInput = " the variable is ";
            Console.Write(printUserInput);
            Console.WriteLine(userInput);
            Console.Read();
        }
    }
}


// O/P : 1 . Please enter a number and press enter , 2. <Enter> Number 3. the variable is number entered in 2 
