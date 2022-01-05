using System;

namespace SerializationJSON
{
    /// <summary>
    /// Class Tutor contains four attributes that are to be serialized.
    /// </summary>
    [Serializable]
    class Tutor
    {
        public int TutorID { get; set; }
        public string TutorName { get; set; }
        public string TutorEmail { get; set; }
        public string Subject_to_Teach { get; set; }
    }
}
