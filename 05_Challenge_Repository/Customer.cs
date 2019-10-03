using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Challenge_Repository
{
    public enum CustomerType { CurrentCustomer = 1, PastCustomer, PotentialCustomer }
    public class Customer
    {
        public Customer(string firstName, string lastName, CustomerType typeOfCustomer)
        {
            FirstName = firstName;
            LastName = lastName;
            TypeOfCustomer = typeOfCustomer;
            Email = CustomerEmail();
        }

        public Customer()
        {

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public CustomerType TypeOfCustomer { get; set; }
        public string Email { get; set; }

        public string CustomerEmail()
        {
            switch (TypeOfCustomer)
            {
                case CustomerType.CurrentCustomer:
                    return "Thank you for your work with us. We appreciate your loyalty. Here's a coupon.";
                case CustomerType.PastCustomer:
                    return "It's been a long time since we've heard from you, we want you back.";
                case CustomerType.PotentialCustomer:
                default:
                    return "We currently have the lowest rates on Helicopter Insurance!";
            }
        }

        public override string ToString()
        {
            return $"Customer Name: {FirstName} {LastName}\n" +
                $"Customer Type: {TypeOfCustomer}\n" +
                $"Email: {Email}\n";
        }
    }
}
