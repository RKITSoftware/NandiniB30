using System;

namespace DatetimeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //returns current date and time
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine("Current DateTime : " + currentDateTime);

            // returns today's date
            DateTime todaysDate = DateTime.Today;
            Console.WriteLine("Today's Date : " + todaysDate);

            //return default : 01/01/0001 00:00:00
            DateTime defaultDate = new DateTime();
            Console.WriteLine("Set Default Date : " + defaultDate);

            //set the date : year, month, day
            DateTime setDateValue = new DateTime(2021, 10, 13);
            Console.WriteLine("Set the Date : " + setDateValue);

            //set the date time : year, month, day, hour, min, seconds
            DateTime setDateTimeValue = new DateTime(2021, 10, 13, 11, 15, 20);
            Console.WriteLine("Set the Date Time : " + setDateTimeValue);

            //we can add the datetime to other.
            //timespan have days, hour, min, sec.
            DateTime setDateTime = new DateTime(2021, 10, 13);
            TimeSpan setTimeSpan = new TimeSpan(11, 15, 55);
            DateTime newDateTime = setDateTime.Add(setTimeSpan);
            Console.WriteLine("New DateTime Added : " + newDateTime);

            //we can subtraction the datetime.
            DateTime datetimenow = DateTime.Now;
            DateTime datetimeold = new DateTime(2016, 08, 05);
            int resultant = datetimenow.Subtract(datetimeold).Days;
            Console.WriteLine("Subtract new datetime from old datetime : " + resultant + " days");
            Console.ReadLine();
        }
    }
}
