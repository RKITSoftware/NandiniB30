using System;
using Newtonsoft.Json;

namespace SerializationJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            //populate the class with tutor data using an object
            Tutor obj_tutor = new Tutor()
            {
                TutorID = 1,
                TutorName = "Nandini",
                TutorEmail="nb@gmail.com",
                Subject_to_Teach="English"
            };

            // Convert Tutor object to JOSN string format using JsonConvert.SerializeObject method
            string jsonData = JsonConvert.SerializeObject(obj_tutor);
            Console.WriteLine(jsonData);

            string json = @"{
                              'TutorName': 'Nandini',
                              'TutorID': 1,
                              'TutorEmail':'nb@gmail.com',
                              'Subject to Teach':'English'
                            }";

            //deserialize JSON Object using JsonObject.DeserializeObject
            Tutor Obj_deserialized = JsonConvert.DeserializeObject<Tutor>(json);
            Console.Write(Obj_deserialized.TutorName);
            Console.ReadLine();
        }
    }
}
