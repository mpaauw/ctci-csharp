using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_Strings
{
    public class URLify
    {
        private const string Placeholder = @"%20";

        public string ReplaceAllSpacesWithPlaceholders(string input, int trueLength)
        {
            char[] inputArr = input.ToCharArray();

            int spaceCount = 0;
            for(int i = 0; i < input.Length; i++)
            {
                if(input[i] == ' ')
                {
                    spaceCount += 1;
                }
            }

            int tailIndex = (spaceCount * 3) + trueLength;
            for(int i = trueLength; i >= 0; i--)
            {
                char current = inputArr[i];
                if(current == ' ')
                {
                    for(int j = 2; j >= 0; j--)
                    {
                        inputArr = ModifyInputArr(inputArr, Placeholder[j], tailIndex);
                        tailIndex -= 1;
                    }
                }
                else
                {
                    inputArr = ModifyInputArr(inputArr, current, tailIndex);
                    tailIndex -= 1;
                }
            }

            return inputArr.ToString();
        }

        private char[] ModifyInputArr(char[] inputArr, char val, int tailIndex)
        {
            inputArr[tailIndex] = val;
            return inputArr;
        }
    }
}
