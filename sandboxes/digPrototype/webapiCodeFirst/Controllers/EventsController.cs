using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using webapiCodeFirst.Models;

namespace webapiCodeFirst.Controllers
{
    public class EventsController : ApiController
    {
        private EventsContext db = new EventsContext();

        // GET api/Events
        public IEnumerable<Event> GetEvents()
        {
            return db.Events.AsEnumerable();
        }

        // GET api/Events/5
        public Event GetEvent(int id)
        {
            Event digEvent = db.Events.Find(id);
            if (digEvent == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return digEvent;
        }

        // PUT api/Events/5
        public HttpResponseMessage PutEvent(int id, Event digEvent)
        {
            if (ModelState.IsValid && id == digEvent.Id)
            {
                db.Entry(digEvent).State = EntityState.Modified;

                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }

                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // POST api/Events
        public HttpResponseMessage PostEvent(Event digEvent)
        {
            if (ModelState.IsValid)
            {
                db.Events.Add(digEvent);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, digEvent);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = digEvent.Id }));
                return response;
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // DELETE api/Events/5
        public HttpResponseMessage DeleteEvent(int id)
        {
            Event digEvent = db.Events.Find(id);
            if (digEvent == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            db.Events.Remove(digEvent);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

			return Request.CreateResponse(HttpStatusCode.OK, digEvent);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}