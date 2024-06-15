using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Input_Output
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Name:");
            string name = Console.ReadLine();
            Console.WriteLine($"Your Name is {name}");
        }
    }
}
