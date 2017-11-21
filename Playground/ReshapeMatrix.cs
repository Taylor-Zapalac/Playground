using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    class ReshapeMatrix
    {
        /*
         * You're given a matrix represented by a two-dimensional array, and two positive integers r and c representing the row number and column number of the wanted reshaped matrix, respectively.
         * The reshaped matrix need to be filled with all the elements of the original matrix in the same row-traversing order as they were.

         * If the 'reshape' operation with given parameters is possible and legal, output the new reshaped matrix; Otherwise, output the original matrix.
         * */

        public int[,] reshapeTheMatrix(int[,] nums, int r, int c)
        {
            int[,] shapedMatrix = new int[r, c];

            List<int> listOfNums = new List<int>();

            if ((nums.GetLength(0) * nums.GetLength(1) < (r * c))) { return nums;  }


            for(int i = 0; i < nums.GetLength(0); i++)
            {
                for(int j = 0; j < nums.GetLength(1); j++)
                {
                    listOfNums.Add(nums[i, j]);
                }
            }

            int index = 0;

            for (int x = 0; x < r; x++)
            {
                for (int y = 0;y  < c; y++)
                {
                    shapedMatrix[x, y] = listOfNums[index++];
                }
            }


            return shapedMatrix;
        }
    }
}
