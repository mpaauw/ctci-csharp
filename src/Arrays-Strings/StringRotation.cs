using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_Strings
{
    public class StringRotation
    {
        public bool IsRotation(string s1, string s2)
        {
            int s1Length = s1.Length;
            if (s1Length == s2.Length && s1.Length > 0)
            {
                string concatenatedS1 = s1 + s1;
                return IsSubstring(concatenatedS1, s2);
            }
            return false;
        }

        private bool IsSubstring(string parent, string sub)
        {
            return parent.Contains(sub);
        }
    }
}
