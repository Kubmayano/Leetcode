/*
    Basically just a github project for me to do Leetcode problems and hopefully improve over time, if you're scrolling
    this at a later date then you can expect to find the harder problems at the bottom
    and no before you ask these aren't sorted in any specific way (at least not yet)
*/

using System;

namespace Leetcode
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            Solution s = new Solution();
            System.Console.WriteLine(s.IsPowerOfThree(243));
        }

        public bool isPalindrome(int x) //Cheks if a number is palindrome, Question NO: 9, Diff: Easy
        {
            if (x < 0) return false;

            string n = x.ToString();
            string reverse = new String(n.ToString().Reverse().ToArray());

            if (n == reverse) return true;
            else return false;
        }

        public bool IsPowerOfTwo(int n) //Checks if a number is a power of 2, Question NO: 231, Diff: Easy
        {
            if (n == 1) return true;

            double x = Math.Abs(Math.Log2(n));

            if (x % Math.Round(x) == 0) return true;

            else return false;
        }

        public bool IsPowerOfThree(int n) //Checks if a number is a power of 3, Question NO: 231, Diff: Easy
        {
            if (n == 1) return true;

            double x = Math.Abs(Math.Log(n) / Math.Log(3));
            x = Math.Round(x);

            if (x % Math.Round(x) == 0) return true;

            else return false;
        }
    }
}