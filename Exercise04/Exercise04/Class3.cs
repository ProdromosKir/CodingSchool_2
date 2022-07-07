using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04
{
    internal class Class3
    {

        public void FindPrimes()
        {
            Console.WriteLine("Give a number");
            int number = Convert.ToInt32(Console.ReadLine());
            int m = number/2;
            bool flag = true;

            for (int i = 2; i < m; i++)
            {
                if(number%i==0)
                {
                    flag = false;
                    Console.WriteLine("Number " + number + " is not prime");
                    break;
                }
                

               
            }

            if(flag)
                Console.WriteLine("Number "+number+" is prime");


        }
    }
}
