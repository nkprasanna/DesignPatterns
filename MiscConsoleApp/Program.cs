using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace MiscConsoleApp
{
    class Program : GradeBook, IGradeBook
    {
        static void Main(string[] args)
        {
            GradeBook book;
            string testname;
            AddBook(out book, out testname);
            NewMethod(book, testname);

        }

        private static void AddBook(out GradeBook book, out string testname)
        {
            book = new GradeBook();
            book.NameChanged += new NameChangedDelegate(MynameChanged);
            book.NameChanged += new NameChangedDelegate(MynameChangedToo);

            book.Name = "prasanna";

            

            book.AddGrade(90);
            book.AddGrade(89.50f);
            Console.WriteLine("Please enter name");
            testname = null;
            do
            {
                Console.WriteLine("Please enter some name");
                testname = Console.ReadLine();
            } while (string.IsNullOrEmpty(testname));
        }


        static void MynameChanged(string existingName, string newName)
        {
            Console.WriteLine("Changed name delegate");
        }

        static void MynameChangedToo(string existingName, string newName)
        {
            Console.WriteLine("Changed name delegate Too");
        }
        private static void NewMethod(GradeBook book, string testname)
        {
            try
            {


                var testdd = Console.ReadLine();


                book.Name = testdd;
                Console.WriteLine($"Name {testname}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            GradeStatics stats = book.ComputeStatitcs();

            const int numberOfStudents = 4;
            int[] ste = new int[numberOfStudents];
            ste[1] = 20;
        }

        static void Writeresults(string description, float result)
        {
            Console.WriteLine(description + ": " + result);
        }
        static void Writeresults(string description, int result)
        {
            Console.WriteLine(description + ": " + result);

        }


    }


}
