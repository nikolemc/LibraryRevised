using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LibraryRevised.DataContext;
using LibraryRevised.Models;
using LibraryRevised.Services;

namespace LibraryRevised.Controllers
{
    public class AvailableBooksController : ApiController
    {

        // GET: localhost:51957/api/availablebooks
        // get all the books that are available
        public IEnumerable<Library> GetCheckedOutBooks()
        {
            return new LibraryService().GetAllBooks().Where(w => w.IsCheckedOut == false).ToList();
            
        }

        
    }
}
