using System;
using System.Collections;

namespace non_generic_Hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            var seasons = new Hashtable()
            {
                {"summer","sun,watermelon,beach" },
                {"winter","coat,boot,hotchocolate" }
            };
            seasons.Add("monsoon", "umbrella,raincoat,heat");

            foreach (DictionaryEntry de in seasons)
            {
                Console.Write("Key: " + de.Key + " Value: " + de.Value);
            }


            Console.Write();
            if (seasons.ContainsKey("winter"))
            {
                seasons.Remove("winter");
            }
            foreach (DictionaryEntry de in seasons)
            {
                Console.WriteLine("Key: " + de.Key + " Value: " + de.Value);
            }
        }
    }
}