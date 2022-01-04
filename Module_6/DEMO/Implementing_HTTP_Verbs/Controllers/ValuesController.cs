using System.Collections.Generic;
using System.Web.Http;

namespace Implementing_HTTP_Verbs.Controllers
{
    [RoutePrefix("api/values")]
    public class ValuesController : ApiController
    {
        //create a list of books
        static List<string> obj_books = new List<string>()
        {
            "Wheel of Time","The Fault of our Stars","Golden Couple"
        };

        //This gives result to GET method without parameter
        [Route("")]
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return obj_books;
        }

        [Route("{int:id}")]
        [HttpGet]
        public string Get(int id)
        {
            return obj_books[id];
        }

        //used to create new item
        [Route("")]
        [HttpPost]
        public void Post([FromBody] string value)
        {
            obj_books.Add(value);
        }

        //used to update an item: "id" is what we update with "value"
        [Route("int:id")]
        [HttpPut]
        public void Put(int id, [FromBody] string value)
        {
            obj_books[id] = value;
        }

        //used to remove an item
        [Route("int:id")]
        [HttpDelete]
        public void Delete(int id)
        {
            obj_books.RemoveAt(id);
        }
    }
}
