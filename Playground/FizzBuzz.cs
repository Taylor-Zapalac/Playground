using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    class FizzBuzz
    {
        /*
         * Write a program that outputs the string representation of numbers from 1 to n.
         * 
         * But for multiples of three it should output “Fizz” instead of the number and for the multiples of five output “Buzz”. 
         * For numbers which are multiples of both three and five output “FizzBuzz”.
         * 
         */


        public IList<string> FizzBuzz(int n)
        {
            List<String> output = new List<String>();
            String temp = "";

            for(int i = 1; i <= n; i++)
            {
                if(i%3 == 0)
                {
                    temp = temp + "Fizz";
                }
                if(i%5 == 0)
                {
                    temp = temp + "Buzz";
                }
                if(temp.Equals(""))
                {
                    temp = i.ToString();
                }
                output.Add(temp);
                temp = "";
            }

            return output;


        }
    }
}
