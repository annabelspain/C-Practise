using System;

namespace LibrarianUI
{
    internal class Menu
    {
        internal MenuOption GetMenuOption()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Librarian Main Menu");
            Console.WriteLine("===================");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine();
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine();
            Console.WriteLine("1. Add new member");
            Console.WriteLine("2. View member details");
            Console.WriteLine("3. Member borrowing a book");
            Console.WriteLine("9. Quit");
            Console.WriteLine();
            Console.WriteLine();

            MenuOption? result = null;

            while (result == null)
            {
                char key = Console.ReadKey(true).KeyChar;
                switch (key)
                {
                    case '1':
                        result = MenuOption.AddMember;
                        break;
                    case '2':
                        result = MenuOption.ViewMember;
                        break;
                    case '3':
                        result = MenuOption.LendBook;
                        break;
                    case '9':
                        result = MenuOption.Quit;
                        break;
                    default:
                        Console.Beep();
                        break;
                }
            }

            Console.ForegroundColor = ConsoleColor.Black;
            return (MenuOption)result;
        }
    }
}