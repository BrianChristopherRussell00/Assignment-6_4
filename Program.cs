namespace Assignment_6_4
{
    internal class Program
    {
        public static void Main()
        {
            int[][] mat = {
            new int[] {1, 2, 3, 4},
            new int[] {5, 6, 7, 8},
            new int[] {9, 10, 11, 12},
            new int[] {13, 14, 15, 16}
        };



            // Print the rotated matrix
            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat[i].Length; j++)
                {
                    Console.Write(mat[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}