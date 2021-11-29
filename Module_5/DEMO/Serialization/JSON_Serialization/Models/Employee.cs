using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Serialization_JSON.Models
{
    public class Employee
    {
        //name the properties for the list
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Location Location { get; set; }
    }

    public class Location
    {
        public string PinCode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }

}