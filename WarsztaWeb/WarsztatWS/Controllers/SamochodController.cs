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
    public class SamochodController : ApiController
    {
        private WorkShop db = new WorkShop();

        // GET: api/Samochod
        public IQueryable<Samochody> GetSamochody(int id)
        {
            return db.Samochody.Where(s => s.id_Klienta == id);
        }

        // GET: api/Samochod/5
        //[ResponseType(typeof(Samochody))]
        //public IHttpActionResult GetSamochody(int id)
        //{
        //    Samochody samochody = db.Samochody.Find(id);
        //    if (samochody == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(samochody);
        //}

        // PUT: api/Samochod/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSamochody(int id, Samochody samochody)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != samochody.id_Samochodu)
            {
                return BadRequest();
            }

            db.Entry(samochody).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SamochodyExists(id))
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

        // POST: api/Samochod
        [ResponseType(typeof(Samochody))]
        public IHttpActionResult PostSamochody(Samochody samochody)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Samochody.Add(samochody);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = samochody.id_Samochodu }, samochody);
        }

        // DELETE: api/Samochod/5
        [ResponseType(typeof(Samochody))]
        public IHttpActionResult DeleteSamochody(int id)
        {
            Samochody samochody = db.Samochody.Find(id);
            if (samochody == null)
            {
                return NotFound();
            }

            db.Samochody.Remove(samochody);
            db.SaveChanges();

            return Ok(samochody);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SamochodyExists(int id)
        {
            return db.Samochody.Count(e => e.id_Samochodu == id) > 0;
        }
    }
}