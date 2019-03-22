using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_Strings
{
    public class PalindromePermutation
    {
        public bool IsPalindromePermutation(string input)
        {
            var characterCounts = new Dictionary<char, int>();

            for(int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if(characterCounts.ContainsKey(c))
                {
                    characterCounts[c] += 1;
                }
                else {
                    characterCounts.Add(c, 1);
                }
            }

            bool hasOddCount = false;
            foreach(var key in characterCounts.Keys)
            {
                if(characterCounts[key] % 2 != 0)
                {
                    if(hasOddCount)
                    {
                        return false;
                    }
                    hasOddCount = true;
                }
            }
            return true;
        }
    }
}
