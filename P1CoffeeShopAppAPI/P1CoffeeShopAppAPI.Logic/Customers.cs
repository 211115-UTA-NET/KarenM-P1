using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1CoffeeShopAppAPI.Logic
{
    public class Customers
    {
        private string customerName;

        private int customerID { get; }
        private string firstName { get; set; }
        private string lastName { get; set; }
        
        // public string customerName;

        public Customers(int customerID, string firstName, string lastName)
        {
            customerID = customerID;
            //firstName = firstName;
            //lastName = lastName;
            //_accounts = new List<Accounts>();
            customerName = firstName + lastName;
        }

        //    public List<Accounts> GetAccounts()
        //    { return _accounts; }

        //    public void SetAccounts(List<Accounts> value)
        //    { _accounts = value; }

        //    private List<Accounts> _accounts;
        //}
    }
}