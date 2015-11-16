namespace BookService.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BookService.Models.BookServiceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BookService.Models.BookServiceContext context)
        {
            context.Authors.AddOrUpdate(x => x.Id,
                    new Author() { Id = 1, Name = "Stephen King"},
                    new Author() { Id = 2, Name = "Dan Borwn"},
                    new Author() { Id = 3, Name = "Patricia Cornwell" }
            );
            context.Books.AddOrUpdate(x => x.Id,
                    new Book() { Id = 1, Title = "The Stand", Year = 1978, AuthorId = 1, Price = 9.99M, Genre = "Science Fiction"},
                    new Book() { Id = 2, Title = "Carrie", Year = 1974, AuthorId = 1, Price = 11.65M, Genre = "Horror"},
                    new Book() { Id = 3, Title = "The Da Vinci Code", Year = 2003, AuthorId = 2, Price = 12.95M, Genre = "Adventure"},
                    new Book() { Id = 4, Title = "Postmortem", Year = 1977, AuthorId = 3, Price = 7.12M, Genre = "Action"}    
            );
        }
    }
}
