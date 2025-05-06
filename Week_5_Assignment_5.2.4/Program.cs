using static System.Net.Mime.MediaTypeNames;

namespace Week_5_Assignment_5._2._4
{
    // Write a program in C# Sharp to check whether a given string is Palindrome or not using recursion.
    //Test Data :
    //Input a string : RADAR
    //Expected Output :
    //The string is Palindrome.
    internal class Program
    {
        static bool IsPalindrome(string s, int start, int end)
        {
            if(start >= end)
                return true;
            if (s[start] != s[end])
                return false;

            return IsPalindrome(s, start + 1, end - 1);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            string str = input.ToUpper();
            if(IsPalindrome(str, 0, str.Length - 1))
            {
                Console.WriteLine("The string is Palindrome");
            }
            else
            {
                Console.WriteLine("The string is not Palindrome");
            }
        }
    }
}
