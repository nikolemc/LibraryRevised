using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using LibraryRevised.DataContext;
using LibraryRevised.Models;
using LibraryRevised.Services;

namespace LibraryRevised.Controllers
{
    public class LibrariesController : ApiController
    {
        private LibraryContext db = new LibraryContext();

        // GET: api/Libraries
        public IEnumerable<Library> GetLibrary()
        {
            return new LibraryService().GetAllBooks();
        }

        // GET: api/Libraries/5
        [HttpGet]
        public IHttpActionResult GetLibrary(int id)
        {
            Library library = db.Library.Find(id);
            if (library == null)
            {
                return NotFound();
            }

            return Ok(library);
        }

        // PUT: api/Libraries/5
        [HttpPut]
        public IHttpActionResult PutLibrary(int id, Library library)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != library.Id)
            {
                return BadRequest();
            }

            db.Entry(library).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LibraryExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Libraries
        [HttpPost]
        public IHttpActionResult PostLibrary(Library library)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Library.Add(library);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = library.Id }, library);
        }

        // DELETE: api/Libraries/5
        [HttpDelete]
        public IHttpActionResult DeleteLibrary(int id)
        {
            Library library = db.Library.Find(id);
            if (library == null)
            {
                return NotFound();
            }

            db.Library.Remove(library);
            db.SaveChanges();

            return Ok(library);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LibraryExists(int id)
        {
            return db.Library.Count(e => e.Id == id) > 0;
        }
    }
}