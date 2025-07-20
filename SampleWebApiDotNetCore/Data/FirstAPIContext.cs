using Microsoft.EntityFrameworkCore;
using SampleWebApiDotNetCore.Model;

namespace SampleWebApiDotNetCore.Data
{
    public class FirstAPIContext : DbContext
    {
        public FirstAPIContext(DbContextOptions<FirstAPIContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id=1,
                Title="tesT",
                Author="AAA",
                YearPublished=1991
            },
            new Book
            {
                Id=2,
                Title="tesT2",
                Author="BBB",
                YearPublished=1993
            },
            new Book
            {
                Id=3,
                Title="tesT3",
                Author="CCC",
                YearPublished=1945
            });
        }
        public DbSet<Book> books { get; set; } 
    }

}

