
using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    abstract class DataBase
    {
        public void Add()
        {
            Console.WriteLine("Added by default");
        }
        public abstract void Delete();
    }
    class SqlServer : DataBase
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by sql");
            
        }
    }

    class Oracle : DataBase
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by oracle");
        }
    }
}
