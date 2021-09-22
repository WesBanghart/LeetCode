using System;

namespace ReverseInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sln = new Solution();
            int x1 = 123;
            int x2 = -123;
            int x3 = 120;
            int x4 = 0;
            int x5 = 214748364;
            int x6 = 1534236469;

            Console.WriteLine(sln.Reverse(x1));
            Console.WriteLine(sln.Reverse(x2));
            Console.WriteLine(sln.Reverse(x3));
            Console.WriteLine(sln.Reverse(x4));
            Console.WriteLine(sln.Reverse(x5));
            Console.WriteLine(sln.Reverse(x6));

        }
    }

    public class Solution {
        //TODO: This uses too much space, find a better solution that uses less
        public int Reverse(int x)
        {
            if (x < 10 && x > -10) return x;

            long y = 0;
            long tempx = x > 0 ? x : -x;
            int xRev = (int) Math.Pow(10, Math.Floor(Math.Log10(tempx)));

            while (tempx != 0)
            {
                y += tempx % 10 * xRev;
                xRev /= 10;
                tempx /= 10;
            }

            y = x > 0 ? y : -y;
            return (y > 2147483647 || y < -2147483648) ? 0 : (int) y;
        }
    }
}
