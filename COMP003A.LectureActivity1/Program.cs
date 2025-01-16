/* 
    Author: Michael Baker
    Course: COMP003A
    Faculty: Jonathan Cruz
    Purpose: Basic Console App
 */
// Namespace Level //
namespace COMP003A.LectureActivity1
{
    // Class Level //
    internal class Program
    {
        // Main Level (Majority of Work) //
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:"); //prompts user for input
            string username = Console.ReadLine(); //take input and saves it as variable named username

            Console.WriteLine("Hi " + username + ". My name is Michael.");
        }
    }
}