using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsForms_Serialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //click event for Serialize button. 
        //When clicking on the serialize button,serialize the object of class Employee
        //and store it in a file named "employee.xml".
        private void Serialize_Click(object sender, EventArgs e)
        {
            Employee obj_emp = new Employee {
                name = textBoxName.Text,
                dob = dateTimePickerDoB.Value,
                department = textBoxDepartment.Text,
                additionalInfo = "We don't want it to serialize"
            };

            //XmlSerializer to serialize the object in XML format.
            XmlSerializer obj_xmlfile = new XmlSerializer(typeof(Employee));

            //Make a file using FileStream named "employee.xml".
            FileStream obj_out = new FileStream("employee.xml", FileMode.Create, FileAccess.Write, FileShare.None);
            try
            {
                using (obj_out)
                {
                    //serialize the object
                    obj_xmlfile.Serialize(obj_out, obj_emp);
                    label4.Text = "Object Serialized";
                }
            }
            catch
            {
                label4.Text = "An error has occured";
            }
        }

        private void Deserialize_Click(object sender, EventArgs e)
        {
            Employee obj_emp = new Employee();

            ////XmlSerializer to serialize the object in XML format.
            XmlSerializer obj_xmlfile = new XmlSerializer(typeof(Employee));
           
            //Make a file using FileStream named "employee.xml".
            FileStream obj_in = new FileStream("employee.xml", FileMode.Open, FileAccess.Read, FileShare.None);
            try
            {
                using (obj_in)
                {
                    //deserialize the object
                    obj_emp = (Employee) obj_xmlfile.Deserialize(obj_in);
                    label4.Text = "Object Deserialized";

                    textBoxName.Text = obj_emp.name;
                    dateTimePickerDoB.Value = obj_emp.dob;
                    textBoxDepartment.Text = obj_emp.department;
                }
            }
            catch
            {
                label4.Text = "An error has occured";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
