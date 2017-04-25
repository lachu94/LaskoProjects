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
    public class PracownikController : ApiController
    {
        private DB_A1E22F_warsztatEntities1 db = new DB_A1E22F_warsztatEntities1();

        // GET: api/Pracownik
        public IQueryable<Pracownicy> GetPracownicy()
        {
            return db.Pracownicy;
        }

        // GET: api/Pracownik/5
        [ResponseType(typeof(Pracownicy))]
        public IHttpActionResult GetPracownicy(int id)
        {
            Pracownicy pracownicy = db.Pracownicy.Find(id);
            if (pracownicy == null)
            {
                return NotFound();
            }

            return Ok(pracownicy);
        }

        // PUT: api/Pracownik/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPracownicy(int id, Pracownicy pracownicy)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pracownicy.id_Pracownika)
            {
                return BadRequest();
            }

            db.Entry(pracownicy).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PracownicyExists(id))
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

        // POST: api/Pracownik
        [ResponseType(typeof(Pracownicy))]
        public IHttpActionResult PostPracownicy(Pracownicy pracownicy)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Pracownicy.Add(pracownicy);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = pracownicy.id_Pracownika }, pracownicy);
        }

        // DELETE: api/Pracownik/5
        [ResponseType(typeof(Pracownicy))]
        public IHttpActionResult DeletePracownicy(int id)
        {
            Pracownicy pracownicy = db.Pracownicy.Find(id);
            if (pracownicy == null)
            {
                return NotFound();
            }

            db.Pracownicy.Remove(pracownicy);
            db.SaveChanges();

            return Ok(pracownicy);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PracownicyExists(int id)
        {
            return db.Pracownicy.Count(e => e.id_Pracownika == id) > 0;
        }
    }
}