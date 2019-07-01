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
using EstablishmentCategories.Models;

namespace EstablishmentCategories.Controllers
{
    public class EstablishmentsController : ApiController
    {
        private EstablishmentCategoriesContext db = new EstablishmentCategoriesContext();

        // GET: api/Establishments
        public IQueryable<Establishment> GetEstablishments()
        {
            return db.Establishments;
        }

        // GET: api/Establishments/5
        [ResponseType(typeof(Establishment))]
        public IHttpActionResult GetEstablishment(long id)
        {
            Establishment establishment = db.Establishments.Find(id);
            if (establishment == null)
            {
                return NotFound();
            }

            return Ok(establishment);
        }

        // PUT: api/Establishments/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEstablishment(long id, Establishment establishment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != establishment.Id)
            {
                return BadRequest();
            }

            db.Entry(establishment).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EstablishmentExists(id))
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

        // POST: api/Establishments
        [ResponseType(typeof(Establishment))]
        public IHttpActionResult PostEstablishment(Establishment establishment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Establishments.Add(establishment);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = establishment.Id }, establishment);
        }

        // DELETE: api/Establishments/5
        [ResponseType(typeof(Establishment))]
        public IHttpActionResult DeleteEstablishment(long id)
        {
            Establishment establishment = db.Establishments.Find(id);
            if (establishment == null)
            {
                return NotFound();
            }

            db.Establishments.Remove(establishment);
            db.SaveChanges();

            return Ok(establishment);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EstablishmentExists(long id)
        {
            return db.Establishments.Count(e => e.Id == id) > 0;
        }
    }
}