using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    /// <summary>
    /// Takes in array of ints.
    /// SOrts, then pairs  them, getting the min value of pair
    /// Adds up the mins to a resulting total.
    /// </summary>
    class SumArrayPairs
    {
        public int ArrayPairSum(int[] nums)
        {
            Array.Sort(nums);
            int total = 0;

            for(int i = 0; i < nums.Length; i += 2)
            {
                try {
                    total += Math.Min(nums[i], nums[i + 1]);
                }
                catch(Exception e)
                {
                    total += nums[i];
                }
            }

            return total;
        }
    }
}
