using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Exercise05
{
    internal class ActionResolver
    {
        public MessageLogger Logger { get; set; }  

        

        public void Execute(ActionRequest request)
        {
            ActionResponse response = null;

           switch(request.Action)
            {
                case ActionEnum.Convert:
                   response.Output = Convert(request.Input);
                    Logger.Write("Executing Convert");
                    break;
                case ActionEnum.Uppercase:
                   response.Output = Uppercase(request.Input);
                    Logger.Write("Executing Uppercase");
                    break;
                case ActionEnum.Reverse:
                    response.Output = Reverse(request.Input);
                    Logger.Write("Executing Reverse");
                    break;
                default:
                    //message
                    //Logger.Write();
                    Logger.Write("Error");
                    break;
            }
            
        }


        public string Convert(string input)
        {
           if(int.TryParse(input, out int result))
            {
                string binary = System.Convert.ToString(result,2);
                return binary;
            }
           else
            {
                Console.WriteLine("It is not decimal");
                return null;
            }
        }

        public string Uppercase(string phrase)
        {
            string[] words = phrase.Split(' ');

            int index = 0;
            int i = 0;
            foreach (var word in words)
            {
                int length = words[0].Length;

                if (length < words[i].Length)
                {
                    index = i;
                }
                i++;
            }
            string longestWord = words[index];
            return longestWord.ToUpper();
        }

        public string Reverse(string input)
        {
            if(input is string)
            {
                char[] charArray = input.ToCharArray();
                Array.Reverse(charArray);
                string reversedString = new string(charArray);
                Console.WriteLine(reversedString);
                return reversedString;
            }

            return null;

        }
    }
}
