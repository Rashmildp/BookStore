using PracticeAPI.DataAceess;
using PracticeAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeAPI.Services
{
    public class BookSqlService : IbookRepository
    {
        private readonly BookdbContext _context = new BookdbContext();
        public List<Book> AllBooks()
        {
            return _context.Books.ToList();
            
        }

      public   Book GetBook(int id)
        {
            return _context.Books.Find(id);
           
        }
    }
}
