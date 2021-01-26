using GameBackendCode.Abstract;
using GameBackendCode.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendCode.Concrete
{
    public class CheckPersonManager : ICheckPersonService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
