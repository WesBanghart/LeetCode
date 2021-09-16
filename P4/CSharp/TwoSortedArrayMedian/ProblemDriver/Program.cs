using System;
using System.Linq;

namespace ProblemDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 4 Driver.");
            var input11 = new [] {1, 3};
            var input12 = new [] {2};
            var input21 = new [] {1, 2};
            var input22 = new [] {3, 4};
            var input31 = new [] {0, 0};
            var input32 = new [] {0, 0};
            var input41 = Array.Empty<int>();
            var input42 = new [] {1};
            var input51 = new [] {2};
            var input52 = Array.Empty<int>();

            var input61 = new[] {4, 7, 10};
            var input62 = new[] {1, 2, 3};

            var input71 = new[] {1};
            var input72 = new[] {2, 3};

            var sln = new Solution();
            double result;

            //result = sln.FindMedianSortedArrays(input11, input12);
            //Console.WriteLine($"Input: nums1 = [{string.Join(", ", input11)}], nums2 = [{string.Join(", ", input12)}]");
            //Console.WriteLine($"Output: {result}");

            //result = sln.FindMedianSortedArrays(input21, input22);
            //Console.WriteLine($"Input: nums1 = [{string.Join(", ", input21)}], nums2 = [{string.Join(", ", input22)}]");
            //Console.WriteLine($"Output: {result}");

            //result = sln.FindMedianSortedArrays(input31, input32);
            //Console.WriteLine($"Input: nums1 = [{string.Join(", ", input31)}], nums2 = [{string.Join(", ", input32)}]");
            //Console.WriteLine($"Output: {result}");

            result = sln.FindMedianSortedArrays(input41, input42);
            Console.WriteLine($"Input: nums1 = [{string.Join(", ", input41)}], nums2 = [{string.Join(", ", input42)}]");
            Console.WriteLine($"Output: {result}");

            result = sln.FindMedianSortedArrays(input51, input52);
            Console.WriteLine($"Input: nums1 = [{string.Join(", ", input51)}], nums2 = [{string.Join(", ", input52)}]");
            Console.WriteLine($"Output: {result}");

            result = sln.FindMedianSortedArrays(input61, input62);
            Console.WriteLine($"Input: nums1 = [{string.Join(", ", input61)}], nums2 = [{string.Join(", ", input62)}]");
            Console.WriteLine($"Output: {result}");

            result = sln.FindMedianSortedArrays(input71, input72);
            Console.WriteLine($"Input: nums1 = [{string.Join(", ", input71)}], nums2 = [{string.Join(", ", input72)}]");
            Console.WriteLine($"Output: {result}");
        }
    }

    public class Solution {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {

            if (nums1.Length > 0 && nums2.Length > 0)
            {
                // In this case the last element of nums1 is greater than the first element of nums2
                if (nums1[nums1.Length - 1] > nums2[0])
                {
                    var tempNum1 = new int[nums1.Length + 1];
                    var tempNum2 = new int[nums2.Length - 1];
                    for (var i = 0; i < nums1.Length; i++)
                    {
                        if (nums1[i] > nums2[0])
                        {
                            //Insert nums2[0] at nums1[i]
                            tempNum1[i] = nums2[0];
                            //Append the rest and break out of the loop
                            for (var j = i + 1; j <= nums1.Length; j++)
                            {
                                tempNum1[j] = nums1[j - 1];
                            }
                            break;
                        }
                        tempNum1[i] = nums1[i];
                    }

                    for (int i = 1; i < nums2.Length; i++)
                    {
                        tempNum2[i - 1] = nums2[i];
                    }

                    return FindMedianSortedArrays(tempNum1, tempNum2);
                }
            }
            

            var totalLength = nums1.Length + nums2.Length;

            if (totalLength % 2 == 0)
            {
                double answer;
                if (nums1.Length == 0)
                {
                    answer = ((double)nums2[(nums2.Length / 2) -1] + nums2[nums2.Length / 2]) / 2;
                }

                else if (nums2.Length == 0) 
                {
                    answer = ((double)nums1[(nums1.Length / 2) -1] + nums1[nums1.Length / 2]) / 2;
                }
                else
                {
                    if (nums1.Length > nums2.Length)
                    {
                        answer = ((double)nums1[totalLength / 2 - 1] + nums1[totalLength/2]) / 2;
                    }
                    else if (nums1.Length < nums2.Length)
                    {
                        answer = ((double)nums2[totalLength / 2 - 1] + nums2[totalLength/2]) / 2;
                    }
                    else
                    {
                        answer = ((double)nums1[nums1.Length - 1] + nums2[0]) / 2;
                    }
                }
                return answer;
            }

            if (nums1.Length > nums2.Length)
            {
                return nums1[totalLength / 2];
            }

            if (nums1.Length < nums2.Length)
            {
                if (nums2.Length == 1)
                {
                    return nums2[totalLength / 2];
                }
                return nums2[totalLength / 2 - 1];
            }

            return -1;
        }
    }
}
