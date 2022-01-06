using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1CoffeeShopAppAPI.Logic
{
    public class Locations
    {
        public int locationId { get; }
        public int locationName { get; }
        public Locations(int ID, string locationName)
        {
            locationId = ID;
            locationName = locationName;

        }
    }
}
