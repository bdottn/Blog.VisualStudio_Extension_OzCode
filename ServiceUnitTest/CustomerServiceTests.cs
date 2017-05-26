using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using System;

namespace Service.UnitTest
{
    [TestClass]
    public sealed class CustomerServiceTests
    {
        private CustomerService service;

        [TestInitialize]
        public void TestInitialize()
        {
            this.service = new CustomerService();
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TotalCostTest_傳入Customer_訂單為null_預期回傳Exception()
        {
            this.service.FakeCustomer =
                new Customer()
                {
                    Name = "高級書僮",
                    Orders = null,
                };

            this.service.TotalCost();
        }
    }
}