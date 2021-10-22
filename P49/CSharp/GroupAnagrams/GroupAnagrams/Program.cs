using System;
using System.Collections.Generic;
using System.Linq;

namespace GroupAnagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sln = new Solution();

            string[] str1 = {"eat", "tea", "tan", "ate", "nat", "bat"};
            string[] str2 = {""};
            string[] str3 = {"a"};

            Console.WriteLine(sln.GroupAnagrams(str1));
            Console.WriteLine(sln.GroupAnagrams(str2));
            Console.WriteLine(sln.GroupAnagrams(str3));
        }
    }

    public class Solution {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            IList<IList<string>> result = new List<IList<string>>();
            while (strs.Length > 0)
            {
                IList<string> grouped = new List<string> {strs[0]};
                List<int> usedIndexes = new List<int> {0};
                //Group Strings
                for (var i = 1; i < strs.Length; i++)
                {
                    if (AreStringsEqual(strs[0], strs[i]))
                    {
                        grouped.Add(strs[i]);
                        usedIndexes.Add(i);
                    }
                }

                var newStr = new string[strs.Length - usedIndexes.Count];
                //Remove already Grouped indexes
                for (int i = 0; i < newStr.Length; i++)
                {
                    if (!usedIndexes.Contains(i))
                    {
                        newStr[i] = strs[i];
                    }
                }

                strs = newStr;

                //Add Grouped strings to result.
                result.Add(grouped);
            }
            return result;
        }

        private bool AreStringsEqual(string a, string b)
        {
            int sumA = 0;
            int sumB = 0;

            foreach (var t in a)
            {
                sumA += t;
            }

            foreach (var t in b)
            {
                sumB += t;
            }

            return sumA == sumB;
        }

    }
}
