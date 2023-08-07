using System;
namespace LibrarySystem
{
	public class LibraryManagementSystem
	{
		private static List<Book> books;

		public LibraryManagementSystem()
		{
			books = new List<Book>();
		}

		public void AddBook(string title, string author)
		{
			books.Add(new Book(title, author));
		}

		public void ViewBooks()
		{
			if (books.Count == 0)
			{
				Console.WriteLine("Book not found in the library.");
			}
			else
			{
                Console.WriteLine("Library books:");
                foreach (var book in books)
                {
                    Console.WriteLine($"{book.Title} by {book.Author} - {(book.IsAvailable ? "Available" : "Borrowed")}");
                }
            }
		}

		public void BorrowBook(string title)
		{
			var book = books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

			if (book == null)
			{
				Console.WriteLine($"Book '{title}' not found in the library.");
				return;
			}

			if (!book.IsAvailable)
			{
				Console.WriteLine($"Book '{title}' is already borrowed.");
				return;
			}

			book.IsAvailable = false;
            Console.WriteLine($"You have borrowed '{title}'.");
        }

		public void ReturnBook(string title)
		{
            var book = books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

            if (book == null)
            {
                Console.WriteLine($"Book '{title}' not found in the library.");
                return;
            }

            if (book.IsAvailable)
            {
                Console.WriteLine($"Book '{title}' is already available in the library.");
                return;
            }

			book.ReturnBook();
            Console.WriteLine($"You have returned '{title}'.");
        }
    }
}

