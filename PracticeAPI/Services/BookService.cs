using PracticeAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeAPI.Services
{
    public class BookService : IbookRepository
    {
        public BookService()
        {

        }
        public List <Book> AllBooks() 
        {
            var books = new List<Book>();
            var book1 = new Book
            {
           
                Name= "Harry Potter",
                AuthorId = 1,
                Type = "Fantasy",
                NofOpages = 500

            };
            books.Add(book1);

            var book2 = new Book
            {
             
                Name= "Gulliver’s Travels",
                AuthorId = 2,
                Type = "Adventure",
                NofOpages = 500

            };
            books.Add(book2);
            var book3 = new Book
            {
           
                Name = " Robinson Crusoe ",
                AuthorId = 3,
                Type = "Adventure",
                NofOpages = 300

            };
            books.Add(book3);
            return books;
        }

       
      public  Book GetBook(int id)
        {
            throw new NotImplementedException();
        }
    }
}
