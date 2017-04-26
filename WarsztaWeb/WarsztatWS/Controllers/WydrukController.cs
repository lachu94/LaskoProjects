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
    public class WydrukController : ApiController
    {
        private DB_A1E22F_warsztatEntities1 db = new DB_A1E22F_warsztatEntities1();

        // GET: api/Wydruk
        public IQueryable<Wydruk> GetWydruk()
        {
            return db.Wydruk;
        }

        // GET: api/Wydruk/5
        [ResponseType(typeof(Wydruk))]
        public IHttpActionResult GetWydruk(int id)
        {
            Wydruk wydruk = db.Wydruk.Find(id);
            if (wydruk == null)
            {
                return NotFound();
            }

            return Ok(wydruk);
        }

        // PUT: api/Wydruk/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutWydruk(int id, Wydruk wydruk)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != wydruk.id_Wydruku)
            {
                return BadRequest();
            }

            db.Entry(wydruk).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WydrukExists(id))
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

        // POST: api/Wydruk
        [ResponseType(typeof(Wydruk))]
        public IHttpActionResult PostWydruk(Wydruk wydruk)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Wydruk.Add(wydruk);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = wydruk.id_Wydruku }, wydruk);
        }

        // DELETE: api/Wydruk/5
        [ResponseType(typeof(Wydruk))]
        public IHttpActionResult DeleteWydruk(int id)
        {
            Wydruk wydruk = db.Wydruk.Find(id);
            if (wydruk == null)
            {
                return NotFound();
            }

            db.Wydruk.Remove(wydruk);
            db.SaveChanges();

            return Ok(wydruk);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool WydrukExists(int id)
        {
            return db.Wydruk.Count(e => e.id_Wydruku == id) > 0;
        }
    }
}