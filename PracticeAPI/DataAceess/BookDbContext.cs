using Microsoft.EntityFrameworkCore;
using PracticeAPI.Models;

namespace PracticeAPI.DataAceess
{
    public class BookdbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
   
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=RASHMI-D ; Database=BOOKSTORE; User Id=ras; Password=12345";
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(new Author[]
      {
               new Author
                {
                      Id = 1,
                FirstName= "J. K.",
                LastName= "Rowling",
                Country= "England",
                },
             new Author
            {
                Id = 2,
                FirstName = "Jonathan",
                LastName = "Swift",
                Country = "Ireland",


            },

         new Author
            {
                Id = 3,
                FirstName = "Daniel",
                LastName = "Defoe",
                Country = "England"


            }
   });

            modelBuilder.Entity<Book>().HasData(new Book[]
           {
                new Book
            {
                Id = 1,
                Name= "Harry Potter",
                AuthorId = 1,
                Type = "Fantasy",
                NofOpages = 500

            },
          
new Book
            {
                Id = 2,
                Name = "Gulliver’s Travels",
                AuthorId = 2,
                Type = "Adventure",
                NofOpages = 500

            },
         new Book
            {
                Id = 3,
                Name = " Robinson Crusoe ",
                AuthorId = 3,
                Type = "Adventure",
                NofOpages = 300

            },
        });

        
        }

    }
}
