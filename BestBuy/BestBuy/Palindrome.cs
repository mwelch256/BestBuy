using System;
using System.Collections.Generic;
using System.Text;

namespace BestBuy
{
    public class Palindrome
    {
        public bool IsThisAPalindrome(string word)
        {
            var newWord = "";

            for (int i = word.Length -1; i >= 0; i--)
            {
                newWord += word[i];
            }

            if (newWord == word)
            {
                return true;
            }

            else
            {
                return false;
            }

        }



        public Palindrome()
        {
        }


    }
}
