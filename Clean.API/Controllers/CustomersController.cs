using ArchitectsOffice.Entities;
using Clean.Core.Models;
using Clean.Core.Services;
using Clean.Data.Services;
using Microsoft.AspNetCore.Mvc;


namespace ArchitectsOffice.Controllers
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
        // GET: api/<CustomersController>
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            //IArchitectService-השם של הפונקציה צריך להיות כמו
            return _customerService.GetAll();
        }

        // GET api/<CustomersController>/5
        [HttpGet("{id}")]

        public IActionResult Get(int id)
        {
            Customer customer = _customerService.GetItem(id);
            if (customer == null)
            {
                return NotFound(); // מחזיר 404 אם הלקוח לא נמצא
            }
            return Ok(customer); // מחזיר 200 אם הלקוח נמצא
        }

        // POST api/<CustomersController>
        [HttpPost]
        public void Post([FromBody] Customer customer)
        {
            _customerService.Post(customer);
        }
        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Customer customer)
        {
            int request = _customerService.PutByCustomer(id, customer);
            if (request == 1)
            {
                return new EmptyResult();
            }
            return NotFound();
        }

        [HttpPut("Put/{id}")]
        //במקום מחיקה-שינוי סטטוס ל-0
        public ActionResult Put(int id, int status)
        {
            int request = _customerService.PutByStatus(id, status);
            if (request == 1)
            {
                return new EmptyResult();
            }
            return NotFound();
        }
    }
}
