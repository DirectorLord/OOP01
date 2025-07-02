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

        #region Question3
        //Create an enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members.
        //Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season.
        //Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
        enum season
        {
            Spring, Summer, Autumn, Winter
        }
        #endregion

        #region Question4
        //Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members
        //Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
        enum colors {
            red, green, blue
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

            #region Question3
            //Create an enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members.
            //Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season.
            //Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
            Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter) to know its range: ");
            string input = Console.ReadLine();
            switch (input)
            {
                case "spring":
                    Console.WriteLine("March to May");
                    break;
                case "summer":
                    Console.WriteLine("June to August");
                    break;
                case "autumn":
                    Console.WriteLine("September to November");
                    break;
                case "winter":
                    Console.WriteLine("December to February");
                    break;
                default:
                    Console.WriteLine("Invalid season");
                    break;
            }
            #endregion

            #region Question4
            //Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members
            //Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
            Console.WriteLine("Enter a color (Red, Green, Blue): ");
            string colorInput = Console.ReadLine();
            switch (colorInput)
            {
                case "red":
                case "green":
                case "blue":
                    Console.WriteLine($"{colorInput} is a primary color.");
                    break;
                default:
                    Console.WriteLine($"{colorInput} is not a primary color.");
                    break;
            }
            #endregion
        }
    }
}