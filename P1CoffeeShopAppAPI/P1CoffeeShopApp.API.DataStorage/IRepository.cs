using P1CoffeeShopAppAPI.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1CoffeeShopAPI.DataStorage
{

    public interface IRepository
    {
         Task<List<Locations>>GetLocationsAsync();
        //Task<List<Accounts>> GetAccountsAsync();
        Task<List<Customers>>GetAllCustomersAsync();


    }
}
