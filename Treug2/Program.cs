using System;
namespace Treug2
{
    internal class Treug2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AB = " + args[0]);
            double AB = Convert.ToDouble(args[0]);
            Console.WriteLine("AC = " + args[1]);
            double AC = Convert.ToDouble(args[1]);
            Console.WriteLine("CD = " + args[2]);
            double DC = Convert.ToDouble(args[2]);
            double P = AB + AC + DC;
            Console.WriteLine("P = " + P);
        }
    }
}

