using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstMVCApp.Models
{
    //class to contain the properties
    public class Student
    {
        public int id;
        public String Name;
        public String Branch;
    }
    public class StudentData
    {
        //create a list
        public List<Student> listStudent { get; set; }

        //method to populate the list
        public void CreateListOfStudents()
        {
            listStudent = new List<Student>();
            
            //information of a new student
            Student obj_Student = new Student();
            obj_Student.id = 1001;
            obj_Student.Name = "Nandini Bhattacharya";
            obj_Student.Branch = "Computer Science";

            //add the student to the list
            listStudent.Add(obj_Student);

            //information of a new student
            obj_Student = new Student();
            obj_Student.id = 1002;
            obj_Student.Name = "Diti Roy";
            obj_Student.Branch = "Mechanics";

            //add the student to the list
            listStudent.Add(obj_Student);

            //information of a new student
            obj_Student = new Student();
            obj_Student.id = 1003;
            obj_Student.Name = "Debjit Kumar";
            obj_Student.Branch = "Civil";

            //add the student to the list
            listStudent.Add(obj_Student); 
        }
    }
}