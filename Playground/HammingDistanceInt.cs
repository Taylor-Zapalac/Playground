using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    class HammingDistanceInt
    {

        /*
         * The Hamming distance between two integers is the number of positions at which the corresponding bits are different.
         * 
         * Given two integers x and y, calculate the Hamming distance.
         * 
         * Input: x = 1, y = 4
         * 
         * Output: 2
         * 
         * Explanation:
         * 1   (0 0 0 1)
         * 4   (0 1 0 0)
         *        ↑   ↑
         *        
         * The above arrows point to positions where the corresponding bits are different.
         */


        public int hammingDistance(int x, int y)
        {
            int value = x ^ y;
            int distance = 0;

            //First I want to get the binary representation and print it... Just for myself.
            String binaryX = Convert.ToString(x, 2).PadLeft(6, '0');
            String binaryY = Convert.ToString(y, 2).PadLeft(6, '0');
            String binaryValue = Convert.ToString(value, 2).PadLeft(6, '0');

            Console.WriteLine("Binary x: \t" + binaryX);
            Console.WriteLine("Binary y: \t" + binaryY);
            Console.WriteLine(x + " ^ " + y + " = \t" + binaryValue);

            while (value != 0)
            {
                Console.WriteLine(value + " in binary is: \t" + Convert.ToString(value, 2).PadLeft(6, '0'));
                if (value % 2 != 0) distance++;
                value >>= 1;

            }

            return distance; ;
        }
    }
}