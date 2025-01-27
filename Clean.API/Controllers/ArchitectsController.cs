using AutoMapper;
using Clean.API.Models;
using Clean.Core;
using Clean.Core.DTOs;
using Clean.Core.Models;
using Clean.Data;
//using Clean.Data.Services;
using Clean.Service;
using Microsoft.AspNetCore.Mvc;

namespace Clean.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArchitectsController : ControllerBase
    {
        private readonly IArchitectService _architectService;
        private readonly IMapper _mapper;

        public ArchitectsController(IArchitectService architectService, IMapper mapper)
        {
            _architectService = architectService;
            _mapper = mapper;
        }

        // GET: api/<ArchitectsController>
        [HttpGet]
        public async Task<IActionResult> Get()  // שינוי לאסינכרוני
        {
            var list = await _architectService.GetAllAsync();  // שימוש ב-GetAllAsync
            var listDTO = _mapper.Map<IEnumerable<ArchitectDTO>>(list);
            return Ok(listDTO);
        }

        // GET api/<ArchitectsController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)  // שינוי לאסינכרוני
        {
            var architect = await _architectService.GetItemAsync(id);  // שימוש ב-GetItemAsync
            if (architect == null)
            {
                return NotFound(); // מחזיר 404 אם האדריכל לא נמצא
            }
            var architectDTO = _mapper.Map<ArchitectDTO>(architect);
            return Ok(architectDTO); // מחזיר 200 אם האדריכל נמצא
        }

        // POST api/<ArchitectsController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ArchitectPostModel architect)  // שינוי לאסינכרוני
        {
            var architectToAdd = new Architect { Name = architect.Name, Status = architect.Status, PlanId = architect.PlanId };
            await _architectService.PostAsync(architectToAdd);  // שימוש ב-PostAsync
            return NoContent();  // מחזיר 204 אחרי שההוספה התבצעה בהצלחה
        }

        // PUT api/<ArchitectsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Architect architect)  // שינוי לאסינכרוני
        {
            var request = await _architectService.PutByArchitectAsync(id, architect);  // שימוש ב-PutByArchitectAsync
            if (request == 1)
            {
                return NoContent();  // מחזיר 204 אם הביצוע הצליח
            }
            return NotFound();  // מחזיר 404 אם לא נמצא אדריכל עם אותו ID
        }

        [HttpPut("Put/{id}")]
        public async Task<ActionResult> Put(int id, int status)  // שינוי לאסינכרוני
        {
            var request = await _architectService.PutByStatusAsync(id, status);  // שימוש ב-PutByStatusAsync
            if (request == 1)
            {
                return NoContent();  // מחזיר 204 אם הביצוע הצליח
            }
            return NotFound();  // מחזיר 404 אם לא נמצא אדריכל עם אותו ID
        }
    }
}
