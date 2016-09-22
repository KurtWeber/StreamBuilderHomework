using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamReaderHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            int menuOption = 0;
            do
            {
                // Print out heading
                Console.WriteLine("\"Shakespeare\" Stream Reader homework\n");

                Console.WriteLine("1 - Display first line");
                Console.WriteLine("2 - Display contents of file");
                Console.WriteLine("3 - Display contents of file with uppercase vowels");
                Console.WriteLine("4 - Quit\n");
                Console.Write("Enter Menut Option: ");
                Console.ReadLine();
                menuOption = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch 
            } while (menuOption != 4);
        }
    }
}
