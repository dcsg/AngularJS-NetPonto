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
    public class ProcessesController : ApiController
    {
        private AngularJS_NetPontoContext db = new AngularJS_NetPontoContext();

        // GET api/Processes
        public IEnumerable<Process> GetProcesses()
        {
            return db.Processes.AsEnumerable();
        }

        // GET api/Processes/5
        public Process GetProcess(int id)
        {
            Process process = db.Processes.Find(id);
            if (process == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return process;
        }

        // PUT api/Processes/5
        public HttpResponseMessage PutProcess(int id, Process process)
        {
            if (ModelState.IsValid && id == process.Id)
            {
                db.Entry(process).State = EntityState.Modified;

                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }

                return Request.CreateResponse(HttpStatusCode.OK, process);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // POST api/Processes
        public HttpResponseMessage PostProcess(Process process)
        {
            if (ModelState.IsValid)
            {
                db.Processes.Add(process);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, process);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = process.Id }));
                return response;
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // DELETE api/Processes/5
        public HttpResponseMessage DeleteProcess(int id)
        {
            Process process = db.Processes.Find(id);
            if (process == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            db.Processes.Remove(process);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            return Request.CreateResponse(HttpStatusCode.OK, process);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}