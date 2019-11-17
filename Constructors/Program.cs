using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //CustomerManager customerManager = new CustomerManager();
            //customerManager.List();

            //Product product = new Product { Id=1,Name="Laptop"};
            //Product product2 = new Product ();

            //EmloyeeManager emloyeeManager = new EmloyeeManager(new DataBaseLogger());
            //emloyeeManager.Add();

            PersonManager personManager = new PersonManager("Product");
            personManager.Add();
            Teacher.Number = 10;
            Utilities.Validate();
        }
    }

    class BaseClass
    {
        private string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;
        }
        public void Message()
        {
            Console.WriteLine("{0} message",_entity);
        }
    }

    class PersonManager : BaseClass
    {
        public PersonManager(string entity):base(entity)
        {

        }
        public void Add()
        {
            Console.WriteLine("Added!");
            Message();
        }
    }



    class CustomerManager
    {
        private int _count=15;
        public CustomerManager(int count)
        {
            _count = count;
        }
        public CustomerManager()
        {

        }
        public void List()
        {
            Console.WriteLine("listed {0} items",this._count);
        }

        public void Add()
        {
            Console.WriteLine("added");
        }

    }
    class Product
    {
        public Product()
        {

        }
        private int _id;
        private string _name;
        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }

    interface Ilogger
    {
        void Log();
    }
    class DataBaseLogger : Ilogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }
    class FileLogger : Ilogger
    {
        public void Log()
        {
            Console.WriteLine("logged to file");
        }
    }

    class EmloyeeManager
    {
        private Ilogger _logger;
        public EmloyeeManager(Ilogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added!");
        }
    }
    static class Teacher
    {
        public static int Number { get; set; }
    }
    static class Utilities
    {
        public static void Validate()
        {
            Console.WriteLine("Validation is done");
        }
    }
    class Manager
    {
        public static void DoSomething()
        {
            Console.WriteLine("done");
        }
        public void DoSomething2()
        {
            Console.WriteLine("done2");
        }
    }
}
