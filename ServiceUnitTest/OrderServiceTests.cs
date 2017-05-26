using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using System;
using System.Collections.Generic;

namespace Service.UnitTest
{
    [TestClass]
    public sealed class OrderServiceTests
    {
        private OrderService service;

        [TestInitialize]
        public void TestInitialize()
        {
            this.service = new OrderService();

            this.service.FakeOrders =
                new List<Order>()
                {
                    new Order()
                    {
                        Customer = 
                            new Customer()
                            {
                                Name = "高級書僮",
                            },
                        Date = new DateTime(2017, 05, 27),
                        Detail = 
                            new List<Goods>()
                            {
                                new Goods()
                                {
                                    Name = "唐家霸王槍",
                                    Price = 99999,
                                },
                                new Goods()
                                {
                                    Name = "含笑半步癲",
                                    Price = 3000,
                                },
                            },
                        Status = OrderStatus.Complete,
                    },
                    new Order()
                    {
                        Customer = 
                            new Customer()
                            {
                                Name = "華太師",
                            },
                        Date = new DateTime(2017, 05, 27),
                        Detail = 
                            new List<Goods>()
                            {
                                new Goods()
                                {
                                    Name = "一日喪命散",
                                    Price = 3000,
                                },
                                new Goods()
                                {
                                    Name = "一日喪命散",
                                    Price = 3000,
                                },
                                new Goods()
                                {
                                    Name = "一日喪命散",
                                    Price = 3000,
                                },
                            },
                        Status = OrderStatus.Cancel,
                    },
                    new Order()
                    {
                        Customer = 
                            new Customer()
                            {
                                Name = "對穿腸",
                            },
                        Date = new DateTime(2017, 05, 28),
                        Detail = 
                            new List<Goods>()
                            {
                                new Goods()
                                {
                                    Name = "一日喪命散",
                                    Price = 3000,
                                },
                            },
                        Status = OrderStatus.Complete,
                    },
                };
        }

        [TestMethod]
        public void DailySalesTest_傳入日期為20170527_預期回傳102999()
        {
            var date = new DateTime(2017, 05, 27);

            var expected = 102999;

            var actual = this.service.DailySales(date);

            Assert.AreEqual(expected, actual);
        }
    }
}