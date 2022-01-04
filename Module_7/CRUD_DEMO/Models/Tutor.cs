using System;
using System.ComponentModel.DataAnnotations;

namespace CRUD_Demo.Models
{
    public class Tutor
    {
        [Key]
        public int TutorID { get; set; }
        public string TutorName { get; set; }
        public string Subject_to_Teach { get; set; }
    }
}