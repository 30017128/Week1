using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1_App
{
    class Program
    {
        static void Main(string[] args)
        {

            // Will print Hello World to the screen

            int age;

            string name;

            Console.WriteLine("Please enter your age.");
            //Parse is checking if it is a integer 
            age = int.Parse (Console.ReadLine());
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();
            Console.WriteLine(name + age);


            Console.ReadLine();
           
        }
    }
}
