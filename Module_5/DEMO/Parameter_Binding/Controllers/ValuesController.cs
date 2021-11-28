using Parameter_Binding.Models;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace Parameter_Binding.Controllers
{
    [RoutePrefix("api/values")]
    public class ValuesController : ApiController
    {
		//Sending a simple parameter in the Url
		// http://localhost:49407/api/values/Demo1?id=2
		[Route("Demo1")]
		[HttpGet]
		public List<List<Parameter_Objects>> Get(int id)
		{
			var list = new List<List<Parameter_Objects>>();

			var parameter_list = new List<Parameter_Objects>
			{
				new Parameter_Objects {Id1 = 3, Id2 = 16, Id3 = 19},
				new Parameter_Objects {Id1 = 26, Id2 = 57, Id3 = 74},
				new Parameter_Objects {Id1 = 951, Id2 = 309, Id3 = 7112}
			};

			list.Add(parameter_list);
			list.Add(parameter_list);
			return list;
		}

		//Sending simple parameters in the Url
		// http://localhost:49407/api/values/Demo2?id1=1&id2=2&id3=3
		[Route("Demo2")]
		[HttpGet]
		public string Get_Parameters(int id1, long id2, double id3)
		{
			return "value";
		}

		//Sending an object in the Url 
		// http://localhost:49407/api/values/Demo3/2/3/4
		[Route("Demo3/{id1}/{id2}/{id3}")]
		[HttpGet]
		public string Get_Parameters_AttributeRouting(int id1, long id2, double id3)
		{
			return "value";
		}

		//Sending simple parameters using attribute routing
		// http://localhost:49407/api/values/Demo4?id1=1&id2=2&id3=3
		[Route("Demo4")]
		[HttpGet]
		public string GetWithUri([FromUri] Parameter_Objects parameter_Obj)
		{
			return "value:" + parameter_Obj.Id1;
		}

		//Sending an object in the Request body
		// User-Agent: Fiddler
		// Host: localhost:49407
		// Content-Length: 32
		// Content-Type: application/json
		//
		// { "Id1" : 2, "Id2": 2, "Id3": 3}
		// http://localhost:49407/api/values/Demo5
		[Route("Demo5")]
		[HttpPost]
		public string GetWithBody([FromBody] Parameter_Objects parameter_Obj)
		{
			return "value:" + parameter_Obj.Id1;
		}

		//Sending a simple list in the Url
		// http://localhost:49407/api/values/Demo6?parameter_Obj=2,parameter_Obj=4,parameter_Obj=9
		[Route("Demo6")]
		[HttpGet]
		public string GetListFromUri([FromUri] List<int> parameter_Obj)
		{
			if (parameter_Obj != null)
			{
				return "recieved a list with length:" + parameter_Obj.Count;
			}

			return "NOTHING RECIEVED...";
		}

	}
}

