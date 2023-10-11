using System.Numerics;

namespace NestedForLoopsAnd2DArrays
{
    internal class Program
    {
        static int[,] matrix =
        {
            {1,2,3 },
            {4,5,6},
            {7,8,9}
        };
        static void Main(string[] args)
        {
            for (int i = 0, j = 2; i < matrix.GetLength(0); i++, j--)
            {// this loop goes through each element in the diagonal
                Console.WriteLine(matrix[i, j]);
            }
        }
    }
}














