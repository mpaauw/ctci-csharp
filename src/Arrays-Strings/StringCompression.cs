using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_Strings
{
    public class StringCompression
    {
        public string CompressString(string input)
        {
            StringBuilder builder = new StringBuilder();
            int currentCount = 1;
            for(int i = 0; i < input.Length; i++)
            {
                if(i == input.Length - 1 || input[i] != input[i + 1])
                {
                    builder.Append($"{input[i]}{currentCount}");
                    currentCount = 1;
                }
                else
                {
                    currentCount++;
                }
            }
            return (builder.Length < input.Length) ? builder.ToString() : input;
        }
    }
}
