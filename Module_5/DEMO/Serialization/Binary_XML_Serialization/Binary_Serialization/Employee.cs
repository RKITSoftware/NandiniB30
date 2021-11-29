using System;

namespace WindowsForms_Serialization
{
    //make a class named Employee and put [Serializable] on top of it to serialize
    [Serializable]
    public class Employee
    {
        //attributes of the class
        private string Name;
        public string name
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }
        }

        private DateTime DoB;
        public DateTime dob
        {
            get
            {
                return DoB;
            }

            set
            {
                DoB = value;
            }
        }

        private string Department;
        public string department
        {
            get
            {
                return Department;
            }

            set
            {
                Department = value;
            }
        }

        //put [NonSerialized] on top of attributes you don't want to serialize
        [NonSerialized]
        public string additionalInfo;
    }
}
