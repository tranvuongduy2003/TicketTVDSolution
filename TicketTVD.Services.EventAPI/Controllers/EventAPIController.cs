using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TicketTVD.Services.EventAPI.Models.Dto;
using TicketTVD.Services.EventAPI.Services.IServices;

namespace TicketTVD.Services.EventAPI.Controllers
{
    [Route("event")]
    [ApiController]
    public class EventAPIController : ControllerBase
    {
        private readonly IEventService _eventService;
        protected ResponseDto _response;

        public EventAPIController(IEventService eventService)
        {
            _eventService = eventService;
            _response = new();
        }

        [HttpGet]
        public async Task<IActionResult> GetEvents()
        {
            try
            {
                var eventDtos = await _eventService.GetEvents();

                _response.Data = eventDtos;
                _response.Message = "Get events successfully!";
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message.ToString();
                return StatusCode(StatusCodes.Status500InternalServerError, _response);
            }

            return Ok(_response);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetEventById(int id)
        {
            try
            {
                var eventDto = await _eventService.GetEventById(id);

                if (eventDto is null)
                {
                    _response.IsSuccess = false;
                    _response.Message = "Không tìm thấy người dùng!";
                    return NotFound(_response);
                }

                _response.Data = eventDto;
                _response.Message = "Get the event successfully!";
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message.ToString();
                return StatusCode(StatusCodes.Status500InternalServerError, _response);
            }

            return Ok(_response);
        }
        
        [HttpPost]
        public async Task<IActionResult> CreateEvent([FromBody] CreateEventDto updateEventDto) {}
        
        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateEvent(int id, [FromBody] UpdateEventDto updateEventDto) {}
        
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteEvent(int id) {}
    }
}