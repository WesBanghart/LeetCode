using System;

namespace ProblemDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = "abcabcbb";
            var s2 = "bbbbb";
            var s3 = "pwwkew";
            var s4 = "abcasdfe";

            var sln = new Solution();

            Console.WriteLine("Problem 3 driver.");

            var answer = sln.LengthOfLongestSubstring(s1);
            Console.WriteLine($"String Input: {s1}. Answer: {answer}");
            answer = sln.LengthOfLongestSubstring(s2);
            Console.WriteLine($"String Input: {s2}. Answer: {answer}");
            answer = sln.LengthOfLongestSubstring(s3);
            Console.WriteLine($"String Input: {s3}. Answer: {answer}");
            answer = sln.LengthOfLongestSubstring(s4);
            Console.WriteLine($"String Input: {s4}. Answer: {answer}");
        }
    }

    public class Solution {
        //Brute force
        public int LengthOfLongestSubstring(string s)
        {
            var longestSubstring = 0;
            for (var i = 0; i < s.Length; i++)
            {
                var count = 1;
                for (var j = i + 1; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        break;
                    }
                    count++;
                }

                if (longestSubstring < count)
                {
                    longestSubstring = count;
                }
            }
            return longestSubstring;
        }
    }
}
