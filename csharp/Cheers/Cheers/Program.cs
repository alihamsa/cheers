using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your name");
            var name = Console.ReadLine();

            char[] NewName = name.ToCharArray();
            char[] consonant = "halfnorsemix".ToCharArray();

            foreach (char TempVar in NewName)
            {
                if (consonant.Contains(TempVar))
                {
                    Console.WriteLine("give me an " + TempVar);
                }
                else
                {
                    Console.WriteLine("give me a " + TempVar);
                }

                //Console.WriteLine(TempVar + " is grand");
            }
            Console.WriteLine(name + " is grand");









        }
    }
}
