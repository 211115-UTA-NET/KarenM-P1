using CoffeeShopApp.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopApp.DataInfrastructure
{

    public interface IRepository
    {
         Task<List<Locations>>GetLocationsAsync();
        //Task<List<Accounts>> GetAccountsAsync();
        


    }
}
