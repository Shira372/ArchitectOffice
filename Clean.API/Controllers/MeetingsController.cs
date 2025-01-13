using ArchitectsOffice.Entities;
using Clean.Core.Services;
using Clean.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ArchitectsOffice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeetingsController : ControllerBase
    {
        private readonly IMeetingService _meetingService;
        public MeetingsController(IMeetingService meetingService)
        {
            _meetingService = meetingService;
        }
        // GET: api/<MeetingsController>
        [HttpGet]
        public IEnumerable<Meeting> GetAll()
        {
            //IArchitectService-השם של הפונקציה צריך להיות כמו
            return _meetingService.GetAll();
        }

        // GET api/<MeetingsController>/5
        [HttpGet("{id}")]

        public IActionResult Get(int id)
        {
            Meeting metting = _meetingService.Get(id);
            if (metting == null)
            {
                return NotFound(); // מחזיר 404 אם הפגישה לא נמצאה
            }
            return Ok(metting); // מחזיר 200 אם הפגישה נמצאה
        }

        //שליפה לפי תאריך וזמן התחלה
        [HttpGet("Get/{start}")]
        public ActionResult GetByStart(DateTime start)
        {
            Meeting meeting = _meetingService.GetByStart(start);
            if (meeting == null)
            {
                return NotFound(); // מחזיר 404 אם הפגישה לא נמצאה
            }
            return Ok(meeting);// מחזיר 200 אם הפגישה נמצאה
        }

        // POST api/<MeetingsController>
        [HttpPost]
        public void Post([FromBody] Meeting meeting)
        {
            _meetingService.Post(meeting);
        }
        // PUT api/<MeetingsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Meeting meeting)
        {
            int request = _meetingService.Put(id, meeting);
            if (request == 1)
            {
                return new EmptyResult();
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            int request = _meetingService.Delete(id);
            if (request == 1)
            {
                return new EmptyResult();
            }
            return NotFound();
        }
    }

}
      
