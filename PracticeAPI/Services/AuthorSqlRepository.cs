using PracticeAPI.DataAceess;
using PracticeAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeAPI.Services
{
    public class AuthorSqlRepository : IAuthorRepository
    {
        private readonly BookdbContext _context = new BookdbContext();
        public List<Author> AllAuthors()
        {
            return _context.Authors.ToList();
        }



        public Author getAuthor(int id)
        {
            return _context.Authors.Find(id);
        }
        public Author AddAuthor(Author author)
        {
            _context.Authors.Add(author);
            _context.SaveChanges();
            return _context.Authors.Find(author.Id);
        }
        public void DeleteAuthor(Author author)
        {
            _context.Remove(author);
            _context.SaveChanges();
        }
    }
}
