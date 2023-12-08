using System;
using Delegate_Predicate.Models;
namespace Delegate_Predicate.Services
{
	public class BookService
	{
		public delegate bool CheckBooks(Book book);

		public void ShowBooks(List<Book> books, CheckBooks check)
		{

			int count = 0; 
			foreach(var book in books)
			{
				if (check(book))
				{
					count++;
				}
			}

            Console.WriteLine(count);

        }

        public void ShowResult()
		{
			List<Book> books = new();
			books.Add(new Book { Id = 1, Name = "Outliers", Author = "Malcolm Gladwell" });
			books.Add( new Book { Id = 2, Name = "Yeddi gozel", Author = "Nizami"});
			books.Add(new Book { Id = 3, Name = "Xosrov ve Sirin", Author = "Nizami" });

			ShowBooks(books, book => book.Author == "Nizami");
		}
	}
}

