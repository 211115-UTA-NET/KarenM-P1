using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1CoffeeShopAppAPI.Logic
{
    public class Customers
    {
        //private string customerName;

        private int customerID { get; }
        private string? firstName { get; set; }
        private string? lastName { get; set; }
        public string? email { get; set; }
        private string? phone { get; set; }

        // public string customerName;

        public Customers(int customerID, string firstName, string lastName, string email, string phone)
        {
            this.customerID = customerID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phone = phone;

            
            //_accounts = new List<Accounts>();
        }


        //    public List<Accounts> GetAccounts()
        //    { return _accounts; }

        //    public void SetAccounts(List<Accounts> value)
        //    { _accounts = value; }

        //    private List<Accounts> _accounts;
        //}
    }
}