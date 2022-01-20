using PracticeAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeAPI.Services
{
    public class BookService
    {
        public List <Book> AllBooks()
        {
            var books = new List<Book>();
            var book1 = new Book
            {
                Id = 1,
                Name= "Harry Potter",
                Author = "J.K. Rowling",
                type = "Fantasy",
                nOfOpages = 500

            };
            books.Add(book1);

            var book2 = new Book
            {
                Id = 2,
                Name= "Gulliver’s Travels",
                Author = "Jonathan Swift ",
                type = "Adventure",
                nOfOpages = 500

            };
            books.Add(book2);
            var book3 = new Book
            {
                Id = 3,
                Name = " Robinson Crusoe ",
                Author = "Daniel Defoe ",
                type = "Adventure",
                nOfOpages = 300

            };
            books.Add(book3);
            return books;
        }
        
    }
}
