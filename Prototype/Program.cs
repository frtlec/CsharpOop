using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { 
            FirstName="Engin",
            LastName="Demiroğ",
            City="Ankara",
            Id=1
            };

            

            var customer2 =(Customer) customer.Clone();

            customer2.FirstName = "Salih";
            Console.WriteLine(customer.FirstName);
            Console.WriteLine(customer2.FirstName);

            /*
             customer1 i customer2 ye eşitledikten sonra 
             firstnamede yaptığımız değişiklik eğer prototype design pattern 
             yani clonelayıp referansını değiştirmeseydik aynı olacaktı
             ancak cloneladığımız için yeni bir referans oluturdu.
             Hem newlemenin maliyetinden kurtulduk hemde yeni bir customer
             nesnesi oluşturduk.
             */



        }
    }
    public abstract class Person
    {
        public abstract Person Clone();
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }


    public class Customer : Person
    {
        public string City { get; set; }

        public override Person Clone()
        {
            return (Person)MemberwiseClone();
        }
    }
    public class Employee : Person
    {
        public string Salary { get; set; }

        public override Person Clone()
        {
            return (Person)MemberwiseClone();
        }
    }
}
