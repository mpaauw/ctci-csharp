using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_Strings
{
    public class RotateMatrix
    {
        public int[][] RotateSquareMatrix(int[][] matrix)
        {
            int n = matrix.Length;

            if (matrix.Length == 0 || matrix.Length != matrix[0].Length)
            {
                return null; // bad data
            }

            // go by layers, rotating cells one at a time per layer:
            for (int layer = 0; layer < n / 2; layer++)
            {
                int first = layer;
                int last = n - 1 - layer;
                for (int i = first; i < last; i++)
                {
                    int offset = i - layer; // store offset for counting outwards => in on bottom and left

                    int top = matrix[first][i]; // top
                    int right = matrix[i][last]; // right
                    int bottom = matrix[last][last - offset]; // bottom
                    int left = matrix[last - offset][first]; // left

                    // perform in-place swaps:
                    matrix[first][i] = left; // left => top
                    matrix[i][last] = top; // top => right;
                    matrix[last][last - offset] = right; // right => bottom
                    matrix[last - offset][first] = bottom; // bottom => left
                }
            }
            return matrix; // return rotated matrix
        }
    }
}
