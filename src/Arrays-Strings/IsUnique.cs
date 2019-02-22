using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_Strings
{
    public class IsUnique
    {
        public bool DoesStringConsistOfUniqueCharactersUsingAsciiBuffer(string input)
        {
            bool[] buffer = new bool[256];
            for (int i = 0; i < input.Length; i++)
            {
                int asciiVal = input[i];
                if (buffer[asciiVal])
                {
                    return false;
                }
                buffer[asciiVal] = true;
            }
            return true;
        }

        public bool DoesStringConsistOfUniqueCharactersUsingSort(string input)
        {
            var arr = SelectionSort(input.ToCharArray());
            for (int i = 0; i < arr.Length - 1; i++)
            {
                char current = arr[i], next = arr[i + 1];
                if (current == next)
                {
                    return false;
                }
            }
            return true;
        }

        private char[] SelectionSort(char[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                int temp = arr[min];
                arr[min] = arr[i];
                arr[i] = (char)temp;
            }
            return arr;
        }
    }
}
