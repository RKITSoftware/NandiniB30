using System;

namespace DatetimeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region static fields
            //returns current date and time
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine("Current DateTime : " + currentDateTime);

            // returns today's date
            DateTime todaysDate = DateTime.Today;
            Console.WriteLine("Today's Date : " + todaysDate);

            // returns current UTC date and time
            DateTime currentDateTimeUTC = DateTime.UtcNow;
            Console.WriteLine("Current DateTime UTC Timezone : " + currentDateTimeUTC);

            // returns max value of DateTime
            DateTime maxDateTimeValue = DateTime.MaxValue;
            Console.WriteLine("Max DateTime value : " + maxDateTimeValue);

            // returns min value of DateTime
            DateTime minDateTimeValue = DateTime.MinValue;
            Console.WriteLine("Min DateTime value : " + minDateTimeValue);
            #endregion static fields

            //return default value 01/01/0001 00:00:00
            DateTime defaultDateValue = new DateTime();
            Console.WriteLine("Set Default Date : " + defaultDateValue);

            //set the date : year, month, day
            DateTime setDateValue = new DateTime(2021, 10, 13);
            Console.WriteLine("Set the Date : " + setDateValue);

            //set the date time : year, month, day, hour, min, seconds
            DateTime setDateTimeValue = new DateTime(2021, 10, 13, 11, 15, 20);
            Console.WriteLine("Set the Date Time : " + setDateTimeValue);

            #region properties
            //returns year
            Console.WriteLine(setDateTimeValue.Year);

            //returns month
            Console.WriteLine(setDateTimeValue.Month);

            //returns day
            Console.WriteLine(setDateTimeValue.Day);

            //returns hour
            Console.WriteLine(setDateTimeValue.Hour);

            //returns minute
            Console.WriteLine(setDateTimeValue.Minute);

            //returns second
            Console.WriteLine(setDateTimeValue.Second);

            //returns day of week
            Console.WriteLine((int)setDateTimeValue.DayOfWeek);
            #endregion properties

            #region operators
            //set the date time : days, hours, min, seconds
            TimeSpan setTimevalue = new TimeSpan(10, 11, 15, 55);

            Console.WriteLine(setDateTimeValue + setTimevalue);
            Console.WriteLine(setDateTimeValue - setDateValue);
            Console.WriteLine(setDateValue == setDateTimeValue);
            Console.WriteLine(setDateValue != setDateTimeValue);
            Console.WriteLine(setDateValue > setDateTimeValue);
            Console.WriteLine(setDateValue < setDateTimeValue);
            Console.WriteLine(setDateValue >= setDateTimeValue);
            Console.WriteLine(setDateValue <= setDateTimeValue);
            #endregion operators

            #region methods
            //we can add the datetime to other.
            //timespan have days, hour, min, sec.
            DateTime setDateTime = new DateTime(2021, 10, 13);
            TimeSpan setTimeSpan = new TimeSpan(11, 15, 55);
            DateTime newDateTime = setDateTime.Add(setTimeSpan);
            Console.WriteLine("New DateTime Added : " + newDateTime);

            // Adding days to a date  
            DateTime today = DateTime.Now;
            // Adding one month(as 30 days)
            DateTime newDate = today.AddDays(30);
            Console.WriteLine("New DateTime : " + newDate);

            // Parsing  
            string dateString = "Mon Oct 25, 2021";
            DateTime dateTime_from_string = DateTime.Parse(dateString);
            Console.WriteLine("Parsed DateTime from String : " + dateTime_from_string);

            //we can subtraction the datetime.
            DateTime datetimenow = DateTime.Now;
            DateTime datetimeold = new DateTime(2021, 09, 05);
            int resultant = datetimenow.Subtract(datetimeold).Days;
            Console.WriteLine("Subtract new datetime from old datetime : " + resultant + " days");

            //format DateTime
            DateTime old_format_Date = new DateTime(2021, 10, 10);
            Console.WriteLine("New formatted DateTime : " + old_format_Date.ToString("MMMM dd, yyyy"));
            Console.ReadLine();
            #endregion methods
        }
    }
}
