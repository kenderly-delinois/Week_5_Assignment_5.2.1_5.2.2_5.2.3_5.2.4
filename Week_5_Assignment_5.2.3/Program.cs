using static System.Net.Mime.MediaTypeNames;

namespace Week_5_Assignment_5._2._3
{
    internal class Program
    {
        // Write a program in C# Sharp to print numbers from n to 1 using recursion.
        //Test Data :
        //How many numbers to print : 10
        //Expected Output :
        //10 9 8 7 6 5 4 3 2 1

        static void Tail_Rec(int n)
        {
            if (n > 0)
             
            {
                Console.WriteLine(n);
                Tail_Rec(n - 1);
                
            }
            return;
        }
        static void Main(string[] args)
        {
            Tail_Rec(10);
        }
    }
}
