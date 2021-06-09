using System;
using Bogus;

namespace MyBanker
{
    class Program
    {
        static void Main(string[] args)
        {

             Card card = new VisaCard ();


            Console.WriteLine("Press any key to exit the program");
            Console.ReadKey();
        }
    }
}
