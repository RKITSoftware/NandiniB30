using System.Text.Json;
using Serialization_JSON.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace Serialization_JSON.Controllers
{
    public class SerializeController : ApiController
    {
        [HttpGet]
        public List<Employee> Get()
        {
            //create an object
            List<Employee> obj_empList = new List<Employee>();

            //add new data to the list
            obj_empList.Add(new Employee()
            {
                    EmployeeID = 1,
                    FirstName = "Nandini",
                    LastName = "Bhattacharya",
                    Location = new Location { Country = "India", State = "Gujarat", PinCode = "360005" }
            });

            //add new data to the list
            obj_empList.Add(new Employee()
            {
                    EmployeeID = 2,
                    FirstName = "Diti",
                    LastName = "Roy",
                    Location = new Location { Country = "India", State = "Rajasthan", PinCode = "1234" },
            });
                
             //serialize the object to JSON string
            JsonSerializer.Serialize(obj_empList);
            return obj_empList;
        }
    }
}

