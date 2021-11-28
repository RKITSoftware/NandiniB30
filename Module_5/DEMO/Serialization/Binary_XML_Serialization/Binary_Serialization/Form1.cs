using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Serialize_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee {
                name = textBoxName.Text,
                phone = textBoxPhone.Text,
                dob = dateTimePickerDoB.Value,
                department = textBoxDepartment.Text,
                salary = Convert.ToInt32(textBoxSalary.Text),
                additionalInfo = "We don't want it to serialize"
            };

            BinaryFormatter bf = new BinaryFormatter();

            FileStream fsout = new FileStream("employee.binary", FileMode.Create, FileAccess.Write, FileShare.None);
            try
            {
                using (fsout)
                {
                    bf.Serialize(fsout, emp);
                    label6.Text = "Object Serialized";
                }
            }
            catch
            {
                label6.Text = "An error has occured";
            }
        }

        private void Deserialize_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();

            BinaryFormatter bf = new BinaryFormatter();

            FileStream fsin = new FileStream("employee.binary", FileMode.Open, FileAccess.Read, FileShare.None);
            try
            {
                using (fsin)
                {
                    emp = (Employee) bf.Deserialize(fsin);
                    label6.Text = "Object Deserialized";

                    textBoxName.Text = emp.name;
                    textBoxPhone.Text = emp.phone;
                    dateTimePickerDoB.Value = emp.dob;
                    textBoxDepartment.Text = emp.department;
                    textBoxSalary.Text = emp.salary.ToString();
                }
            }
            catch
            {
                label6.Text = "An error has occured";
            }
        }
    }
}
