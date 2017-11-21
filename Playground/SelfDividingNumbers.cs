using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    class SelfDividingNumbers
    {
        /*
         * A self-dividing number is a number that is divisible by every digit it contains.
         * 
         * For example, 128 is a self-dividing number because 128 % 1 == 0, 128 % 2 == 0, and 128 % 8 == 0.
         * 
         * Also, a self-dividing number is not allowed to contain the digit zero.
         * 
         * Given a lower and upper number bound, output a list of every possible self dividing number, including the bounds if possible.
         */
        public List<int> isSelfDividing(int left, int right)
        {
            List<int> output = new List<int>();

            for (int i = left; i <= right; i++)
            {
                Char[] temp = i.ToString().ToCharArray();
                int leftovers = 0;
                foreach(char num in temp)
                {
                    if (Int32.Parse(num.ToString()) == 0) { leftovers++; break; }
                    int mod = i % Int32.Parse(num.ToString());
                    leftovers += mod;
                }
                if (leftovers == 0) { output.Add(i);}
                
            }

            return output;
        }
    }
}
