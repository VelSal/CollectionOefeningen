using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening0_2.Models
{
    public static class Filters
    {
        public static void Filters10(int begin, int end)
        {
            List<int> ints = new List<int>();
            for (int i = begin; i <= end; i++)
            {
                if (i % 10 == 0)
                {
                    ints.Add(i);
                }
            }

            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }
        }
        public static void Filters3And5(int begin, int end)
        {
            List<int> ints = new List<int>();
            for (int i = begin; i <= end; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    ints.Add(i);
                }
            }

            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }
        }

        
    }
}
