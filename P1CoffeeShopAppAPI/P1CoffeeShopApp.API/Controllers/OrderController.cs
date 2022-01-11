using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using P1CoffeeShopAppAPI.Logic;
using P1CoffeeShopAPI.DataStorage;

namespace P1CoffeeShopApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderControllers : ControllerBase
    {
        private readonly IRepository _repository;
        //Doing this keep this class unit testable

        
        public OrderControllers(IRepository repository)
        {
            _repository = repository;
        }
        //GET /api/Locations
        [HttpGet]
        public async Task<ActionResult<List<Locations>>> GetAllLocations()
        {

            List<Locations> locations = await _repository.GetLocationsAsync();
            return locations;
            //return new JsonResults(locations);
        }

    }
}

