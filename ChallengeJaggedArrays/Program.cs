namespace ChallengeJaggedArrays
{
    internal class Program
    {
        // Create a jagged array, which contains 3 "friends arrays", in which two family members should be stored
        // // introduce family member from different families to each other via console
        static void Main(string[] args)
        {
            // Define an array of family members
            string[] vinhFamily = new string[] { "Thanh", "Man", "Vinh", "Trung" };

            // Create a jagged array containing friends and family
            string[][] friendsAndFamily = new string[][]
            {
                new string[]{"Vinh", "Hau"},
                new string[]{"Hung", "Son"},
                new string[]{"Su", "Thuong"},
                vinhFamily
            };

            // Introduce family members from different families to each other
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendsAndFamily[0][0], friendsAndFamily[1][0]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendsAndFamily[0][1], friendsAndFamily[2][0]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendsAndFamily[0][1], friendsAndFamily[2][1]);

            // Wait for user input before exiting
            Console.ReadKey();
        }
    }
}
