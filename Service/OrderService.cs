using Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Service
{
    public sealed class OrderService
    {
        public List<Order> FakeOrders { get; set; }

        public int DailySales(DateTime date)
        {
            var dailyOrders = this.GetOrders(date);

            var completeOrders = this.FilterOrders(dailyOrders, OrderStatus.Complete);

            var dailySales = this.CalculatorOrderAmount(completeOrders);

            return dailySales;
        }

        private IEnumerable<Order> GetOrders(DateTime date)
        {
            return this.FakeOrders.Where(o => o.Date == date.Date);
        }

        private IEnumerable<Order> FilterOrders(IEnumerable<Order> orders, OrderStatus status)
        {
            return orders.Where(o => o.Status == status);
        }

        private int CalculatorOrderAmount(IEnumerable<Order> orders)
        {
            return orders.Sum(o => this.CalculatorOrderAmount(o));
        }

        private int CalculatorOrderAmount(Order order)
        {
            return order.Detail.Sum(g => g.Price);
        }
    }
}