using System;
using System.Collections.Generic;

namespace MinDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sln = new Solution();
            sln.MinDifference(new[] {5, 3, 2, 4});
            sln.MinDifference(new[] {1, 5, 0, 10, 14});
            sln.MinDifference(new[] {6, 6, 0, 1, 1, 4, 6});
            sln.MinDifference(new[] {1, 5, 6, 14, 15});
        }
    }

    public class Solution {
        public int MinDifference(int[] nums) 
        {
            // In this case we can just return 0.
            if (nums.Length < 5) return 0;

            //Small -> Large
            int[] smallestIndex = new int[] { nums[0], nums[1], nums[2] };
            //Large -> Small
            int[] largestIndex = new int[] { nums[0], nums[1], nums[2] };

            SortSmallest(smallestIndex);
            SortLargest(largestIndex);

            for (int i = 0; i < nums.Length; i++)
            {
                //Check nums[i] for smallest
                if (expr)
                {
                    
                }
                //Check nums[i] for largest
                if (expr)
                {
                    
                }
                
            }


        }

        private void SortLargest(int[] largestIndex)
        {
            int temp;
            //Sort smallest index largest to smallest.
            if (largestIndex[0] < largestIndex[1])
            {
                temp = largestIndex[0];
                largestIndex[0] = largestIndex[1];
                largestIndex[1] = temp;
            }
            if (largestIndex[1] < largestIndex[2])
            {
                temp = largestIndex[1];
                largestIndex[1] = largestIndex[2];
                largestIndex[2] = temp;
            }
            if (largestIndex[0] < largestIndex[1])
            {
                temp = largestIndex[0];
                largestIndex[0] = largestIndex[1];
                largestIndex[1] = temp;
            }
        }

        private static void SortSmallest(int[] smallestIndex)
        {
            int temp;
            //Sort smallest index smallest to largest.
            if (smallestIndex[0] > smallestIndex[1])
            {
                temp = smallestIndex[0];
                smallestIndex[0] = smallestIndex[1];
                smallestIndex[1] = temp;
            }

            if (smallestIndex[1] > smallestIndex[2])
            {
                temp = smallestIndex[1];
                smallestIndex[1] = smallestIndex[2];
                smallestIndex[2] = temp;
            }

            if (smallestIndex[0] > smallestIndex[1])
            {
                temp = smallestIndex[0];
                smallestIndex[0] = smallestIndex[1];
                smallestIndex[1] = temp;
            }
        }

        private int FindDiff(int[] nums)
        {
            int min = nums[0];
            int max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }

                if (nums[i] < min)
                {
                    min = nums[i];
                }
            }

            return max - min;
        }
    }
}
