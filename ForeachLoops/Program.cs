using System.ComponentModel.DataAnnotations;

namespace ForeachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            do
            {
                Console.WriteLine("Please enter a valid number:");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out _));
            /*int[] numbers = { 1, 2, 3, 4, 5 };*/
            /*foreach (int number in numbers)
            {
                Console.WriteLine(number); 
            }*/
            /*for (int i = 0; i < numbers.Length; i+= 2)
            {
                Console.WriteLine(numbers[i]);
            }*/

            Console.ReadKey();
        }
    }
}
