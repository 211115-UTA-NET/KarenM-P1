using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopApp.Logic
{
    public class Customers
    {
        private int customerID { get; }
        private string firstName { get;}
        private string lastName { get;}
        // public string customerName;

       
        public Customers(int customerID, string firstName, string lastName)
        {
            this.customerID = customerID;
            this.firstName = firstName;
            this.lastName = lastName;
            //_accounts = new List<Accounts>();
            
        }

        private void CustomersInfo()
        {
            Console.WriteLine($"{customerID} + {firstName} + {lastName}");
        }

        //    public List<Accounts> GetAccounts()
        //    { return _accounts; }

        //    public void SetAccounts(List<Accounts> value)
        //    { _accounts = value; }

        //    private List<Accounts> _accounts;
        //}
    }
}

