using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new BookTrackerContext();

            Console.WriteLine("Enter a book title: ");
            string title = Console.ReadLine();

            Console.WriteLine("Enter the author's name:");
            string enteredName = Console.ReadLine();

            Console.WriteLine("How would you rate the book? Range: 1-5 stars");
            int rating = int.Parse(Console.ReadLine());
            Console.ReadKey();


        }
    }
}
