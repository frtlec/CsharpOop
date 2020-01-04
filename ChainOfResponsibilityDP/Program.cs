using System;

namespace ChainOfResponsibilityDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Expense
    {
        public string Detail { get; set; }
        public decimal Amount { get; set; }
    }

    abstract class ExpenseHandlerBase
    {
        private ExpenseHandlerBase _successor;
        public abstract void HandleExpense();

        public void SetSuccessor(ExpenseHandlerBase successor)
        {
            _successor = successor;
        }
    }
}
