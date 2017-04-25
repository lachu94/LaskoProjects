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
using WarsztatWS.Models;

namespace WarsztatWS.Controllers
{
    public class KlientController : ApiController
    {
        private DB_A1E22F_warsztatEntities1 db = new DB_A1E22F_warsztatEntities1();

        // GET: api/Klient
        public IQueryable<Klienci> GetKlienci()
        {
            return db.Klienci;
        }

        // GET: api/Klient/5
        [ResponseType(typeof(Klienci))]
        public IHttpActionResult GetKlienci(int id)
        {
            Klienci klienci = db.Klienci.Find(id);
            if (klienci == null)
            {
                return NotFound();
            }

            return Ok(klienci);
        }

        // PUT: api/Klient/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutKlienci(int id, Klienci klienci)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != klienci.id_Klienta)
            {
                return BadRequest();
            }

            db.Entry(klienci).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KlienciExists(id))
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

        // POST: api/Klient
        [ResponseType(typeof(Klienci))]
        public IHttpActionResult PostKlienci(Klienci klienci)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Klienci.Add(klienci);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = klienci.id_Klienta }, klienci);
        }

        // DELETE: api/Klient/5
        [ResponseType(typeof(Klienci))]
        public IHttpActionResult DeleteKlienci(int id)
        {
            Klienci klienci = db.Klienci.Find(id);
            if (klienci == null)
            {
                return NotFound();
            }

            db.Klienci.Remove(klienci);
            db.SaveChanges();

            return Ok(klienci);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool KlienciExists(int id)
        {
            return db.Klienci.Count(e => e.id_Klienta == id) > 0;
        }
    }
}