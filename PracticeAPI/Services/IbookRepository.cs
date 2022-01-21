using PracticeAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeAPI.Services
{
   public interface IbookRepository
    {
        public List<Book> AllBooks();
        public Book GetBook(int id);
    }
}
