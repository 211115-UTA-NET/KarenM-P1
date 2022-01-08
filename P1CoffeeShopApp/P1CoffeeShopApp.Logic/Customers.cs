using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopApp.Logic
{
    public class Customers
    {
        public int customerID { get; }
        public string firstName { get;}
        public string lastName { get;}
        // public string customerName;


        public Customers(int customerID, string firstName, string lastName)
        {
            customerID = customerID;
            firstName = firstName;
            lastName = lastName;
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

