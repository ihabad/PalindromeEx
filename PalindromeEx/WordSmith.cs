using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeEx
{
    public class WordSmith
    {

        public bool IsAPalindrome(string names)
        {
            var RightToLeft = "";

            for (int n = names.Length - 1; n >= 0; n--)
            {
                RightToLeft += names[n];
            }
            if (names == RightToLeft)
            {
                return true;
            }
            return false;
        }
    }
}
