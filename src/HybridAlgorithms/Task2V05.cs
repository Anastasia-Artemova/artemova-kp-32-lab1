using System.Globalization;
using HybridAlgorithms.Common;

namespace HybridAlgorithms;

public class Task2V05
{
    public (SimpleDate, int) Calculate(int day, int month, int year)
    {
        bool check;
        Console.Write("Enter any year according to the Julian Calender ");
        check  = int.TryParse(Console.ReadLine(), out year);
        if(!check){
            while(!check){
                Console.Write("Provided year is incorrect. Try again ");
                check = int.TryParse(Console.ReadLine(), out year);
            }
        }

        Console.Write("Enter any month according to the Julian calender ");
        check  = int.TryParse(Console.ReadLine(), out month);
        if(!check || month > 12){
            while(!check || month > 12){
                Console.Write("Provided month is incorrect. Try again ");
                check = int.TryParse(Console.ReadLine(), out month);
            }
        }

        Console.Write("Enter any day according to the Julian calender ");
        check  = int.TryParse(Console.ReadLine(), out day);
        if(!check){
            while(!check){
                Console.Write("Provided day is incorrect. Try again ");
                check = int.TryParse(Console.ReadLine(), out day);
            }
        }

        DateOnly julianDate = new DateOnly(year, month, day, new JulianCalendar());
        Console.WriteLine("\n" + julianDate + " according to the Gregorian calender");

        DateOnly firstDay = new DateOnly(year, 1, 1);
        int passedDays = julianDate.DayOfYear - firstDay.DayOfYear + 1;
        Console.WriteLine("\n" + passedDays + " - The amount of days passed from the beginning of the year");

        throw new NotImplementedException();
    }
}