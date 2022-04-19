using LendingLibrary;
using System;

namespace LibrarianUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Librarian System";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Library library = new Library();

            MenuOption option;
            do
            {
                Menu menu = new Menu();
                option = menu.GetMenuOption();

                switch (option)
                {
                    case MenuOption.AddMember:
                        LibraryUi.AddMember(library);
                        break;
                    case MenuOption.ViewMember:
                        LibraryUi.ViewMember(library);
                        break;
                    case MenuOption.LendBook:
                        LibraryUi.LendBook(library);
                        break;
                }

            } while (option != MenuOption.Quit);
        }
    }
}
