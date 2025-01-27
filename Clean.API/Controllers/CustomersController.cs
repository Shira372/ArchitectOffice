using ArchitectsOffice.Entities;
using Clean.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Clean.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var customers = await _customerService.GetAllAsync();
            return Ok(customers);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetItem(int id)
        {
            var customer = await _customerService.GetItemAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Customer customer)
        {
            await _customerService.PostAsync(customer);
            return CreatedAtAction(nameof(GetItem), new { id = customer.Id }, customer);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutByCustomer(int id, [FromBody] Customer customer)
        {
            var result = await _customerService.PutByCustomerAsync(id, customer);
            if (result == 0)
            {
                return NotFound();
            }
            return NoContent();
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> PutByStatus(int id, [FromBody] int status)
        {
            var result = await _customerService.PutByStatusAsync(id, status);
            if (result == 0)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
