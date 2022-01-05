using System;
using System.Collections.Generic;
using CRUD_Demo.Models;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace CRUD_Demo
{
    /// <summary>
    /// Business Logic for all the CRUD operations on Tutor table from database 
    /// </summary>
    public class BLTutor
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
        public List<Tutor> selectAll()
        {
            //populate the list of tutors
            List<Tutor> obj_tutor = new List<Tutor>();

            //make sql connection with the database
            using (MySqlConnection obj_conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    obj_conn.Open();
                    //Get all data from the table Tutor
                    MySqlCommand obj_cmd = new MySqlCommand("select * from Tutor", obj_conn);

                    using (var reader = obj_cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //add new data to the table Tutor
                            obj_tutor.Add(new Tutor()
                            {
                                TutorID = Convert.ToInt32(reader["TutorID"]),
                                TutorName = reader["TutorName"].ToString(),
                                Subject_to_Teach = reader["Subject_to_Teach"].ToString(),

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

        /// <summary>
        /// Get Tutor data by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>One record of Tutor according to the id</returns>
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

        /// <summary>
        /// Insert new tutor data
        /// </summary>
        /// <param name="tutuoring"></param>
        /// <returns>String to notify Success of operation </returns>
        public string addTutor(Tutor tutoring)
        {
            List<Tutor> obj_tutor = new List<Tutor>();

            using (MySqlConnection obj_conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    obj_conn.Open();

                    MySqlCommand obj_cmd = new MySqlCommand("insert into Tutor (TutorID,TutorName,Subject_to_Teach) values('" + tutoring.TutorID + "','" + tutoring.TutorName + "','" + tutoring.Subject_to_Teach + "';", obj_conn);


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

        /// <summary>
        /// Update Tutor data from table
        /// </summary>
        /// <param name="tutoring"></param>
        /// <returns>String to notify Success of operation </returns> 
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

        /// <summary>
        ///Delete Tutor data from table
        /// </summary>
        /// <param name="id"></param>
        /// <returns>String to notify Success of operation </returns>
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