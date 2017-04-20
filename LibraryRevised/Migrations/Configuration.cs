namespace LibraryRevised.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LibraryRevised.DataContext.LibraryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LibraryRevised.DataContext.LibraryContext context)
        {
            var book = new System.Collections.Generic.List<Models.Library>
            {
                new Models.Library{Title = " Diary of a Player: How My Musical Heroes Made a Guitar Man Out of Me ", Author = " Brad Paisley and David Wild", YearPublished = 1998 , Genre = "ACTION", IsCheckedOut = false, LastCheckedOutDate = null, DueBackDate = null, ResponseMessage = "null"},
                new Models.Library{Title = "Come and Play, Bunny!", Author = "Nick Ellsworth", YearPublished = 2017 , Genre = "CHILDREN", IsCheckedOut = false, LastCheckedOutDate = null, DueBackDate = null, ResponseMessage = "null" },
                new Models.Library{Title = "Food & Wine: Best New Chefs Cookbook", Author = "The Editors Of Food & Wine", YearPublished = 2015 , Genre = "COOKING", IsCheckedOut = false, LastCheckedOutDate = null , DueBackDate = null, ResponseMessage = "null"},
                new Models.Library{Title = "The French Isles", Author = "Mowat Claire", YearPublished = 2011 , Genre = "FICTION", IsCheckedOut = false, LastCheckedOutDate = null, DueBackDate = null, ResponseMessage = "null" },
                new Models.Library{Title = "Houseplant Basics", Author = "David Squire", YearPublished = 2015 , Genre = "GARDENING", IsCheckedOut = false, LastCheckedOutDate = null, DueBackDate = null, ResponseMessage = "null" },
                new Models.Library{Title = "How To Heal", Author = "Jeff Kane, M.D.", YearPublished = 2016 , Genre = "HEALTH & FITNESS", IsCheckedOut = false, LastCheckedOutDate = null, DueBackDate = null , ResponseMessage = "null" },


            };

            context.Library.AddOrUpdate(a => a.Title, book.First());
            context.SaveChanges();

            
    }
    }
}
