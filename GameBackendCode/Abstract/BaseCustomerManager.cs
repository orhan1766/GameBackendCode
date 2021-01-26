using GameBackendCode.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendCode.Abstract
{
    public abstract class BaseCustomerManager : ICustomerManager
    {
        public virtual void Add(Customer customer)
        {
            Console.WriteLine("{0} adlı kullanıcı eklendi!",customer.FirstName);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("{0} adlı kullanıcının bilgileri silindi!", customer.FirstName);
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("{0} adlı kullanıcının bilgileri güncellendi!", customer.FirstName);
        }
    }
}
