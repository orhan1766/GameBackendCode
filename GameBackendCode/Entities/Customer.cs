﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendCode.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public long NationalityId { get; set; }
    }
}
