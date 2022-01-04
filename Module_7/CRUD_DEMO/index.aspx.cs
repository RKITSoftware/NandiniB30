using System;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace MySQLConnector
{
    public partial class index : Page
    {
        protected GridView GridView1;
        SqlConnection con = new SqlConnection("Data Source=NANDINI_PC;Initial Catalog=Demo_Prog_training;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand command = new SqlCommand("Insert into Demo values('" + int.Parse(TextBox1.Text) + "','" + TextBox2.Text + "','" + TextBox5.Text + "','" + double.Parse(TextBox3.Text) + "','" + TextBox4.Text + "')", con);
            command.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Inserted');", true); //MessageBox.Show("Successfully Inserted");

        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand comm = new SqlCommand("Update Demo set Name = '" + TextBox2.Text + "',Country = '" + TextBox5.Text + "',Age = '" + double.Parse(TextBox3.Text) + "',Language = '" + TextBox4.Text + "'Where ID = '" + int.Parse(TextBox1.Text) + "'", con);
            comm.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Updated');", true);

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand comm = new SqlCommand("Delete Demo Where ID = '" + int.Parse(TextBox1.Text) + "'", con);
            comm.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Deleted');", true);

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from Demo", con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            GridView1.DataSource = dataTable;
            GridView1.DataBind();
        }
    }
}
