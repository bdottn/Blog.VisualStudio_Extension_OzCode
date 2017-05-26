﻿using System.Collections.Generic;

namespace Model
{
    public sealed class Customer
    {
        public string Name { get; set; }

        public List<Order> Orders { get; set; }
    }
}