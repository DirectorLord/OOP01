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

        #region Question2
        //Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data.
        //Then, write a C# program to display the details of all the persons in the array.
        public struct Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public Person(string name, int age)
            {
                this.Name = name;
                this.Age = age;
            }
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

            #region Question2
            //Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data.
            //Then, write a C# program to display the details of all the persons in the array.
            Person[] people = new Person[3];
            people[0] = new Person("Zeyad", 25);
            people[1] = new Person("Ahmed", 20);
            people[2] = new Person("Jack", 21);
            foreach (var person in people)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }
            #endregion
        }
    }
}