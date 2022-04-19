using LendingLibrary;
using System;

namespace LibrarianUI
{
    internal class LibraryUi
    {
        internal static void AddMember(Library library)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Add Member");
            Console.WriteLine("==========");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            string name = GetString("Enter new member name:");
            int age = GetInteger("Enter member age:");
            string street = GetString("Enter street:");
            string city = GetString("Enter city:");

            Member member = library.Add(name, age);
            member.Street = street;
            member.City = city;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine();
            Console.WriteLine("Member created - press any key to continue");
            Console.ReadKey();
        }

        internal static void ViewMember(Library library)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("View Member");
            Console.WriteLine("===========");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("Here is a list of members:");
            ShowMemberList(library);
            int membershipNumber = GetInteger("Enter the membership number of the member to view:");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Member member = library.Members[membershipNumber];
            Console.WriteLine($"Membership Number:  {member.MembershipNumber}");
            Console.WriteLine($"Name:               {member.Name}");
            Console.WriteLine($"Age:                {member.Age}");
            Console.WriteLine($"Street:             {member.Street}");
            Console.WriteLine($"City:               {member.City}");
            Console.WriteLine($"Membership  type:   {member.GetType().Name}");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        internal static void LendBook(Library library)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Check Out Book");
            Console.WriteLine("==============");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("Here is a list of members:");
            ShowMemberList(library);
            int membershipNumber = GetInteger("Enter the membership number of the member checking out a book:");
            Member member = library.Members[membershipNumber];

            Console.WriteLine("Here is a list of books:");
            foreach (Book book in library.Books.Values)
            {
                Console.WriteLine($"{book.BookCode} - {book.Title}");
            }
            int bookCode = GetInteger($"Enter the book code of the book being checked out by {member.Name}:");
            Book requestedBook = library.GetBook(bookCode);

            bool success = member.Borrow(requestedBook);

            if (success)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"{requestedBook.Title} lent successfully");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Unable to lend {requestedBook.Title}");
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        private static void ShowMemberList(Library library)
        {
            foreach (Member member in library.Members.Values)
            {
                Console.WriteLine($"{member.MembershipNumber} - {member.Name}");
            }
        }

        private static string GetString(string message)
        {
            Console.Write(message + " ");
            return Console.ReadLine();
        }

        private static int GetInteger(string message)
        {
            Console.Write(message + " ");
            bool success;
            int result;
            do
            {
                string input = Console.ReadLine();
                success = int.TryParse(input, out result);
                if (!success)
                {
                    Console.Write("Not a valid number, try again: ");
                }
            } while (!success);

            return result;
        }
    }
}