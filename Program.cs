using System;

namespace Lab1_20231059
{
    // Exercise 1 and 2: Car class
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        // constructor to set all properties
        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        // show info
        public void ShowInfo()
        {
            Console.WriteLine("Car Details: " + Make + " " + Model + " (" + Year + ")");
        }

        // start engine
        public void Start()
        {
            Console.WriteLine("TEngine started successfully.");
        }
    }

    // Exercise 3: Book class
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }

        public void ReadBook()
        {
            Console.WriteLine("Reading \"" + Title + "\" written by " + Author);
        }
    }

    // Exercise 4: Person class with default values
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person()
        {
            FirstName = "Tarun";
            LastName = "KM";
            Age = 30;
        }

        public void PrintPerson()
        {
            Console.WriteLine("Person Info: " + FirstName + " " + LastName + ", Age " + Age);
        }
    }

    // Exercise 5: Calculator with overloaded methods
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public double Add(double a, double b, double c, double d)
        {
            return a + b + c + d;
        }
    }

    // Exercise 6: Static example
    class Counter
    {
        private static int totalCount = 0;

        public void Increase()
        {
            totalCount++;
        }

        public static int GetTotal()
        {
            return totalCount;
        }
    }

    // Main class
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1 & 2
            Car testCar = new Car("Toyota", "Lexus", 2025);
            testCar.ShowInfo();
            testCar.Start();

            Console.WriteLine();

            // Exercise 3
            Book testBook = new Book();
            testBook.Title = "Bhagwat Gita";
            testBook.Author = "Swami Ji";
            testBook.Pages = 2100;
            testBook.ReadBook();

            Console.WriteLine();

            // Exercise 4
            Person testCustomer = new Person();
            testCustomer.PrintPerson();

            Console.WriteLine();

            // Exercise 5
            Calculator calc = new Calculator();
            Console.WriteLine("Add two ints: " + calc.Add(5, 6));
            Console.WriteLine("Add three ints: " + calc.Add(1, 2, 3));
            Console.WriteLine("Add four doubles: " + calc.Add(1.1, 2.2, 3.3, 4.4));

            Console.WriteLine();

            // Exercise 6
            Counter c1 = new Counter();
            Counter c2 = new Counter();
            c1.Increase();
            c2.Increase();
            c2.Increase();
            Console.WriteLine("Total count value: " + Counter.GetTotal());

            Console.WriteLine("\nPress any key to close.");
            Console.ReadKey();
        }
    }
}