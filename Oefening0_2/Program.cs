using Oefening0_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening0_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== LOOP NUMBERS ===");
            Console.WriteLine("\nStarting loop 1 with filtering.\nOnly print numbers divisible by 10:");
            Filters.Filters10(50, 150);
            Console.WriteLine("\nStarting loop 2 with filtering.\nOnly print numbers divisible by 3 & 5:");
            Filters.Filters3And5(50, 150);

            Console.ReadLine();
        }
    }
}
