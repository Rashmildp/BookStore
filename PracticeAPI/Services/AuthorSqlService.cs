using PracticeAPI.DataAceess;
using PracticeAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeAPI.Services
{
    public class AuthorSqlService : IAuthorRepository
    {
        private readonly BookdbContext _context = new BookdbContext();
        public List<Author> AllAuthors()
        {
            return _context.Author.ToList();
        }

      

          public  Author getAuthor(int id)
        {
            return _context.Author.Find(id);
        }
    }
}
