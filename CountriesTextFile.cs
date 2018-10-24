using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class CountriesTextFile
    {
        StreamReader reader;
        StreamWriter writer;
        string path;
        public CountriesTextFile(string Path)
        {
            path = Path;
        }

        public void getList()
        {
            List<string> result = new List<string>();
            //Get countries from file and assign to result
            using (reader = File.OpenText(path))
            {
                String s = "";
                // takes each line(country) from file and prints until there is no lines (no countries) left in file
                while ((s =reader.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
                // the "closer" belongs in 'using'
                reader.Close();
            }
            Console.ReadKey();

        }

        public void addon ()
        {
            Console.WriteLine("Enter a country.");
            string input = Console.ReadLine();
            //Add input to the list of countries and save file
            using (writer = File.AppendText(path))
            {
                // user input adds a new line to the countries list in text file
                writer.WriteLine("\n" + input);
                writer.Close();

                Console.WriteLine(File.ReadAllText(path));
            }
            Console.ReadKey();

        }


    }
}
