using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_Strings
{
    public class CheckPermutation
    {
        public bool IsStringAPermutationOfAnother(string s1, string s2)
        {
            if(s1.Length != s2.Length)
            {
                return false;
            }

            int[] buffer = new int[256];
            for(int i = 0; i < s1.Length; i++)
            {
                buffer[s1[i]] += 1;
            }
            for(int i = 0; i < s2.Length; i++)
            {
                buffer[s2[i]] -= 1;
            }
            for(int i = 0; i < buffer.Length; i++)
            {
                if(buffer[i] != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
