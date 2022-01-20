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
                FirstName= "J. K.",
                lastName= "Rowling",
                country= "England",
               

            };
            authors.Add(author1);

            var author2 = new Author
            {
                Id = 2,
                FirstName = "Jonathan",
                lastName= "Swift",
                country= "Ireland",


            };
            authors.Add(author2);
            var author3 = new Author
            {
                Id = 3,
              FirstName = "Daniel",
              lastName= "Defoe",
              country="England"


            };
            authors.Add(author3);
            return authors;
        }

      
    }
}
