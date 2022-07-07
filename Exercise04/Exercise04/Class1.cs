using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04
{
    public class Class1
    {
        public Class1()
        {
           
        }

      public string ReverseString(string s)
        {
            
           

            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            string reversedString = new string(charArray);
            Console.WriteLine(reversedString);
            return reversedString;
        }
    }
}
