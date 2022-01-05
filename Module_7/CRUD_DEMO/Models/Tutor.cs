using System;
using System.ComponentModel.DataAnnotations;

namespace CRUD_Demo.Models
{
    /// <summary>
    /// Class Tutor contains public attributes .
    /// </summary>
    public class Tutor
    {
        /// <summary>
        /// primary key - TutorID
        /// </summary>
        [Key]
        public int TutorID { get; set; }

        /// <summary>
        /// Required field- TutorName, maximum of 30 characters
        /// </summary>
        [StringLength(20, ErrorMessage = "Name must be max 30 character.")]
        [Required(ErrorMessage = "Name is Required.")]
        public string TutorName { get; set; }

        /// <summary>
        /// Required field- Subject_to_Teach
        /// </summary>
        [Required(ErrorMessage = "Field is Required.")]
        public string Subject_to_Teach { get; set; }
    }
}