using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class CountriesApp
    {
        private static string path = @"C:\Users\k8e_3\source\repos\ConsoleApp19\ConsoleApp19\countries.txt";
        private CountriesTextFile countries = new CountriesTextFile(path);

        public CountriesApp()
        {

        }
        public void menu()
        {
            Console.WriteLine("Welcome to the Countries Maintenance Application!");
            Console.WriteLine();
            do
            {

                Console.WriteLine("1. See the list of countries");
                Console.WriteLine("2. Add a country");
                Console.WriteLine("3. Exit");
                Console.WriteLine();
                Console.WriteLine("Enter menu number:");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    read();
                }

                else if (input == "2")
                {
                    write();
                }

                else if (input == "3")
                {
                    Console.WriteLine("Peace and love! See ya!");
                    Console.ReadLine();
                    break;
                }

            } while (true);
        }

        private void read()
        {
            countries.getList();
        }
        private void write()
        {
            countries.addon();
        }
    }
}
