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
    public class UslugaController : ApiController
    {
        private DB_A1E22F_warsztatEntities1 db = new DB_A1E22F_warsztatEntities1();

        // GET: api/Usluga
        public IQueryable<Uslugi> GetUslugi(int id )
        {
            var usluga = from usl in db.Uslugi
                            where usl.id_Uslugi == id
                            select usl;
            return usluga;
        }

        // GET: api/Usluga/5
        //[ResponseType(typeof(Uslugi))]
        //public IHttpActionResult GetUslugi(int id)
        //{
        //    Uslugi uslugi = db.Uslugi.Find(id);
        //    if (uslugi == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(uslugi);
        //}

        // PUT: api/Usluga/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUslugi(int id, Uslugi uslugi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != uslugi.id_Uslugi)
            {
                return BadRequest();
            }

            db.Entry(uslugi).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UslugiExists(id))
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

        // POST: api/Usluga
        [ResponseType(typeof(Uslugi))]
        public IHttpActionResult PostUslugi(Uslugi uslugi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Uslugi.Add(uslugi);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = uslugi.id_Uslugi }, uslugi);
        }

        // DELETE: api/Usluga/5
        [ResponseType(typeof(Uslugi))]
        public IHttpActionResult DeleteUslugi(int id)
        {
            Uslugi uslugi = db.Uslugi.Find(id);
            if (uslugi == null)
            {
                return NotFound();
            }

            db.Uslugi.Remove(uslugi);
            db.SaveChanges();

            return Ok(uslugi);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UslugiExists(int id)
        {
            return db.Uslugi.Count(e => e.id_Uslugi == id) > 0;
        }
    }
}