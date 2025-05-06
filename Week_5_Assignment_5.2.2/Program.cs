using static System.Net.Mime.MediaTypeNames;

namespace Week_5_Assignment_5._2._2
{
    internal class Program
    {   // Write a program in C# Sharp to print the first n natural number using recursion.
        //Test Data :
        //How many numbers to print : 10
        //Expected Output :
        //1 2 3 4 5 6 7 8 9 10

        static void Head_ReC(int n)
        {
            if (n > 0)
            {
                Head_ReC(n - 1);
                Console.WriteLine(n);
            }
            return;
        }
        static void Main(string[] args)
        {
            Head_ReC(10);
        }
    }
}
