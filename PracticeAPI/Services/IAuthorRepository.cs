using PracticeAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeAPI.Services
{
   public interface IAuthorRepository
    {
        public List<Author> AllAuthors();
        public Author getAuthor(int id);
        public Author AddAuthor(Author author);
        public void DeleteAuthor(Author author);


    }
}
