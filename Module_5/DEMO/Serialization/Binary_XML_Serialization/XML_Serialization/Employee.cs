using System;
using System.Xml.Serialization;

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

        //method of XmlSerializer not to serialize
        [XmlIgnore]
        public string additionalInfo;
    }
}
