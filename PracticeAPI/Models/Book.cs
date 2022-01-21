using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeAPI.Models
{
    public class Book
    {
        public int Id { get; set; }
       
     
        public string Name { get; set; }
      
        public string type { get; set; }

        public int nOfOpages { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }



    }
}
