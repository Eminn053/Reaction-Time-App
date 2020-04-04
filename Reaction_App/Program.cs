using System;
using System.Threading;

namespace Reaction_App
{
    class Program
    {
        static void react()
        {

            Console.WriteLine("Press A");

            //The time user presses a will be saved for comparison. 
            if(Console.ReadLine() == "a")
            { 
                //The calculation will go here.(I don't know how to calculate reaction time)

                Console.Write("You pressed A");

            }
            Thread.Sleep(500);

            for (int  i=0;i<=100;i+=2)//This is just for testing purposes.
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {

            //Basic functions go here.
            int MillisecondsTimeout = 2300;
            Console.WriteLine("Welcome to Reaction tester.");
            Console.WriteLine("Rules:");
            Console.WriteLine("1-Press A as soon as you see the word 'Press A'");
            Console.WriteLine("2-Don'press out of memory.Press as you see the prompt");
            Thread.Sleep(MillisecondsTimeout);
            react();

            
        }
    }
}
