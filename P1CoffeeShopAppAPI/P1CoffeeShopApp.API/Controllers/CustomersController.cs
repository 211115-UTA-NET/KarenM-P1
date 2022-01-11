using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using P1CoffeeShopAPI.DataStorage;
using P1CoffeeShopAppAPI.Logic;

namespace P1CoffeeShopApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private IRepository _repository;

        public CustomersController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]// (":{name}")]//???
        public Task<List<Customers>> GetAllCustomers([FromQuery] string name)

        //public async Task<List<Customers>> GetAllCustomersAsyn([FromQuery] string name)
        {
            List<Customers> customers = new List<Customers>();
            return null;
            //return customers;
            //await _repository.GetAllCustomersAsync(names);
        }
    }
}
