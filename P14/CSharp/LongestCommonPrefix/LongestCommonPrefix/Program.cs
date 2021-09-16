using System;

namespace LongestCommonPrefix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Longest Common Prefix driver.");

            Solution sln = new Solution();

            //string[] a = {"Float", "Floor", "Fly"}; // "Fl"
            //string[] b = {"Face", "Food", "Fly"}; // "F"
            //string[] c = {"dog", "racecar", "car"}; // ""
            //string[] d = {"asdf", "asdf", "asdf"}; // ""
            //string[] e = {"", "a", "b"}; // ""
            string[] f = {"cir", "car"}; // ""

            //Console.WriteLine(sln.LongestCommonPrefix(a));
            //Console.WriteLine(sln.LongestCommonPrefix(b));
            //Console.WriteLine(sln.LongestCommonPrefix(c));
            //Console.WriteLine(sln.LongestCommonPrefix(d));
            //Console.WriteLine(sln.LongestCommonPrefix(e));
            Console.WriteLine(sln.LongestCommonPrefix(f));

            
        }
    }

    public class Solution {
        public string LongestCommonPrefix(string[] strs)
        {
            // Find smallest string length (we shouldnt have a common prefix longer than that)
            int indexOfSmallesttString = 0;
            for (int i = 1; i < strs.Length; i++)
            {
                if (strs[indexOfSmallesttString].Length > strs[i].Length)
                {
                    indexOfSmallesttString = i;
                }
            }

            int count = 0;
            //Use the smallest string to count common prefix chars
            for (int i = 0; i < strs[indexOfSmallesttString].Length; i++)
            {
                bool equalChars = true;
                for (int j = 0; j < strs.Length; j++)
                {
                    if (strs[indexOfSmallesttString][i] != strs[j][i])
                    {
                        equalChars = false;
                    }    
                }
                if (equalChars)
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            return strs[indexOfSmallesttString].Substring(0, count);
        }
    }
}
