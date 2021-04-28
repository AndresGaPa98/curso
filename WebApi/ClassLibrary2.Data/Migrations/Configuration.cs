namespace ClassLibrary2.Data.Migrations
{
    using ClassLibrary2.Data.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ClassLibrary2.Data.ApiContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ClassLibrary2.Data.ApiContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            Book book = new Book();
            book.Titulo = "El principito";
            book.Price = 14.95;
            book.genre = "Fantasy";
            book.publishDate = new DateTime(2000, 12, 16);
            book.Description = "A former architect battles an evil sorceress.";
            context.books.AddOrUpdate(book);
            context.SaveChanges();
        }
    }
}
