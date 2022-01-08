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
        private static string connectionString = File.ReadAllText("C:/Users/mkare_wyte20y/Revature/SQL_Database.txt");
         Task<List<Locations>>GetLocationsAsync();
        //Task<List<Accounts>> GetAccountsAsync();
        Task<List<Customers>>GetAllCustomersAsync();
        


    }
}
