using GameBackendCode.Abstract;
using GameBackendCode.Concrete;
using System;

namespace GameBackendCode
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new CustomerManager(new CheckPersonManager());
            customerManager.Add(new Entities.Customer { FirstName = "Orhan", LastName = "Doğan", BirthYear = 1990, NationalityId = 12345678910 });

            Console.ReadLine();
        }
    }
}
