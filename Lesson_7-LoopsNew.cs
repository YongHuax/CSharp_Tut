//Easier way to increment is to put var++ in loop condition , Example code 

using System;


namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            while(++num < 6) 
                Console.WriteLine(num);
        }
    }
}
