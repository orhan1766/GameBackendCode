using GameBackendCode.Abstract;
using GameBackendCode.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendCode.Concrete
{
    public class CustomerManager : BaseCustomerManager
    {
        ICheckPersonService _checkPersonService;

        public CustomerManager(ICheckPersonService checkPersonService)
        {
            _checkPersonService = checkPersonService;
        }

        public override void Add(Customer customer)
        {
            if (_checkPersonService.CheckIfRealPerson(customer))
            {
                base.Add(customer);
            }
            else
            {
                throw new Exception("Geçerli bir kişi değil!");
            }
            
        }
    }
}
