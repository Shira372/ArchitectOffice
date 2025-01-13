using AutoMapper;
using Clean.API.Models;
using Clean.Core;
using Clean.Core.DTOs;
using Clean.Core.Models;
using Clean.Data;
using Clean.Data.Services;
using Clean.Service;
using Microsoft.AspNetCore.Mvc;


namespace Clean.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArchitectsController : ControllerBase
    {
        private readonly IArchitectService _architectService;
        //private readonly Mapping _mapping;
        private readonly IMapper _mapper;
        public ArchitectsController(IArchitectService architectService, IMapper mapper)
        {
            _architectService = architectService;
            _mapper = mapper;
        }
        // GET: api/<ArchitectsController>
        [HttpGet]
        public IActionResult Get()
        {
            //IArchitectService-השם של הפונקציה צריך להיות כמו
            var list = _architectService.GetAll();
            var listDTO = _mapper.Map <IEnumerable<ArchitectDTO>>(list);
            return Ok(listDTO);
            //return _architectService.GetAll();
        }

        // GET api/<ArchitectsController>/5
        [HttpGet("{id}")]

        public IActionResult Get(int id)
        {
            Architect architect = _architectService.GetItem(id);
            //var architectDTO =_mapping.MapToArchitectDTO(architect);
            var architectDTO = _mapper.Map<ArchitectDTO>(architect);
            if (architectDTO == null)
            {
                return NotFound(); // מחזיר 404 אם האדריכל לא נמצא
            }
            return Ok(architectDTO); // מחזיר 200 אם האדריכל נמצא
        }

        // POST api/<ArchitectsController>
        [HttpPost]
        public void Post([FromBody] ArchitectPostModel architect)
        {
            var architectToAdd = new Architect { Name = architect.Name, Status = architect.Status, PlanId = architect.PlanId };
            _architectService.Post(architectToAdd);
        }
        // PUT api/<ArchitectsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Architect architect)
        {
            int request = _architectService.PutByArchitect(id, architect);
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
            int request = _architectService.PutByStatus(id, status);
            if (request == 1)
            {
                return new EmptyResult();
            }
            return NotFound();
        }
    }
}

