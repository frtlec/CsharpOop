using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();

            //List();
        }

        private static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            foreach (var item in cities)
            {
                Console.WriteLine(item);
            }

            List<Customer> customers = new List<Customer>
            {
                new Customer{Id=1,FirstName="Engin"},
                new Customer{Id=2,FirstName="Derin"}
            };
            foreach (var item in customers)
            {
                Console.WriteLine(item.FirstName);
            }
        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");
            cities.Add(1);
            cities.Add("A");

            foreach (var item in cities)
            {
                Console.WriteLine(item);
            }
        }
        class Customer
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
        }
    }
}
