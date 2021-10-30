using System;
using System.Collections.Generic;

public class generic_Dictionary
{
    public static void Main(string[] args)
    {
        Dictionary<string, string> fruits = new Dictionary<string, string>();
        fruits.Add("1", "Apple");
        fruits.Add("2", "Orange");
        fruits.Add("3", "Pear");
        fruits.Add("4", "Watermelon");
        fruits.Add("5", "Melon");

        foreach (KeyValuePair<string, string> kv in fruits)
        {
            Console.WriteLine(kv.Key + " " + kv.Value);
        }

        //use ContainsKey() to check for an unknown key
        if (fruits.ContainsKey("Orange"))
        {
            Console.WriteLine(fruits["Orange"]);
        }

        //use TryGetValue() to get a value of unknown key
        string result;
        if (fruits.TryGetValue("Orange", out result))
        {
            Console.WriteLine(result);
        }

        //use ElementAt() to retrieve key-value pair using index
        for (int i = 0; i < fruits.Count; i++)
        {
            Console.WriteLine("Key: {0}, Value: {1}", fruits.ElementAt(i).Key, fruits.ElementAt(i).Value);
        }

        // update the dictionary
        if (fruits.ContainsKey("Orange"))
        {
            fruits["France"] = "Grape";
        }

        // removes Grape
        fruits.Remove("Grape");  

        if (fruits.ContainsKey("Apple"))
        { // check key before removing it
            fruits.Remove("Apple");
        }

        //removes all elements
        fruits.Clear(); 
    }
}
