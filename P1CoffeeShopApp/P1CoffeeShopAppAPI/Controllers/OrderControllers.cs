using CoffeeShopApp.DataInfrastructure;
using CoffeeShopApp.Logic;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace P1CoffeeShopAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderControllers : ControllerBase
    {
        private readonly IRepository _repository;

        public OrderControllers(IRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<ActionResult<List<Locations>>>GetAllLocations()
        {
            
            List<Locations> locations = await _repository.GetLocationsAsync();
            return locations;
        }
    }


}
