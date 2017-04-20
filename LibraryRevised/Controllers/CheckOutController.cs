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
    public class CheckOutController : ApiController
    {

        //// GET: localhost:51957/api/checkout
        ////	to get all the books that are checked out, and when the book is expected to come back
        //public IEnumerable<Library> GetCheckedOutBooks()
        //{
        //    return new LibraryService().GetAllBooks().Where(w => w.IsCheckedOut == true).ToList();

        //}

        public IHttpActionResult CheckOutBook(int id)
        {
            var service = new LibraryService();
            var book = service.GetOneBook(id);
            if (book.IsCheckedOut) //so the book is not in the library
            {
                return Ok(new {ResponseMessage = "This book is unavailable", book.DueBackDate});
            }
                
            
            else//so the book is in the library and check it out
            {
                service.CheckOutBook(book);
                return Ok(book);
            }


        }
    }
}
