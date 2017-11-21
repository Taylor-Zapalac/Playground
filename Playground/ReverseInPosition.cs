using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    class ReverseInPosition
    {
        /*
         * Given a string, you need to reverse the order of characters in each word within a sentence while still preserving whitespace and initial word order.
         */

        public String reverseInPosition(String s)
        {
            String[] work = s.Split(' ');
            String results = "";

            foreach(String st in work)
            {
                results = results +" "+ reverseWord(st);
            }
            


            return results;
        }
        public String reverseWord(String s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
