// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Runtime.InteropServices;


Console.WriteLine("Hello, World!");



//empty datetime

DateTime date = new DateTime();

//create a date time from date and time

DateTime dateofbirth = new DateTime(1980,12,30);
Console.WriteLine("My DOB is:" +  dateofbirth);

//create a date time from date and time with current time stamp

DateTime now = DateTime.Now;
Console.WriteLine("The date and the time is" + now);


//create the date time from a string

DateTime datefromstring = DateTime.Parse("1/25/2022",CultureInfo.InvariantCulture);
Console.WriteLine("The date from string is" + datefromstring);


// Add additional time

//now.AddHours(); 
Console.WriteLine("One hour from now would be" + now.AddHours(1));
Console.WriteLine("One day from now would be" + now.AddDays(1));


//ticks from date time

Console.WriteLine("Time as a numeral :" + now.Ticks);

//Date only

DateOnly dateofbirthonly = DateOnly.FromDateTime(dateofbirth);
Console.WriteLine("date without time is :" + dateofbirthonly);


//Time only

TimeOnly timeonly = TimeOnly.FromDateTime(now);

Console.WriteLine("time without date is :" + timeonly);

