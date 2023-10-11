namespace MultiDimensionalArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare 2D Array
            string[,] matrix;

            // 3D array
            int[,,] threeD;

            // two dimensional array
            int[,] array2D = new int[,]
            {
                {1, 2, 3,}, // row 0
                {4, 5, 6,}, // row 1
                {7, 8, 9} // row 2
            };

            Console.WriteLine("Cental value is {0}", array2D[2, 0]);

            string[,,] array3D = new string[,,]
            {
                {
                    {"000","001" }, // 0-0
                    {"012","011" }, // 0-1
                    {"Hi there","What's up" } // 0-2
                },
                {
                    {"100","101" }, // 1-0
                    {"110","113" }, // 1-1
                    {"Another one","Last entry" } // 1-2
                }
            };

            Console.WriteLine("The value is {0}", array3D[1, 2, 1]);

            string[,] array2DString = new string[3, 2]
            {
                { "one", "two" },
                { "three", "four" },
                { "five", "six" }
            };

            array2DString[1, 1] = "chicken";

            // Rank return the amount of dimensions
            int dimensions = array2DString.Rank;

            int[,] array2D2 = { { 1, 2 }, { 3, 4 } };

            Console.WriteLine("The value is {0}", dimensions);

            Console.ReadKey();
        }
    }
}




