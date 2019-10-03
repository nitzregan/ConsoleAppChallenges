using System;
using _05_Challenge_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Challenge_Tests
{
    [TestClass]
    public class Customer_Tests
    {
        [TestMethod]
        public void AddNewClaim()
        {
            Customer customer = new Customer();
            CustomerRepository repo = new CustomerRepository();
            repo.SeedList();
        }

        [TestMethod]
        public void DeleteCustomer()
        {
            CustomerRepository repo = new CustomerRepository();
            repo.SeedList();
        }

        [TestMethod]
        public void UpdateCustomerInfoByFirstName()
        {
            Customer customer = new Customer();
            CustomerRepository repo = new CustomerRepository();
            repo.SeedList();
        }

        [TestMethod]
        public void UpdateCustomerInfoByLastName()
        {
            Customer customer = new Customer();
            CustomerRepository repo = new CustomerRepository();
            repo.SeedList();
        }


    }
}
