using System;
using System.Collections.Generic;
using System.Text;

namespace TypesRecap_End
{
    class DateTimesTest
    {
        public void DateTimeDemo()
        {
            // 2015 is year, 12 is month, 25 is day  
            DateTime someDate1 = new DateTime(2015, 12, 25);
            Console.WriteLine(someDate1.ToString()); // 12/25/2015 12:00:00 AM    

            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString("F")); //The F specifier creates a full date and time pattern.

            // 2015 - year, 12 - month, 25 – day, 10 – hour, 30 – minute, 50 - second  
            DateTime someDate2 = new DateTime(2012, 12, 25, 10, 30, 50);
            Console.WriteLine(someDate2.ToString());// 12/25/2015 10:30:00 AM }  

            // Define an uninitialized date.  
            Console.Write(DateTime.MinValue); // 1/1/0001 12:00:00 AM

            // Define an uninitialized date.  
            Console.Write(DateTime.MaxValue); // 12/31/9999 11:59:59 PM  

            // Creating TimeSpan object of one month(as 30 days)  
            System.TimeSpan duration = new System.TimeSpan(30, 0, 0, 0);
            System.DateTime newDate1 = DateTime.Now.Add(duration);
            System.Console.WriteLine(newDate1); // 1/19/2016 11:47:52 AM  

            // Adding days to a date  
            DateTime today = DateTime.Now; // 12/20/2015 11:48:09 AM  
            DateTime newDate2 = today.AddDays(30); // Adding one month(as 30 days)  
            Console.WriteLine(newDate2); // 1/19/2016 11:48:09 AM  

            // Parsing  
            string dateString = "Wed Dec 30, 2015";
            DateTime dateTime12 = DateTime.Parse(dateString); // 12/30/2015 12:00:00 AM  

            // Date Difference  
            System.DateTime date1 = new System.DateTime(2015, 3, 10, 2, 15, 10);
            System.DateTime date2 = new System.DateTime(2015, 7, 15, 6, 30, 20);
            System.DateTime date3 = new System.DateTime(2015, 12, 28, 10, 45, 30);

            // diff1 gets 127 days, 04 hours, 15 minutes and 10 seconds.  
            System.TimeSpan diff1 = date2.Subtract(date1); // 127.04:15:10  
                                                           // date4 gets 8/23/2015 6:30:20 AM  
            System.DateTime date4 = date3.Subtract(diff1);
            // diff2 gets 166 days 4 hours, 15 minutes and 10 seconds.  
            System.TimeSpan diff2 = date3 - date2; //166.04:15:10  
                                                   // date5 gets 3/10/2015 2:15:10 AM  
            System.DateTime date5 = date2 - diff1;

            // Universal Time  
            DateTime dateObj = new DateTime(2015, 12, 20, 10, 20, 30);
            Console.WriteLine("mans" + dateObj.ToUniversalTime()); // 12/20/2015 4:50:30 AM 

            //TODO: We need to understand enums first
            DateTime myDate = new DateTime(2015, 12, 25, 10, 30, 45);
            int year = myDate.Year; // 2015  
            int month = myDate.Month; //12  
            int day = myDate.Day; // 25  
            int hour = myDate.Hour; // 10  
            int minute = myDate.Minute; // 30  
            int second = myDate.Second; // 45  
            int weekDay = (int)myDate.DayOfWeek; // 5 due to Friday  

            DateTime dt = new DateTime(2015, 12, 25);
            bool isEqual1 = dt.DayOfWeek == DayOfWeek.Thursday; // False  
            bool isEqual2 = dt.DayOfWeek == DayOfWeek.Friday; // True 

            // It is 10th December 2015
            System.DateTime dtObject = new System.DateTime(2015, 12, 10); // 12/10/2015 12:00:00 AM  
                                                                          // TimeSpan object with 15 days, 10 hours, 5 minutes and 1 second.  
            System.TimeSpan timeSpan = new System.TimeSpan(15, 10, 5, 1);
            System.DateTime addResult = dtObject + timeSpan; // 12/25/2015 10:05:01 AM  
            System.DateTime substarctResult = dtObject - timeSpan; // 11/24/2015 1:54:59 PM  

            DateTime dec25 = new DateTime(2015, 12, 25);
            DateTime dec15 = new DateTime(2015, 12, 15);

            // areEqual gets false.  
            bool areEqual = dec25 == dec15;
            DateTime newDate = new DateTime(2015, 12, 25);
            // areEqual gets true.  
            areEqual = dec25 == newDate;

            DateTime tempDate = new DateTime(2015, 12, 08); // creating date object with 8th December 2015  
            Console.WriteLine(tempDate.ToString("MMMM dd, yyyy")); //December 08, 2105.  
        }
    }
}
