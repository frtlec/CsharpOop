﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface ICustomerDal //dal data access layer
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("sql added");
        }

        public void Delete()
        {
            Console.WriteLine("sql deleted");
        }

        public void Update()
        {
            Console.WriteLine("sql updated");
        }
    }
    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("oracle updated");
        }

        public void Delete()
        {
            Console.WriteLine("oracle deleted");
        }

        public void Update()
        {
            Console.WriteLine("oracle updated");
        }
    }
    class MySqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySql updated");
        }

        public void Delete()
        {
            Console.WriteLine("MySql deleted");
        }

        public void Update()
        {
            Console.WriteLine("MySql updated");
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
