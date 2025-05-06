namespace Week_5_Assignment_5._2._1
{
    internal class Program
    {
        // Given a string s consisting of words and spaces, return the length of the last word in the string.
        // A word is a maximal substring consisting of non-space characters only.

        //Example 1:
        //Input: s = "Hello World"
        //Output: 5
        //Explanation: The last word is "World" with length 5.

        static int CountLastChar(string s)
        {
            // O(1) --> Constant
            //string[] Compact = s.Trim().Split();
            //string LastWord = Compact[Compact.Length - 1];
            //return LastWord.Length;


            // O(N) ---> Linear
            s = s.Trim(); // remove front and back spaces
            string[] words = s.Split(' '); // Split the string to make future ietration over words easy
            int count  = 0; // Store count into a variable
            string LastWord = words[words.Length - 1]; // Fetch for the last work into the array

            foreach (char c in LastWord) // Looping over the last work to count each char
            {
                count++; // Incrementing   ex: count =  count + 1         
            }
            return count; // return the count 
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CountLastChar("Hello World")); // Display result
        }
    }
}
