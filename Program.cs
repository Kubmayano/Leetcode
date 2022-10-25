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
            s.TitleToNumber("AA");
        }

        public bool isPalindrome(int x) //Cheks if a number is palindrome, Question NO: 9
        {
            if (x < 0) return false;

            string n = x.ToString();
            string reverse = new String(n.ToString().Reverse().ToArray());

            if (n == reverse) return true;
            else return false;
        }
        
    }
}