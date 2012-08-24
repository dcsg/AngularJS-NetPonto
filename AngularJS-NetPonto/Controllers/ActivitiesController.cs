using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using AngularJS_NetPonto.Models;

namespace AngularJS_NetPonto.Controllers
{
    public class ActivitiesController : ApiController
    {
        private AngularJS_NetPontoContext db = new AngularJS_NetPontoContext();

        // GET api/Activities
        public IEnumerable<Activity> GetActivities()
        {
            return db.Activities.AsEnumerable();
        }

        // GET api/Activities/5
        public Activity GetActivity(int id)
        {
            Activity activity = db.Activities.Find(id);
            if (activity == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return activity;
        }

        // PUT api/Activities/5
        public HttpResponseMessage PutActivity(int id, Activity activity)
        {
            if (ModelState.IsValid && id == activity.Id)
            {
                db.Entry(activity).State = EntityState.Modified;

                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }

                return Request.CreateResponse(HttpStatusCode.OK, activity);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // POST api/Activities
        public HttpResponseMessage PostActivity(Activity activity)
        {
            if (ModelState.IsValid)
            {
                db.Activities.Add(activity);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, activity);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = activity.Id }));
                return response;
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // DELETE api/Activities/5
        public HttpResponseMessage DeleteActivity(int id)
        {
            Activity activity = db.Activities.Find(id);
            if (activity == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            db.Activities.Remove(activity);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            return Request.CreateResponse(HttpStatusCode.OK, activity);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}