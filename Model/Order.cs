using System;
using System.Collections.Generic;

namespace Model
{
    public sealed class Order
    {
        public Customer Customer { get; set; }

        public DateTime Date { get; set; }

        public List<Goods> Detail { get; set; }

        public OrderStatus Status { get; set; }
    }
}