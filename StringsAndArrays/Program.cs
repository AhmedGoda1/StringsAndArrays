using System.Globalization;

namespace StringsAndArrays
{
    class Program
    {
        // INSTRUCTIONS: Write you task related code answers under each specific comment/insturction
        static void Main(string[] args)
        {
            // PART 1: Strings

            // 1. Basic String Operations
            string helloWorld = "Hello, World!";

            Console.WriteLine("\n------------ Task 1.1 ------------------");

            // 1.1 Print the length of the string.
            Console.WriteLine(helloWorld.Length);
            // 1.2 Print the first and the last character of the string.
            Console.WriteLine("\n------------ Task 1.2 ------------------");

            Console.WriteLine(helloWorld.First());
            Console.WriteLine(helloWorld.Last());

            // 2. String Manipulation
            Console.WriteLine("\n------------ Task 2 ------------------");

            Console.Write("Please enter your name: ");

            // 2.1 Get the input from and assing it into new string variable called name
            string name = Convert.ToString(Console.ReadLine());

            // 2.2 Print a personalized welcome message including the name.
            Console.WriteLine("Welcome to Xamk: " + name);

            Console.WriteLine("\n------------ Task 2.3 ------------------");

            // 2.3 Convert name variable to uppercase and output the result
            Console.WriteLine( name.ToUpper());
            Console.WriteLine("\n------------ Task 2.4 ------------------");

            // 2.4 Convert name variable to lovercase and output the result
            Console.WriteLine(name.ToLower());

            // 3. String Searching
            // 3.1 Create new boolean variable called containsWorld
            Console.WriteLine("\n------------ Task 3 ------------------");

            bool containsWorld = helloWorld.Contains("World");

            // 3.2 Check that the helloWorld variable contains the word "World".
            //assign the result to the created constainsWorld variable
            // 3.3 If the word is found, get the index of the word from helloWorld string

            if (containsWorld)
            {
                Console.WriteLine(helloWorld.IndexOf("World"));
            }

            Console.WriteLine("\n------------ Part2 Arrays ------------------");

            // PART 2: Arrays

            // 1. Basic Array Operations
            // 1.1 initialize array called numbers containing array of int values
            //     Add these values to the array -> 2 3 5 7 11 
            int[] numbers = { 2, 3, 5, 7, 11 };
            // 1.2 Output the numbers array -> hint use Join
            // Expected outcome: 2, 3, 5, 7, 11
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(", " + numbers[i]);

            }
            Console.WriteLine("\n------------ Arrays 1.3 ------------------");

            // 1.3 Output the value of the third (3th) item in the numbers array 
            // Expected outcome: 5
            Console.WriteLine(numbers[2]);

            Console.WriteLine("\n------------ Arrays 2 ------------------");

            // 2. Array Manipulation
            // 2.1 Initialize new names string array variable that has room for 5 items
            //     The maximum lenght of the string array should be 5
            string [] newNames = new string[5];
            // 2.2 Ask the user to input new names 5 times

            //     and assing each name to the names string array in the given order.
            //     The first name should be at index 0
            //     Hint: you might want to use some sort of a loop here

            for (int j = 0; j < newNames.Length; j++)
            {
                Console.WriteLine("Please enter five names: ");
                Console.ReadLine();

                // 2.3 Output the array of given names.
                Console.WriteLine(newNames[j]);
            }
            // 2.4 Reverse the order of the items in the names array and outpu the result
            Console.WriteLine(newNames.Reverse());

            Console.WriteLine("\n------------ Arrays 3.1 ------------------");

            // 3. Array Searching
            Console.Write("Please enter a name to search: ");
            string searchName = Console.ReadLine();
            // 3.1 Try to find out the searchName from the Task 2 names string array
            //     by finding out it's index.
            //     Assign the index value to new position integer variable
            for (int k = 0; k < newNames.Length; k++)
            {

                // Console.WriteLine(searchName.IndexOf(newNames));
            }



            // 3.2 Check that the index position was found
            //     Hint: What is the result of IndexOf if nothing is found
            // 3.2.1 If position is found output the searchName and the found position
            // 3.2.2 Else output that the searchName was not found

            // 4. BONUS

            // 1. String to Array
            // 1.1 Create new empty words string array
            string[] words = new string[0];

            // 1.2 Try to get each word from the helloWorld variable and assing the values to
            //     the created words string array
            //f

            // 1.3 Output the values of the words array
        }
    }
}
