using System;

namespace FacadeDP
{
    /*
     Depencyinjection işlemini CustomerManager sınıfının içinde
     değilde bir başka sınıf içerisinde yapıp manager classımızın
     kod okunabilirliğini artıyoruz.
         
         */
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Save();
            
        }
    }

   
    class Logging:ILogging
    {
        public void Log()
        {
            Console.WriteLine("Logged");
        }

    }

    internal interface ILogging
    {
         void Log();
    }

    class Caching:ICaching
    {
        public void Cache()
        {
            Console.WriteLine("Cached");
        }
    }

    internal interface ICaching
    {
        void Cache();
    }

    class Authorize:IAuthorize
    {
        public void CheckUser()
        {
            Console.WriteLine("User checked");
        }

    }

    internal interface IAuthorize
    {
        void CheckUser();
    }

    class CustomerManager
    {

        private CrossCuttongConcernsFacade _concerns;
        public CustomerManager()
        {
            _concerns = new CrossCuttongConcernsFacade();
        }
        public void Save()
        {
            _concerns.Caching.Cache();
            _concerns.Authorize.CheckUser();
            _concerns.Logging.Log();
            Console.WriteLine("Saved");
        }
    }

    class CrossCuttongConcernsFacade
    {
        public ILogging Logging;
        public ICaching Caching;
        public IAuthorize Authorize;
        public CrossCuttongConcernsFacade()
        {
            Logging = new Logging();
            Caching=new Caching();
            Authorize = new Authorize();
        }
    }
}
