using PracticeAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeAPI.Services
{
    public class AuthorService : IAuthorRepository
    {
        public List<Author> AllAuthors()
        {
            var authors = new List<Author>();
            var author1 = new Author
            {
                Id = 1,
                FullName= "J. K. Rowling"

            };
            authors.Add(author1);

            var author2 = new Author
            {
                Id = 2,
                FullName = "Jonathan Swift",
              

            };
            authors.Add(author2);
            var author3 = new Author
            {
                Id = 3,
                FullName = "Daniel Defoe",
             

            };
            authors.Add(author3);
            return authors;
        }
    }
}
