using System;

namespace VirtualMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            SqlServer sqlServer = new SqlServer();

            sqlServer.Add();
            MySql mySql = new MySql();
            mySql.Add();
        }
    }


    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by default");
        }
        public virtual void Delete()
        {
            Console.WriteLine("Deleted by default");
        }

    }

    class SqlServer : Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by Sql code");
            //base.Add();
        }
    }
    class MySql : Database
    {

    }

}
