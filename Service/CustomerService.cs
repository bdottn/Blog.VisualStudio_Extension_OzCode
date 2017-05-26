using Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Service
{
    public sealed class CustomerService
    {
        public Customer FakeCustomer { get; set; }

        public int TotalCost()
        {
            try
            {
                return this.GetGoods().Sum(g => g.Price);
            }
            catch (Exception ex)
            {
                throw new Exception("TotalCost Exception", ex);
            }
        }

        private IEnumerable<Goods> GetGoods()
        {
            try
            {
                return this.FilterOrders(OrderStatus.Complete).SelectMany(o => o.Detail);
            }
            catch (Exception ex)
            {
                throw new Exception("GetGoods Exception", ex);
            }
        }

        private IEnumerable<Order> FilterOrders(OrderStatus status)
        {
            try
            {
                return this.GetOrders().Where(o => o.Status == status);
            }
            catch (Exception ex)
            {
                throw new Exception("FilterOrders Exception", ex);
            }
        }

        private IEnumerable<Order> GetOrders()
        {
            try
            {
                return this.FakeCustomer.Orders;
            }
            catch (Exception ex)
            {
                throw new Exception("GetOrders Exception", ex);
            }
        }
    }
}