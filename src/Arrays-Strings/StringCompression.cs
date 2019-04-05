using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_Strings
{
    public class StringCompression
    {
        public string CompressString(string input)
        {
            if(input.Length < 1)
            {
                return input;
            }

            var builder = new StringBuilder();
            int currentCount = 1;
            char currentChar = input[0];
            for(int i = 1; i < input.Length - 1; i++)
            {
                char c = input[i];
                if(c != currentChar)
                {
                    builder.Append($"{currentChar}{currentCount}");
                    currentChar = c;
                    currentCount = 1;
                }
                else
                {
                    currentCount++;
                }
            }
            builder.Append($"{currentChar}{currentCount}");
            return (input.Length <= builder.Length) ? input : builder.ToString();
        }
    }
}
