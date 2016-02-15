using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string Hello = "Hello World";

            // Turn a string into an array. Type must be char.
            char[] stringToArray = Hello.ToCharArray();

            // Print out content of array by joining it.
            Console.WriteLine(string.Join(", ", stringToArray));

            // Only turn part of string into char array.
            char[] justHello = Hello.ToCharArray(0, 5);

            // Return array contents after joining.
            Console.WriteLine(string.Join(", ", justHello));

            // Iterate over array using foreach
            foreach(var letter in stringToArray)
            {
                Console.WriteLine(letter);
            }
            Console.WriteLine(" ");
            // Iterate over array using for loop
            for(var i = 0; i < stringToArray.Length; i++)
            {
                Console.WriteLine(stringToArray[i]);
            }

            // Reverse array.
            Array.Reverse(justHello);

            // Return reversed string.
            Console.WriteLine(string.Join("", justHello));

            // Character to remove from array.
            char letterToRemove = Convert.ToChar("o");

            // Remove All characters equal to letter to remove.
            char[] allRemoved = stringToArray.Where(val => val != letterToRemove).ToArray();

            // Print out joined array.
            Console.WriteLine(string.Join("", allRemoved));

            // Find first value in array equal to letter to remove.
            int letterIndex = Array.IndexOf(stringToArray, letterToRemove);

            // Remove letter at letter index.
            char[] firstRemoved = stringToArray.Where((val, idx) => idx != letterIndex).ToArray();

            // Print out joined array.
            Console.WriteLine(string.Join("", firstRemoved));

            // Add to an array by converting it to a List.
            // Convert array to List.
            List<char> HelloWorld = stringToArray.ToList();

            // Add a character to the list.
            HelloWorld.Add(Convert.ToChar("!"));

            // Convert List to Array.
            HelloWorld.ToArray();

            // Print out joined array.
            Console.WriteLine(string.Join("", HelloWorld));

            // Return only non blank chars.
            char[] NoBlanks = stringToArray.Where(val => val != Convert.ToChar(" ")).ToArray();

            Console.WriteLine(string.Join("", NoBlanks));
            Console.Read();
        }
    }
}
