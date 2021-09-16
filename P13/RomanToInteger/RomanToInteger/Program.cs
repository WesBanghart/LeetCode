using System;
using System.Collections.Generic;

namespace RomanToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sln = new Solution();

            var s1 = "III";
            var s2 = "IV";
            var s3 = "IX";
            var s4 = "LVIII";
            var s5 = "MCMXCIV";

            Console.WriteLine(sln.RomanToInt(s1));
            Console.WriteLine(sln.RomanToInt(s2));
            Console.WriteLine(sln.RomanToInt(s3));
            Console.WriteLine(sln.RomanToInt(s4));
            Console.WriteLine(sln.RomanToInt(s5));
        }
    }

    public class Solution
    {
        public int RomanToInt(string s)
        {
            short count = 0;
            for (var i = s.Length - 1; i >= 0; i--)
            {
                if (i == s.Length - 1)
                {
                    count += GetRomanValue(s[i]);
                }
                else if (GetRomanValue(s[i+1]) > GetRomanValue(s[i]))
                {
                    count -= GetRomanValue(s[i]);
                }
                else
                {
                    count += GetRomanValue(s[i]);
                }
            }
            return count;
        }

        private static short GetRomanValue(char s)
        {
            return s switch
            {
                'I' => 1,
                'V' => 5,
                'X' => 10,
                'L' => 50,
                'C' => 100,
                'D' => 500,
                'M' => 1000,
                _ => 0
            };
        }
    }
}
