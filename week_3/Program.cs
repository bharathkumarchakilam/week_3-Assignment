// See https://aka.ms/new-console-template for more information
using System;
using week_3;

namespace week_3
{
    class Program
    {
        //for button question
        static void ButtonClicked()
        {
            Console.WriteLine("Button was clicked!");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\n*****1.Bank Account*****");
            BankAccount account = new BankAccount(1000);

            account.Deposit(500);
            account.Withdraw(300);
            account.Withdraw(1500); // Should show insufficient balance

            Console.WriteLine($"Final Balance: {account.GetBalance()}");
            Console.WriteLine("\n");

            Console.WriteLine("\n*****2.Student*****");
            Student student = new Student();
            student.Name = "John";
            student.RollNo = 101;
            Course course = new Course();
            course.Name = "C#";
            course.CourseId = 1;
            Console.WriteLine("\n");

            Console.WriteLine("*****3.Book*****");
            //Using Default Constructor
                   Book book1 = new Book();
            Console.WriteLine("Book 1 Details:");
            book1.DisplayBookInfo();

            // Using Constructor with Title and Author
            Console.WriteLine("\nEnter Title and Author:");
            Console.Write("Title: ");
            string title = Console.ReadLine();
            Console.Write("Author: ");
            string author = Console.ReadLine();
            Book book2 = new Book(title, author);
            Console.WriteLine("\nBook 2 Details:");
            book2.DisplayBookInfo();

            // Using Constructor with Title, Author, and ISBN
            Console.WriteLine("\nEnter Title, Author, and ISBN:");
            Console.Write("Title: ");
            string title3 = Console.ReadLine();
            Console.Write("Author: ");
            string author3 = Console.ReadLine();
            Console.Write("ISBN: ");
            string isbn3 = Console.ReadLine();
            Book book3 = new Book(title3, author3, isbn3);
            Console.WriteLine("\nBook 3 Details:");
            book3.DisplayBookInfo();


            Console.WriteLine("\n*****4.shape*****");
            Console.Write("Enter radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Shape circle = new Circle(radius);
            Console.WriteLine($"Area of Circle: {circle.CalculateArea():F2}");

            Console.Write("\nEnter length of the rectangle: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter width of the rectangle: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Shape rectangle = new Rectangle(length, width);
            Console.WriteLine($"Area of Rectangle: {rectangle.CalculateArea():F2}");

            Console.WriteLine("\n");
            Console.WriteLine("*****5.Vehicle*****");
            // Demonstrating polymorphism
            Vehicle myVehicle;

            myVehicle = new Car();
            myVehicle.Start(); // Calls Car's Start() method

            myVehicle = new Bike();
            myVehicle.Start(); // Calls Bike's Start() method

            Console.WriteLine("\n");
            Console.WriteLine("*****6.Person*****");
            Person person1 = new Student1("Alice", 20, 101);
            Person person2 = new Teacher("Mr. John", 45, "Mathematics");

            // Demonstrating polymorphism using base class reference
            Console.WriteLine("Details of Student:");
            person1.GetDetails();

            Console.WriteLine("\nDetails of Teacher:");
            person2.GetDetails();

            Console.WriteLine("\n");
            Console.WriteLine("*****7.Calculator*****");
            Calculator calc = new Calculator();

            // Demonstrating method overloading
            Console.WriteLine("Addition of two integers: " + calc.Add(5, 10));
            Console.WriteLine("Addition of three integers: " + calc.Add(5, 10, 15));
            Console.WriteLine("Addition of two double values: " + calc.Add(5.5, 10.2));

            Console.WriteLine("\n");
            Console.WriteLine("*****8.IPlayable*****");
            IPlayable player;
            // Using MusicPlayer
            player = new MusicPlayer();
            player.Play(); // Calls Play() from MusicPlayer

            // Using VideoPlayer
            player = new VideoPlayer();
            player.Play(); // Calls Play() from VideoPlayer

            Console.WriteLine("\n");
            Console.WriteLine("*****9.IPrintable*****");
            Report report = new Report("Monthly Sales", "This report contains sales data for the month.");

            Console.WriteLine("Printing Report:");
            report.Print();

            string filePath = "report.txt";
            report.SaveToFile(filePath);

            Console.WriteLine("\n");
            Console.WriteLine("*****10.User*****");
            User admin = new Admin("Alice");
            User customer = new Customer("Bob");

            admin.AccessControl();
            customer.AccessControl();

            Console.WriteLine("\n");
            Console.WriteLine("*****11.ComplexNumber*****");
            ComplexNumber c1 = new ComplexNumber(3, 4);
            ComplexNumber c2 = new ComplexNumber(1, 2);

            ComplexNumber result = c1 + c2;

            Console.WriteLine($"First Complex Number: {c1}");
            Console.WriteLine($"Second Complex Number: {c2}");
            Console.WriteLine($"Sum: {result}");

            Console.WriteLine("\n");
            Console.WriteLine("*****12.Department*****");
            Manager originalManager = new Manager("Alice");
            Department originalDepartment = new Department("HR", originalManager);

            // Shallow Copy
            Department shallowCopy = originalDepartment.ShallowCopy();

            // Deep Copy
            Department deepCopy = originalDepartment.DeepCopy();

            Console.WriteLine("Before Modification:");
            originalDepartment.Display();
            shallowCopy.Display();
            deepCopy.Display();

            // Modify original manager's name
            originalManager.Name = "Bob";

            Console.WriteLine("\nAfter Modifying Original Manager's Name:");
            originalDepartment.Display();
            shallowCopy.Display();


            Console.WriteLine("\n*****13.Bank*****");
            Bank acc1 = new Bank("Alice", 1000);
            Bank acc2 = new Bank("Bob", 2000);

            Console.WriteLine("Initial Interest Rate:");
            acc1.DisplayAccountInfo();
            acc2.DisplayAccountInfo();

            Bank.SetInterestRate(6.5);

            Console.WriteLine("\nAfter Updating Interest Rate:");
            acc1.DisplayAccountInfo();
            acc2.DisplayAccountInfo();

            Console.WriteLine("\n*****14.SecuritySystem*****");
            SecuritySystem system = new SecuritySystem();

            Console.Write("Enter Password: ");
            string inputPassword = Console.ReadLine();

            if (system.Authenticate(inputPassword))
                Console.WriteLine("Access Granted.");
            else
                Console.WriteLine("Access Denied.");

            Console.WriteLine("\n*****15.Button*****");
            Button button = new Button();
            button.OnClick += ButtonClicked;

            Console.WriteLine("Press Enter to click the button...");
            Console.ReadLine();

            button.Click();

            Console.WriteLine("\n*****16.VehicleFactory*****");
            Console.Write("Enter number of wheels (2/4): ");
            int wheels = int.Parse(Console.ReadLine());

            try
            {
                IVehicle vehicle = VehicleFactory.GetVehicle(wheels);
                vehicle.Drive();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\n*****17.ILogger*****");
            ILogger logger = new FileLogger();
            ILogger timestampLogger = new TimestampLogger(logger);
            ILogger errorLogger = new ErrorLogger(timestampLogger);

            Console.WriteLine("Basic Logging:");
            logger.Log("System started");

            Console.WriteLine("\nLogging with Timestamp:");
            timestampLogger.Log("System running");

            Console.WriteLine("\nLogging with Timestamp and Error Category:");
            errorLogger.Log("System crashed");

            Console.WriteLine("\n*****18.ConfigurationManager*****");
            ConfigurationManager config1 = ConfigurationManager.GetInstance();
            Console.WriteLine("Config: " + config1.ConfigValue);

            ConfigurationManager config2 = ConfigurationManager.GetInstance();
            config2.ConfigValue = "New Config";

            Console.WriteLine("Updated Config: " + config1.ConfigValue);
            Console.WriteLine("Are both the same? " + (config1 == config2));

            Console.WriteLine("\n*****19.INotificationObserver*****");
            NotificationService service = new NotificationService();

            EmailNotifier emailNotifier = new EmailNotifier();
            SMSNotifier smsNotifier = new SMSNotifier();

            service.Subscribe(emailNotifier);
            service.Subscribe(smsNotifier);

            service.Notify("New message received!");

            service.Unsubscribe(smsNotifier);

            service.Notify("Another message received!");

            Console.WriteLine("\n*****20.IDiscountStrategy*****");
            Console.Write("Enter original price: ");
            double price = double.Parse(Console.ReadLine());

            Console.WriteLine("Choose discount type: 1. No Discount  2. 10% Discount  3. $20 Discount");
            int choice = int.Parse(Console.ReadLine());

            IDiscountStrategy discountStrategy = choice switch
            {
                1 => new NoDiscount(),
                2 => new PercentageDiscount(10),
                3 => new FixedAmountDiscount(20),
                _ => throw new ArgumentException("Invalid choice")
            };

            ShoppingCart cart = new ShoppingCart(discountStrategy);
            double finalPrice = cart.CalculateTotal(price);

            Console.WriteLine($"Final Price after discount: {finalPrice}");
        }
    }
}