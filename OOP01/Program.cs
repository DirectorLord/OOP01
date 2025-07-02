namespace OOP01
{
    using System;
    public class Program
    {
        #region Question1
        //Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members.
        //Then, write a C# program that prints out all the days of the week using this enum.
        public enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        #endregion
        public static void Main(string[] args)
        {
            #region Question1
            //Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members.
            //Then, write a C# program that prints out all the days of the week using this enum.
            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(day);
            }
            #endregion
        }
    }
}