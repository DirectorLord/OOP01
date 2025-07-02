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

        #region Question5
        //Create a struct called "Point" to represent a 2D point with properties "X" and "Y".
        //Write a C# program that takes two points as input from the user and calculates the distance between them.
        public struct Point
        {
            public double X { get; set; }
            public double Y { get; set; }
            public Point(double x, double y)
            {
                this.X = x;
                this.Y = y;
            }
        }
        #endregion

        #region Question6
        //Create a struct called "Person" with properties "Name" and "Age".
        //Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
        public struct PersonOldest
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public PersonOldest(string name, int age)
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

            #region Question5
            //Create a struct called "Point" to represent a 2D point with properties "X" and "Y".
            //Write a C# program that takes two points as input from the user and calculates the distance between them.
            Console.WriteLine("Enter a point 1 for X: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a point 1 for Y: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter X for Point 2:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Y for Point 2:");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Point p1 = new Point(x1, y1);
            Point p2 = new Point(x2, y2);
            //the formula (i stole it, im not a math guy)
            double distance = Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
            Console.WriteLine($"The distance between the points ({p1.X}, {p1.Y}) and ({p2.X}, {p2.Y}) is {distance}");
            #endregion

            #region Question6
            //Create a struct called "Person" with properties "Name" and "Age".
            //Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
            PersonOldest[] persons = new PersonOldest[3];
            for (int i = 0; i < persons.Length; i++)
            {
                Console.WriteLine($"Enter name for person {i + 1}: ");
                string name = Console.ReadLine();
                Console.WriteLine($"Enter age for person {i + 1}: ");
                int age = Convert.ToInt32(Console.ReadLine());
                persons[i] = new PersonOldest(name, age);
            }
            PersonOldest oldest = persons[0];
            for (int i = 1; i < persons.Length; i++)
            {
                if (persons[i].Age > oldest.Age)
                {
                    oldest = persons[i];
                }
            }
            Console.WriteLine($"The oldest person is {oldest.Name} with age {oldest.Age}.");
            #endregion
        }
    }
}