using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    class FizzBuzz
    {
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
