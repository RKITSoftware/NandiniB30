using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

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
        //and store it in a file named "employee.binary".
        private void Serialize_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee {
                name = textBoxName.Text,
                dob = dateTimePickerDoB.Value,
                department = textBoxDepartment.Text,
                additionalInfo = "We don't want it to serialize"
            };

            //BinaryFormatter to serialize the object in BinaryFormat.
            BinaryFormatter obj_bf = new BinaryFormatter();

            //Make a file using FileStream named "employee.binary".
            FileStream obj_out = new FileStream("employee.binary", FileMode.Create, FileAccess.Write, FileShare.None);
            try
            {
                using (obj_out)
                {
                    //bf.Serialize(obj_out, emp) will serialize the object "obj_emp" and store it in file "employee.binary"
                    obj_bf.Serialize(obj_out, emp);
                    label4.Text = "Object Serialized";
                }
            }
            catch
            {
                label4.Text = "An error has occured";
            }
        }

        //click event for Deserialize button. 
        //When clicking on the Deserialize button,deserialize the object and show its values on screen
        private void Deserialize_Click(object sender, EventArgs e)
        {
            Employee obj_emp = new Employee();

            //BinaryFormatter to serialize the object in BinaryFormat.
            BinaryFormatter obj_bf = new BinaryFormatter();

            FileStream obj_in = new FileStream("employee.binary", FileMode.Open, FileAccess.Read, FileShare.None);
            try
            {
                using (obj_in)
                {
                    //deserialize the object
                    obj_emp = (Employee) obj_bf.Deserialize(obj_in);
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

        private void dateTimePickerDoB_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
