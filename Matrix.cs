using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_4
{
    public class Matrix
    {
        // Function to rotate a square matrix by 90 degrees in clockwise direction
        static void rotate90(int[][] mat)
        {
            int n = mat.Length;

            // Consider all cycles one by one
            for (int i = 0; i < n / 2; i++)
            {

                // Consider elements in group of 4 as P1, P2, P3 & P4 in current square
                for (int j = i; j < n - i - 1; j++)
                {

                    // Swap elements in clockwise order
                    int temp = mat[i][j];
                    mat[i][j] = mat[n - 1 - j][i];                 // Move P4 to P1
                    mat[n - 1 - j][i] = mat[n - 1 - i][n - 1 - j]; // Move P3 to P4
                    mat[n - 1 - i][n - 1 - j] = mat[j][n - 1 - i]; // Move P2 to P3
                    mat[j][n - 1 - i] = temp;                      // Move P1 to P2
                }
            }
        }
    }
}
