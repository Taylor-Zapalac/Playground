using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    class NextGreaterElement
    {
        /*
         * You are given two arrays (without duplicates) nums1 and nums2 where nums1’s elements are subset of nums2. Find all the next greater numbers for nums1's elements in the corresponding places of nums2.
         * 
         * The Next Greater Number of a number x in nums1 is the first greater number to its right in nums2. If it does not exist, output -1 for this number.
         */

        public int[] nge(int[] findNums, int[] nums)
        {
            int[] output = new int[findNums.Length];

            int index = 0;
            foreach(int i in findNums)
            {
                int compare = -1;
                for (int j = Array.IndexOf(nums, i); j < nums.Length; j++ )
                {
                    if (nums[j] > i) { compare = nums[j]; output[index] = compare; break; }
                }
                if (compare == -1) { output[index] = compare; }

                index++;

            }
            return output;
        }
    }
}
