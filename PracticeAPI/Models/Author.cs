using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeAPI.Models
{
    public class Author
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(10)]
        public string FirstName { get; set; }
        [MaxLength(10)]
        public string lastName { get; set; }
        [MaxLength(10)]
        public string country { get; set; }
        
        public ICollection<Book> books { get; set; } = new List<Book>();


    }
}
