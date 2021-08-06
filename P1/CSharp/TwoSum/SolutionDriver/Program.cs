using System;

namespace SolutionDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Driver...");

            var sln = new Solution();

            var solutionArr = sln.TwoSum(new[] {2, 7, 11, 15}, 9);
            WriteSolution(new[] {2, 7, 11, 15}, solutionArr, 9);
            solutionArr = sln.TwoSum(new[] {3, 2, 4}, 6);
            WriteSolution(new[] {3, 2, 4}, solutionArr, 6);
            solutionArr = sln.TwoSum(new[] {3, 3}, 6);
            WriteSolution(new[] {3, 3}, solutionArr, 6);
        }

        static void WriteSolution(int[] startArray, int[] solution, int target)
        {
            Console.Write("| Start Array: {");
            foreach (var start in startArray)
            {
                Console.Write(start + ", ");
            }
            Console.Write("}");
            Console.Write(" | Solution Array: {");
            foreach (var sln in solution)
            {
                Console.Write(sln + ", ");
            }
            Console.Write("}");
            Console.Write("| Target: " + target + " |\n");
        }
    }

    public class Solution {
        //O(n^2) Solution - Brute force.
        public int[] TwoSum(int[] nums, int target) {
        
            //Start
            var solution = new [] { 0, 0 };


            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = 0; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target && i != j)
                    {
                        solution[0] = j;
                        solution[1] = i;
                    }
                }
            }

            return solution;
        }
    }
}
