using System;
using System.Collections;
using System.Collections.Generic;

namespace CompositeDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee engin = new Employee {
                Name="Engin Demiroğ"
            };
            Employee salih = new Employee
            {
                Name = "Salih Demiroğ"
            };
            Employee derin = new Employee
            {
                Name = "Derin Demiroğ"
            };

            Contractor ali = new Contractor
            {
                Name="Ali"
            };

            derin.AddSubordinate(ali);
            engin.AddSubordinate(salih);
            engin.AddSubordinate(derin);
            Employee ahmet = new Employee
            {
                Name = "Ahmet Demiroğ"
            };
            salih.AddSubordinate(ahmet);
            Console.WriteLine(engin.Name);
            foreach (Employee manager in engin)
            {
                Console.WriteLine("  {0}",manager.Name);
                foreach (IPerson empleyee in manager)
                {
                    Console.WriteLine("    {0}",empleyee.Name);
                }
            }
        }
    }
    interface IPerson
    {
        public string Name { get; set; }
    }

    class Contractor : IPerson
    {
        public string Name { get; set; }
    }
    class Employee : IPerson, IEnumerable<IPerson>
    {
        List<IPerson> _subordinates = new List<IPerson>();

        public void AddSubordinate(IPerson person)
        {
            _subordinates.Add(person);
        }
        public void RemoveSubordinate(IPerson person)
        {
            _subordinates.Remove(person);
        }
        public IPerson GetSubordinate(int index)
        {
            return _subordinates[index];
        }

        public string Name { get; set; }
        public IEnumerator<IPerson> GetEnumerator()
        {
            foreach (var subordinate in _subordinates)
            {
                yield return subordinate;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
