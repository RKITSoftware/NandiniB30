using MyFirstMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMVCApp.Controllers
{
    public class StudentDataController : Controller
    {
        // GET: StudentData
        //http:/url/StudentData/ShowTheStudentDetail 
        public ActionResult ShowTheStudentDetail()
        {
            StudentData obj_StudentData = new StudentData();
            //create list with various student data
            obj_StudentData.CreateListOfStudents();
            
            //pass the content to view
            return View(obj_StudentData );
        }
    }
}