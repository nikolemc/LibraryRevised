using LibraryRevised.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LibraryRevised.DataContext
{
    public class LibraryContext :DbContext
    {

        public LibraryContext():base("name=DefaultConnection")
        {

        }

        public DbSet<Library> Library{ get; set; }

        internal object LibraryService()
        {
            throw new NotImplementedException();
        }
        //public IEnumerable<LibraryRevised> Books { get; internal set; }
    }
}