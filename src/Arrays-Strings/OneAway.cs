using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_Strings
{
    public class OneAway
    {
        Dictionary<char, int> s1Dict = new Dictionary<char, int>();
        Dictionary<char, int> s2Dict = new Dictionary<char, int>();

        public bool AreStringsOneEditAway(string s1, string s2)
        {
            // quick length check:
            if(Math.Abs(s1.Length - s2.Length) > 1)
            {
                return false;
            }

            // order strings based on lengths:
            string shorter = (s1.Length < s2.Length) ? s1 : s2;
            string longer = (s1.Length < s2.Length) ? s2 : s1;

            // move iterators through both strings, finding discrepancies:
            int shortIter = 0, longIter = 0;
            bool isDifferent = false;
            while(shortIter < shorter.Length && longIter < longer.Length)
            {
                if(shorter[shortIter] != longer[longIter])
                {
                    if(isDifferent)
                    {
                        return false;
                    }
                    isDifferent = false;
                    if(shorter.Length == longer.Length)
                    {
                        shortIter++;
                    }
                }
                else {
                    shortIter++;
                }
                longIter++;
            }
            return true;            
        }
    }
}
