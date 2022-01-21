using Microsoft.EntityFrameworkCore;
using PracticeAPI.Models;

namespace PracticeAPI.DataAceess
{
    public class BookdbContext : DbContext
    {
        public DbSet<Book> books { get; set; }

        public DbSet <Author> Author { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=RASHMI-D ; Database=BookDb; User Id=ras; Password=12345";
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
                lastName= "Rowling",
                country= "England",
                },
             new Author
            {
                Id = 2,
                FirstName = "Jonathan",
                lastName = "Swift",
                country = "Ireland",


            },
         
         new Author
            {
                Id = 3,
                FirstName = "Daniel",
                lastName = "Defoe",
                country = "England"


            }
        });
            modelBuilder.Entity<Book>().HasData(new Book[]
           {
                new Book
            {
                Id = 1,
                Name= "Harry Potter",
                AuthorId = 1,
                type = "Fantasy",
                nOfOpages = 500

            },
          
new Book
            {
                Id = 2,
                Name = "Gulliver’s Travels",
                AuthorId = 2,
                type = "Adventure",
                nOfOpages = 500

            },
         new Book
            {
                Id = 3,
                Name = " Robinson Crusoe ",
                AuthorId = 3,
                type = "Adventure",
                nOfOpages = 300

            },
        });
        }

    }
}
