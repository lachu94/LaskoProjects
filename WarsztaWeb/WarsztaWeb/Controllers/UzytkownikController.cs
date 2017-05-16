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
using WarsztaWeb.Models;

namespace WarsztaWeb.Controllers
{
    public class UzytkownikController : ApiController
    {
        private WarsztatEntities db = new WarsztatEntities();

        // GET: api/Uzytkownik
        public IQueryable<Uzytkownicy> GetUzytkownicy()
        {
            return db.Uzytkownicy;
        }

        // GET: api/Uzytkownik/5
        [ResponseType(typeof(Uzytkownicy))]
        public IHttpActionResult GetUzytkownicy(int id)
        {
            Uzytkownicy uzytkownicy = db.Uzytkownicy.Find(id);
            if (uzytkownicy == null)
            {
                return NotFound();
            }

            return Ok(uzytkownicy);
        }

        // PUT: api/Uzytkownik/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUzytkownicy(int id, Uzytkownicy uzytkownicy)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != uzytkownicy.id_Uzytkownika)
            {
                return BadRequest();
            }

            db.Entry(uzytkownicy).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UzytkownicyExists(id))
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

        // POST: api/Uzytkownik
        [ResponseType(typeof(Uzytkownicy))]
        public IHttpActionResult PostUzytkownicy(Uzytkownicy uzytkownicy)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Uzytkownicy.Add(uzytkownicy);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = uzytkownicy.id_Uzytkownika }, uzytkownicy);
        }

        // DELETE: api/Uzytkownik/5
        [ResponseType(typeof(Uzytkownicy))]
        public IHttpActionResult DeleteUzytkownicy(int id)
        {
            Uzytkownicy uzytkownicy = db.Uzytkownicy.Find(id);
            if (uzytkownicy == null)
            {
                return NotFound();
            }

            db.Uzytkownicy.Remove(uzytkownicy);
            db.SaveChanges();

            return Ok(uzytkownicy);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UzytkownicyExists(int id)
        {
            return db.Uzytkownicy.Count(e => e.id_Uzytkownika == id) > 0;
        }
    }
}