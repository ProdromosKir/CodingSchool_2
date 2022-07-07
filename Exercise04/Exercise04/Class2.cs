using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04
{
    public  class Class2
    {

        public void ComputingSumAndProduct()
        {
            Console.WriteLine("Give me an integer");
            int number = Convert.ToInt32(Console.ReadLine());
            ComputingProduct(number);
            ComputingSum(number);
        }
        public int ComputingSum(int number)
        {
           
            
            int sum = 0;
            while (number > 0)
            {
                sum += number;
                number--;
            }
            Console.WriteLine("Sum: " + sum);
            
            return sum;

           
        }

        public int ComputingProduct(int number)
        {

           
            int product = 1;
            while (number > 0)
            {
                product = product * number;
                number--;
            }
            Console.WriteLine("Product: "+product);
            return product;
        }
    }

    
}
