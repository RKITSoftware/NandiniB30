using System.Collections.Generic;
using System.Web.Http;

namespace Implementing_HTTP_Verbs.Controllers
{
    [RoutePrefix("api/values")]
    public class ValuesController : ApiController
    {
        /// <summary>
        /// create a list of string type of books 
        /// </summary>
        static List<string> obj_books = new List<string>()
        {
            "Wheel of Time","The Fault of our Stars","Golden Couple"
        };

        /// <summary>
        ///Get all the book data
        /// </summary>
        /// <returns>
        /// book data
        /// </returns>
        [HttpGet]
        [Route("")]
        public IEnumerable<string> Get()
        {
            return obj_books;
        }

        /// <summary>
        /// Get all the book data
        /// </summary>
        /// <param name="id"> id is an unique identifier
        /// Book model field- id,value
        /// </param>
        /// <returns>
        /// book data of that particular parameter 'id'
        /// </returns>
        [HttpGet]
        [Route("{int:id}")]
        public string Get(int id)
        {
            return obj_books[id];
        }

        /// <summary>
        /// Insert book data
        /// </summary>
        /// <param name="value">value contains the name of the book
        /// Book model field- id,value
        /// </param>
        [HttpPost]
        [Route("")]
        public void Post([FromBody] string value)
        {
            obj_books.Add(value);
        }

        /// <summary>
        /// Update book data: book with parameter 'id' is updated with book of parameter 'value'
        /// </summary>
        /// <param name="id">id is an unique identifier</param>
        /// <param name="value">value contains the name of the book</param>
        [HttpPut]
        [Route("int:id")]
        public void Put(int id, [FromBody] string value)
        {
            obj_books[id] = value;
        }

        /// <summary>
        /// Delete a book data with particular parameter 'id'
        /// </summary>
        /// <param name="id">id is an unique identifier
        /// Book model field- id,value
        /// </param>
        [Route("int:id")]
        [HttpDelete]
        public void Delete(int id)
        {
            obj_books.RemoveAt(id);
        }
    }
}
