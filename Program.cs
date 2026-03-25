using System;

namespace Lab3
{
    abstract class Vehicle
    {
        public abstract void StartEngine();

        public void StopEngine()
        {
            Console.WriteLine("Engine stopped");
        }
    }

    class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car engine started");
        }
    }

    class Motorcycle : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Motorcycle engine started");
        }
    }

    abstract class Shape
    {
        public abstract double Area { get; }

        public void Display()
        {
            Console.WriteLine("Area: " + Area);
        }
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area
        {
            get { return 3.14 * Radius * Radius; }
        }
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double Area
        {
            get { return Width * Height; }
        }
    }

    abstract class Appliance
    {
        public abstract void Operate();
    }

    class WashingMachine : Appliance
    {
        public override void Operate()
        {
            Console.WriteLine("Washing machine is washing clothes");
        }
    }

    class Refrigerator : Appliance
    {
        public override void Operate()
        {
            Console.WriteLine("Refrigerator is cooling food");
        }
    }

    abstract class Account
    {
        public string AccountHolder { get; set; }
        public double Balance { get; set; }

        public abstract double CalculateInterest();

        public void DisplayAccountInfo()
        {
            Console.WriteLine("Account Holder: " + AccountHolder);
            Console.WriteLine("Balance: " + Balance);
        }
    }

    class SavingsAccount : Account
    {
        public double Rate { get; set; }

        public SavingsAccount(string accountHolder, double balance, double rate)
        {
            AccountHolder = accountHolder;
            Balance = balance;
            Rate = rate;
        }

        public override double CalculateInterest()
        {
            return Balance * Rate;
        }
    }

    class CheckingAccount : Account
    {
        public CheckingAccount(string accountHolder, double balance)
        {
            AccountHolder = accountHolder;
            Balance = balance;
        }

        public override double CalculateInterest()
        {
            return 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 5");
            Car car = new Car();
            Motorcycle bike = new Motorcycle();

            car.StartEngine();
            car.StopEngine();
            bike.StartEngine();
            bike.StopEngine();

            Console.WriteLine();

            Console.WriteLine("Exercise 6");
            Circle circle = new Circle(5);
            Rectangle rect = new Rectangle(4, 6);

            circle.Display();
            rect.Display();

            Console.WriteLine();

            Console.WriteLine("Exercise 7");
            Appliance[] appliances = { new WashingMachine(), new Refrigerator() };

            for (int i = 0; i < appliances.Length; i++)
            {
                appliances[i].Operate();
            }

            Console.WriteLine();

            Console.WriteLine("Exercise 8");
            SavingsAccount s = new SavingsAccount("tarun", 1000, 0.05);
            CheckingAccount c = new CheckingAccount("karanpreet", 1500);

            s.DisplayAccountInfo();
            Console.WriteLine("Interest: " + s.CalculateInterest());

            Console.WriteLine();

            c.DisplayAccountInfo();
            Console.WriteLine("Interest: " + c.CalculateInterest());
        }
    }
}