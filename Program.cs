using System;

namespace Lab2Solution1
{
    class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Person(string name)
        {
            this.name = name;
            age = 18;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }
    }

    class Employee : Person
    {
        protected string employeeId;
        protected string department;

        public Employee(string name, int age, string employeeId, string department) : base(name, age)
        {
            this.employeeId = employeeId;
            this.department = department;
        }

        public Employee(string employeeId, string department) : base("Unknown", 18)
        {
            this.employeeId = employeeId;
            this.department = department;
        }

        public string GetEmployeeId()
        {
            return employeeId;
        }

        public void SetEmployeeId(string employeeId)
        {
            this.employeeId = employeeId;
        }

        public string GetDepartment()
        {
            return department;
        }

        public void SetDepartment(string department)
        {
            this.department = department;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Employee Id: " + employeeId);
            Console.WriteLine("Department: " + department);
        }
    }

    class Manager : Employee
    {
        private int teamSize;

        public Manager(string name, int age, string employeeId, string department, int teamSize) : base(name, age, employeeId, department)
        {
            this.teamSize = teamSize;
        }

        public int GetTeamSize()
        {
            return teamSize;
        }

        public void SetTeamSize(int teamSize)
        {
            this.teamSize = teamSize;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Team Size: " + teamSize);
        }
    }

    class LibraryItem
    {
        protected string title;
        protected string author;
        protected int publicationYear;

        public LibraryItem(string title, string author, int publicationYear)
        {
            this.title = title;
            this.author = author;
            this.publicationYear = publicationYear;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Publication Year: " + publicationYear);
        }
    }

    class Book : LibraryItem
    {
        private string isbn;
        private string genre;

        public Book(string title, string author, int publicationYear, string isbn, string genre) : base(title, author, publicationYear)
        {
            this.isbn = isbn;
            this.genre = genre;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("ISBN: " + isbn);
            Console.WriteLine("Genre: " + genre);
        }
    }

    class Magazine : LibraryItem
    {
        private int issueNumber;
        private string frequency;

        public Magazine(string title, string author, int publicationYear, int issueNumber, string frequency) : base(title, author, publicationYear)
        {
            this.issueNumber = issueNumber;
            this.frequency = frequency;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Issue Number: " + issueNumber);
            Console.WriteLine("Frequency: " + frequency);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 1");
            Employee emp1 = new Employee("tarun", 22, "E101", "IT");
            emp1.DisplayDetails();

            Console.WriteLine();

            Console.WriteLine("Exercise 2");
            Person p1 = new Person("tarun");
            p1.DisplayDetails();

            Console.WriteLine();

            Employee emp2 = new Employee("E102", "HR");
            emp2.DisplayDetails();

            Console.WriteLine();

            Console.WriteLine("Exercise 3");
            p1.SetName("Tarun Whitecliffe");
            p1.SetAge(23);
            Console.WriteLine(p1.GetName());
            Console.WriteLine(p1.GetAge());

            emp2.SetEmployeeId("E500");
            emp2.SetDepartment("IT");
            Console.WriteLine(emp2.GetEmployeeId());
            Console.WriteLine(emp2.GetDepartment());

            Console.WriteLine();

            Console.WriteLine("Exercise 4");
            emp1.DisplayDetails();

            Console.WriteLine();

            Console.WriteLine("Exercise 5");
            Person person1 = new Person("tarun", 20);
            Employee employee1 = new Employee("tarun", 25, "E201", "Sales");
            Manager manager1 = new Manager("tarun", 35, "M301", "Admin", 8);

            person1.DisplayDetails();
            Console.WriteLine();
            employee1.DisplayDetails();
            Console.WriteLine();
            manager1.DisplayDetails();

            Console.WriteLine();

            Console.WriteLine("Exercise 6");
            Book book1 = new Book("Test Book", "Test Name", 2022, "90123568111", "Programming");
            Magazine mag1 = new Magazine("Book 221", "Test Name 221", 2024, 15, "Monthly");

            book1.DisplayDetails();
            Console.WriteLine();
            mag1.DisplayDetails();

            Console.WriteLine();

            Console.WriteLine("Reflect");
            Console.WriteLine("The most challenging concept was constructor chaining.");
            Console.WriteLine("These OOP ideas help build real software in a clean and organised way.");
            Console.WriteLine("These can also be used in school systems, banking systems, and hospital systems.");
        }
    }
}