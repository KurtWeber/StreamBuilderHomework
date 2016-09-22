using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamReaderHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            int menuOption;
            do
            {
                // Print out heading
                Console.WriteLine("\"Shakespeare\" Stream Reader homework\n");

                Console.WriteLine("1 - Display first line");
                Console.WriteLine("2 - Display contents of file");
                Console.WriteLine("3 - Display contents of file with uppercase vowels");
                Console.WriteLine("4 - Quit\n");
                Console.Write("Enter Menut Option: ");
                menuOption = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (menuOption)
                {
                    case 1:
                        // Call first method for single line
                        FirstLine();
                        Console.WriteLine();
                        break;
                    case 2:
                        // Call second method for all lines
                        AllLines();
                        Console.WriteLine();
                        break;
                    case 3:
                        // Call third method for uppercase vowels
                        UppercaseVowels();
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine("GoodBye!\n");
                        break;
                    default:
                        Console.WriteLine("Please select a number between (1-4)\n");
                        break;
                }
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();

            } while (menuOption != 4);
        }
        static void FirstLine()
        {
            // Create an instance of StreamReader to read from a file 
            StreamReader reader = new StreamReader("..\\..\\..\\Shakespeare.txt");
            // Read first line from the text file 
            string line = reader.ReadLine();
            Console.WriteLine(line);
            // Close the resource after you've finished using it 
            reader.Close();
        }
        static void AllLines()
        {
            // Create an instance of StreamReader to read from a file 
            StreamReader reader = new StreamReader("..\\..\\..\\Shakespeare.txt");
            using (reader)  // Auto-Closing between {}  do not need reader.Close(); 
            {
                // Count to determine number of lines 
                int lineNumber = 0;
                // Read first line from the text file 
                string line = reader.ReadLine();
                // Read the other lines from the text file 
                while (line != null)
                {
                    // Increment by 1 (linenumber = linenumber + 1) 
                    lineNumber++;
                    // Write line to console 
                    Console.WriteLine(line);
                    // Read next line 
                    line = reader.ReadLine();
                }
                // Close the resource after you've finished using it 
                //reader.Close(); 
            }
        }
        static void UppercaseVowels()
        {
            // Convert all vowels to uppercase
            Console.WriteLine("******************** Under Construction *******************");
        }
    }
}
