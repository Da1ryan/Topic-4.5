using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Topic_4._5
{
    internal class Program
    {

        

        static void Main(string[] args)
        {
            ASCII art1 = new ASCII();
            ASCII art2 = new ASCII();
            ASCII art3 = new ASCII();

            Console.WriteLine("Press ENTER for a joke");
            Console.ReadLine();
            Joke(numBugs);

            





        } 
        public static void Joke(int numBugs)
        {
            Console.WriteLine(numBugs + " little bugs in the code");
            Thread.Sleep(500);
            Console.WriteLine(numBugs + " little bugs.");
            Thread.Sleep(500);
            Console.WriteLine(" Fix a bug, run it again,");
            Thread.Sleep(500);
            Console.WriteLine((++numBugs) + " little bugs in the code.");
        }


    }

}
