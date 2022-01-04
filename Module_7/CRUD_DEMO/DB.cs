using System;
using System.Collections.Generic;
using System.Web;
using System.Data.SqlClient;
using CRUD_Demo.Models;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace CRUD_Demo
{
    public class database_DB
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;

        //retrive all data
        public List<Tutor> selectAll()
        {
            List<Tutor> obj_tutor = new List<Tutor>();

            using (MySqlConnection obj_conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    obj_conn.Open();
                    MySqlCommand obj_cmd = new MySqlCommand("select * from Tutor", obj_conn);

                    using (var reader = obj_cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            obj_tutor.Add(new Tutor()
                            {
                                TutorID = Convert.ToInt32(reader["TutorID"]),
                                TutorName = reader["TutorName"].ToString(),
                                Subject_to_Teach= reader["Subject_to_Teach"].ToString(),
                             
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Can not open connection !" + ex.Message);

                }

            }
            return obj_tutor;
        }

        //retrive data by id
        public Tutor getTutorById(int id)
        {
            Tutor obj_tutor = new Tutor();

            using (MySqlConnection obj_conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    obj_conn.Open();
                    MySqlCommand obj_cmd = new MySqlCommand("select * from Tutor where TutorID = " + id + ";", obj_conn);

                    using (var reader = obj_cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            obj_tutor.TutorID = Convert.ToInt32(reader["TutorID"]);
                            obj_tutor.TutorName = reader["TutorName"].ToString();
                            obj_tutor.Subject_to_Teach = reader["Subject_to_Teach"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Can not open connection !" + ex.Message);

                }
                finally
                {
                    obj_conn.Close();
                }

            }
            return obj_tutor;
        }

        //add data
        public string addTutor(Tutor tutoring)
        {
            List<Tutor> obj_tutor = new List<Tutor>();

            using (MySqlConnection obj_conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    obj_conn.Open();

                    MySqlCommand obj_cmd = new MySqlCommand("insert into Tutor (TutorID,TutorName,Subject_to_Teach) values('" + tutoring.TutorID + "','" + tutoring.TutorName + "','" + tutoring.Subject_to_Teach +"';", obj_conn);

                   
                    int effect = obj_cmd.ExecuteNonQuery();
                    if (effect > 0)
                    {
                        return "successfull";
                    }
                    return "Not successfull query";


                }
                catch (Exception ex)
                {
                    return "Cannot open connection with error - " + ex.Message;
                }
                finally
                {
                    obj_conn.Close();
                }

            }
        }

        
        //update data
        public string updateTutor(Tutor tutoring)
        {
            List<Tutor> obj_tutor = new List<Tutor>();

            using (MySqlConnection obj_conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    obj_conn.Open();

                    MySqlCommand obj_cmd = new MySqlCommand("update countries set TutorName = '" + tutoring.TutorName + "',Subject_to_Teach = '" + tutoring.Subject_to_Teach + "';", obj_conn);


                    int effect = obj_cmd.ExecuteNonQuery();
                    if (effect > 0)
                    {
                        return "successfull";
                    }
                    return "Not successfull query";


                }
                catch (Exception ex)
                {
                    return "Cannot open connection with error - " + ex.Message;
                }
                finally
                {
                    obj_conn.Close();
                }

            }
        }

        //delete data
        public string deleteTutor(int id)
        {
            using (MySqlConnection obj_conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    obj_conn.Open();

                    MySqlCommand obj_cmd = new MySqlCommand("delete from Tutor where id = " + id, obj_conn);

                    int effect = obj_cmd.ExecuteNonQuery();
                    if (effect > 0)
                    {
                        return "successfull";
                    }
                    return "Not successfull query";


                }
                catch (Exception ex)
                {
                    return "Cannot open connection with error - " + ex.Message;
                }
                finally
                {
                    obj_conn.Close();
                }

            }
        }

    }
}