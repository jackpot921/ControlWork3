using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork3
{
    class Book
    {
        public string Author;
        public string Name;
        public int Year;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var books = new List<Book>()
            {
                new Book() { Author = "Terry Pratchett", Name = "Guards! Guards!", Year = 1986 },
                new Book() { Author = "Terry Pratchett", Name = "Guards! LINQ Guards!!", Year = 1999 },
                new Book() { Author = "Stephen King", Name="Finders LINQ Keepers", Year = 2000},
                new Book() { Author = "Stephen King", Name="Finders Keepers", Year = 2004},
                new Book() { Author = "Jack Johnson", Name = "Some LINQ book", Year = 1996},
                new Book() { Author = "Jack Johnson", Name = "Some another book", Year = 1997}
            };
            string stringData = "I dont know what to type in that string";
            int[] intArray = new int[] { 14, 34, 23, 16, 67, 89, 35, 88, 3 };

            //1
            Console.WriteLine("Task 1:");
            Console.WriteLine(string.Join(Environment.NewLine, books.Where(b => b.Name.Contains("LINQ") && (DateTime.IsLeapYear(b.Year))).Select(b => b.Name)));
            Console.WriteLine();

            //2
            Console.WriteLine("Task 2:");
            Console.WriteLine(string.Join(Environment.NewLine, stringData.ToLower().Where(c => c != ' ').Distinct().Count()));
            Console.WriteLine();

            //3
            Console.WriteLine("Task 3:");
            Console.WriteLine(string.Join(", ", intArray.OrderBy(x => x / 10).ThenByDescending(y => y % 10)));
            Console.WriteLine();

            //4
            Console.WriteLine("Task 4:");
            Console.WriteLine(string.Join(Environment.NewLine, books.OfType<Book>().GroupBy(b => b.Author).Select(gr => $"{gr.Key}: {gr.Count()}")));
            Console.WriteLine();
        }
    }
}
