using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace JSON_Serialization.Controllers
{
    [ApiController]
    //routing done for all methods in controller
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
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
                LastName = "Bhattacharya"
            });

            //add new data to the list
            obj_empList.Add(new Employee()
            {
                EmployeeID = 2,
                FirstName = "Diti",
                LastName = "Roy"
            });

            return obj_empList;
        }
    }
}
