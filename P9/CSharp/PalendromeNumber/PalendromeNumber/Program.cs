using System;
using System.Collections.Generic;

namespace PalendromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sln = new Solution();

            int input1 = 121;
            int input2 = -121;
            int input3 = 10;
            int input4 = -101;
            int input5 = 0;
            int input6 = 1;
            int input7 = 11;
            int input8 = 12;

            Console.WriteLine(sln.IsPalindrome(input1));
            Console.WriteLine(sln.IsPalindrome(input2));
            Console.WriteLine(sln.IsPalindrome(input3));
            Console.WriteLine(sln.IsPalindrome(input4));
            Console.WriteLine(sln.IsPalindrome(input5));
            Console.WriteLine(sln.IsPalindrome(input6));
            Console.WriteLine(sln.IsPalindrome(input7));
            Console.WriteLine(sln.IsPalindrome(input8));
        }
    }

    public class Solution {
        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;
            if (x == 1) return true;

            int xrevPlace = (int) Math.Pow(10, Math.Floor(Math.Log10(x)));

            int xtemp = x;
            int y = 0;

            while (xtemp != 0)
            {
                y += xtemp % 10 * xrevPlace;
                xrevPlace /= 10;
                xtemp /= 10;
            }
            return x == y;
        }
    }
}
