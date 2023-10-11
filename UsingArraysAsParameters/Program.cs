namespace UsingArraysAsParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize an array of students' grades
            int[] studentsGrades = new int[] { 15, 13, 8, 12, 6, 16 };

            // Call the GetAverage method to calculate the average of grades
            double averageResult = GetAverage(studentsGrades);

            // Declare and initialize an array of happiness values
            int[] happiness = { 2, 3, 4, 5, 6 };

            // Call the SunIsShining method to increase each value in the happiness array by 2
            SunIsShining(happiness);

            // Print the modified happiness array using a foreach loop
            foreach (int y in happiness)
            {
                Console.WriteLine(y);
            }

            // Print the original students' grades using a foreach loop
            foreach (int grade in studentsGrades)
            {
                Console.WriteLine(" {0} ", grade);
            }

            // Print the calculated average result
            Console.WriteLine("The average is: {0}", averageResult);
            Console.ReadKey();
        }

        // Method to calculate the average of an integer array
        static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;

            // Calculate the sum of all grades
            for (int i = 0; i < size; i++)
            {
                sum += gradesArray[i];
            }

            // Calculate the average and return it
            average = (double)sum / size;
            return average;
        }

        // Method to modify each element in an integer array
        static void SunIsShining(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
                x[i] += 2;
        }
    }
}
