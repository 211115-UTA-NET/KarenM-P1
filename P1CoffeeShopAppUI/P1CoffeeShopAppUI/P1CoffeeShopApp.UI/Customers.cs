using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1CoffeeShopApp.UI
{
    public class Customers
    {
        public Customers()
        {
            List<string> customers = new();
            string? userInput;
        }
        //Version 2

        private int customerID { get; }
        private string firstName { get; set; }
        private string lastName { get; set; }
        public string email { get; set; }
        private string phone { get; set; }
        //private customerID {get;}
        //private string customerName;
        //private string firstName { get { return firstName; } set { firstName = value; } }
        //private string lastName { get { return lastName; } set { lastName = value; } }   
        //private string customerName { get { return customerName; } set { customerName = value; } }
        //private string email { get { return email; } set { email = value; } }
        //private string phone { get { return phone; } set { phone = value; } }

        //Building a Customer constructor
        //Version 2 goes with Version 3 of Program
        public Customers(int customerID, string firstName, string lastName, string email, string phone)
        {
            this.customerID = customerID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phone = phone;


        }


        public void customerName()
        {
            Console.WriteLine("What's your first name?");
            firstName = Console.ReadLine();
            Console.WriteLine("What's your last name?");
            lastName = Console.ReadLine();
            Console.WriteLine($"Hello {firstName}, {lastName}");
        }




    }
}
