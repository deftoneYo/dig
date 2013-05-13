using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dig.Data.Models;
using Dig.MvcWeb.Models;


namespace Dig.MvcWeb.Controllers
{
    public class EventsController : ApiController
	{
		private readonly DigDbContext _db = new DigDbContext();

		// GET api/Events
		public IEnumerable<Event> GetEvents()
		{
			return _db.Events.AsEnumerable();
		}

		// GET api/Events/5
		public Event GetEvent(int id)
		{
			var digEvent = _db.Events.Find(id);
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
				_db.Entry(digEvent).State = EntityState.Modified;

				try
				{
					_db.SaveChanges();
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
				_db.Events.Add(digEvent);
				_db.SaveChanges();

				var response = Request.CreateResponse(HttpStatusCode.Created, digEvent);
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
			Event digEvent = _db.Events.Find(id);
			if (digEvent == null)
			{
				return Request.CreateResponse(HttpStatusCode.NotFound);
			}

			_db.Events.Remove(digEvent);

			try
			{
				_db.SaveChanges();
			}
			catch (DbUpdateConcurrencyException)
			{
				return Request.CreateResponse(HttpStatusCode.NotFound);
			}

			return Request.CreateResponse(HttpStatusCode.OK, digEvent);
		}

		protected override void Dispose(bool disposing)
		{
			_db.Dispose();
			base.Dispose(disposing);
		}
	}
}
