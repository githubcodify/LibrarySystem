using System;

namespace LibrarySystem
{
    public class Program
    {
        static LibraryManagementSystem library = new LibraryManagementSystem();

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. View Books");
                Console.WriteLine("3. Borrow Book");
                Console.WriteLine("4. Return Book");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice (1-5): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter the title of the book: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter the author of the book: ");
                        string author = Console.ReadLine();
                        library.AddBook(title, author);
                        break;
                    case "2":
                        library.ViewBooks();
                        break;
                    case "3":
                        Console.Write("Enter the title of the book to borrow: ");
                        string borrowTitle = Console.ReadLine();
                        library.BorrowBook(borrowTitle);
                        break;
                    case "4":
                        Console.Write("Enter the title of the book to leave: ");
                        string leaveTitle = Console.ReadLine();
                        library.ReturnBook(leaveTitle);
                        break;
                    case "5":
                        Console.WriteLine("Exiting the library management system.");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}