using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04
{
    public  class Class4
    {
        public int[] Multiply2Arrays(int[] Array1,int[] Array2)
        {

            Console.WriteLine("-----------------------------------");

            int length = Array1.Length * Array2.Length;
            int k = 0;


            int[] Array3 = new int[length];


            for (int i = 0; i < Array1.Length; i++)
            {
                for (int j = 0; j < Array2.Length; j++)
                {
                    Array3[k] = Array1[i] * Array2[j];
                    Console.WriteLine(Array3[k]);
                    k++;

                }
            }

            return Array3;
        }
    }

    
}
