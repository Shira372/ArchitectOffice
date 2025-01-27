using ArchitectsOffice.Entities;
using Clean.Core.Services;
using Clean.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        public async Task<IEnumerable<Meeting>> GetAll()
        {
            return await _meetingService.GetAllAsync();
        }

        // GET api/<MeetingsController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var meeting = await _meetingService.GetAsync(id);
            if (meeting == null)
            {
                return NotFound(); // returns 404 if the meeting is not found
            }
            return Ok(meeting); // returns 200 if the meeting is found
        }

        // GET by start time
        [HttpGet("Get/{start}")]
        public async Task<ActionResult> GetByStart(DateTime start)
        {
            var meeting = await _meetingService.GetByStartAsync(start);
            if (meeting == null)
            {
                return NotFound(); // returns 404 if the meeting is not found
            }
            return Ok(meeting); // returns 200 if the meeting is found
        }

        // POST api/<MeetingsController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Meeting meeting)
        {
            await _meetingService.PostAsync(meeting);
            return CreatedAtAction(nameof(Get), new { id = meeting.Id }, meeting);
        }

        // PUT api/<MeetingsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Meeting meeting)
        {
            var result = await _meetingService.PutAsync(id, meeting);
            if (result == 1)
            {
                return NoContent(); // returns 204 if the update was successful
            }
            return NotFound(); // returns 404 if the meeting is not found
        }

        // DELETE api/<MeetingsController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _meetingService.DeleteAsync(id);
            if (result == 1)
            {
                return NoContent(); // returns 204 if the delete was successful
            }
            return NotFound(); // returns 404 if the meeting is not found
        }
    }
}
