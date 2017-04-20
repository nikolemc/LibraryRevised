using LibraryRevised.DataContext;
using System;
using System.Collections.Generic;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using LibraryRevised.Models;


namespace LibraryRevised.Services
{
    public class LibraryService
    {

        private LibraryContext db = new LibraryContext();

        public IEnumerable<Library> GetAllBooks()
        {
            return db.Library;
        }

        public Library GetOneBook(int id)
        {
            return db.Library.FirstOrDefault(f => f.Id == id);
        }

        internal void CheckOutBook(Library book)
        {
            book.IsCheckedOut = true;
            book.LastCheckedOutDate = DateTime.Now;
            book.DueBackDate = DateTime.Now.AddDays(10);
            db.SaveChanges();
        }
    }
}