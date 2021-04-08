using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array of string size 5. Fill array items with values.
            string stringArrayHeader = "String array";
            string stringArrayValue;
            string[] stringArray = new string[5];

            Console.WriteLine(stringArrayHeader);
            Console.WriteLine(new string('-', stringArrayHeader.Length));
            // Print all words using loop.
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArrayValue = "value-" + i;
                Console.Write(stringArray[i] + stringArrayValue + " ");
            }
            //----------------------------------------------------------------
            string intArrayHeaderNR = "Int array (not reversed)";
            string intArrayHeaderR = "Int array (reversed)";

            // Create an int array size 20. Fill values from 0 till 20.
            int[] intArray = new int[20];
            Console.WriteLine("\n\n" + intArrayHeaderNR);
            Console.WriteLine(new string('-', intArrayHeaderNR.Length));
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = i;
                Console.Write(intArray[i] + " ");
            }

            // Print numbers backwards.
            Console.WriteLine("\n\n" + intArrayHeaderR);
            Console.WriteLine(new string('-', intArrayHeaderR.Length));
            for (int i = intArray.Length - 1; i >= 0; i--)
            {
                Console.Write(intArray[i] + " ");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
