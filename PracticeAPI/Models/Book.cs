using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeAPI.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string type { get; set; }
        public string Author { get; set; }
        public int nOfOpages { get; set; }
    }
}
