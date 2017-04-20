namespace LibraryRevised.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using LibraryRevised.Models;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<LibraryRevised.DataContext.LibraryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LibraryRevised.DataContext.LibraryContext context)
        {
            var books = new List<Library>
            {
                new Library{Title = "Diary of a Player: How My Musical Heroes Made a Guitar Man Out of Me", Author = " Brad Paisley and David Wild", YearPublished = 1998 , Genre = "ACTION", IsCheckedOut = false, LastCheckedOutDate = null, DueBackDate = null, ResponseMessage = "null"},
                new Library{Title = "Come and Play, Bunny!", Author = "Nick Ellsworth", YearPublished = 2017 , Genre = "CHILDREN", IsCheckedOut = false, LastCheckedOutDate = null, DueBackDate = null, ResponseMessage = "null" },
                new Library{Title = "Food & Wine: Best New Chefs Cookbook", Author = "The Editors Of Food & Wine", YearPublished = 2015 , Genre = "COOKING", IsCheckedOut = false, LastCheckedOutDate = null , DueBackDate = null, ResponseMessage = "null"},
                new Library{Title = "The French Isles", Author = "Mowat Claire", YearPublished = 2011 , Genre = "FICTION", IsCheckedOut = true, LastCheckedOutDate = new DateTime(2017,04,19), DueBackDate = new DateTime(2017,04,28), ResponseMessage = "null" },
                new Library{Title = "Houseplant Basics", Author = "David Squire", YearPublished = 2015 , Genre = "GARDENING", IsCheckedOut = false, LastCheckedOutDate = null, DueBackDate = null, ResponseMessage = "null" },
                new Library{Title = "How To Heal", Author = "Jeff Kane, M.D.", YearPublished = 2016 , Genre = "HEALTH & FITNESS", IsCheckedOut = false, LastCheckedOutDate = null, DueBackDate = null , ResponseMessage = "null" },


            };

             books.ForEach(Library => {
                 context.Library.AddOrUpdate(b => b.Title, Library);
             });
            //b.IsCheckedOut, b.LastCheckedOutDate, b.DueBackDate, b.ResponseMessage
            // books.ForEach(b => context.Library.AddOrUpdate(b));
            context.SaveChanges();

            
    }
    }
}
