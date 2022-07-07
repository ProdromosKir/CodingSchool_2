using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04
{
    public class Class5
    {
        public int[] SortIntArray(int[] AnArray)
        {
            Console.WriteLine("-----------------------------------");
            Array.Sort(AnArray);
            foreach (int i in AnArray)
            {
                Console.WriteLine($"{i}");
            }

            return AnArray;
        }
    }

    
}
