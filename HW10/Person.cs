﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    abstract class Person
    {
        public abstract string FirstName { get; set; }
        public abstract string LastName { get; set; }
        public abstract int Age { get; set; }

        public abstract void DisplayFullName();

    }
}
