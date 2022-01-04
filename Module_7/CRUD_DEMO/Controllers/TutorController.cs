using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CRUD_Demo.Models;

namespace CRUD_Demo.Controllers
{
    public class TutorController : ApiController
    {
        database_DB objdatabase = new database_DB();

        // GET: api/Book
        [Route("api/Getall")]
        public List<Tutor> GetAll()
        {
            return (objdatabase.selectAll());
        }

        // GET: api/Book/5
        [Route("api/Get/{id}")]
        public Tutor Get(int id)
        {
            return (objdatabase.getTutorById(id));
        }

        // POST: api/Book
        [HttpPost]
        [Route("api/Add")]
        public void Add([FromBody]Tutor tutoring)
        {
            objdatabase.addTutor(tutoring);
        }

        [HttpPost]
        [Route("api/Update")]
        public void Update([FromBody] Tutor tutoring)
        {
            objdatabase.updateTutor(tutoring);
        }

        // DELETE: api/Book/5
        [Route("api/Delete/{id}")]
        public void Delete(int id)
        {
            objdatabase.deleteTutor(id);
        }
    }
}
