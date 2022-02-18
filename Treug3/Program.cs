using System;

namespace Treug3
{
    internal class Treug3
    {
        
        static void Main(string[] args)
        {  {
                 int A = Convert.ToInt32 (args[0]);
                 int B = Convert.ToInt32(args[1]);
                if (A.ToString().Length > B.ToString().Length)
                {
                    Console.WriteLine("Число A > B ");
                }
                else
                {
                    Console.WriteLine("Число B > A ");
                }
            }
        }
    }
}
