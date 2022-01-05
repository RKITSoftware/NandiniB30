using System.Collections.Generic;
using System.Web.Http;
using CRUD_Demo.Models;

namespace CRUD_Demo.Controllers
{
    public class TutorController : ApiController
    {
        BLTutor objdatabase = new BLTutor();

        /// <summary>
        /// Get all tutor data
        /// </summary>
        /// <returns>
        /// returns a tutor data
        /// </returns>
        [HttpGet]
        [Route("api/Getall")]
        public List<Tutor> GetAll()
        {
            return (objdatabase.selectAll());
        }

        /// <summary>
        /// Get tutor data of particular parameter 'id'
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// returns tutor data according to the ID
        /// </returns>
        [HttpGet]
        [Route("api/Get/{id}")]
        public Tutor Get(int id)
        {
            return (objdatabase.getTutorById(id));
        }

        /// <summary>
        /// Add new tutor data
        /// </summary>
        /// <param name="tutoring">
        /// tutoring is the tutor object.
        /// </param>
        [HttpPost]
        [Route("api/Add")]
        public void Add([FromBody]Tutor tutoring)
        {
            objdatabase.addTutor(tutoring);
        }


        /// <summary>
        /// Update tutor data
        /// </summary>
        /// <param name="tutoring">
        /// tutoring is the tutor object.
        /// </param>
        [HttpPost]
        [Route("api/Update")]
        public void Update([FromBody] Tutor tutoring)
        {
            objdatabase.updateTutor(tutoring);
        }

        /// <summary>
        /// Delete tutor data with parameter 'id'
        /// </summary>
        [HttpDelete]
        [Route("api/Delete/{id}")]
        public void Delete(int id)
        {
            objdatabase.deleteTutor(id);
        }
    }
}
