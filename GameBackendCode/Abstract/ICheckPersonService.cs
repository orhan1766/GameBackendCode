using GameBackendCode.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendCode.Abstract
{
    public interface ICheckPersonService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
