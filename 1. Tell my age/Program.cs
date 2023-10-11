using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _1.Tell_my_age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter my name");
                
                Console.ReadLine();

            Console.WriteLine("Enter the year I was born");
            int birthYear = Convert.ToInt32(Console.ReadLine());    

            int CurrentYear = DateTime.Now.Year;
            int age = CurrentYear - birthYear;
            Console.WriteLine(2023 - 2000);

            Console.ReadLine() ;


        }
    }
}
