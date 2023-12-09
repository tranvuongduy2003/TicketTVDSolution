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
        public async Task<IActionResult> GetEvents([FromQuery] string? search)
        {
            try
            {
                var eventDtos = await _eventService.GetEvents(search);

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
        
        [HttpGet("statistic-by-category")]
        public async Task<IActionResult> GetEventsStatisticByCategory()
        {
            try
            {
                var eventDtos = await _eventService.GetEventsStatisticByCategory();

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
        
        [HttpPost]
        [Route("/get-events-by-tickets")]
        public async Task<IActionResult> GetEventsByTickets([FromBody] EventsByTicketsDto eventsByTicketsDto)
        {
            try
            {
                var eventDtos = await _eventService.GetEventsByTickets(eventsByTicketsDto);

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
        
        [Authorize]
        [Authorize(Roles = "ORGANIZER")]
        [HttpGet]
        [Route("{organizerId}")]
        public async Task<IActionResult> GetEventsByOrganizerId(string organizerId)
        {
            try
            {
                var eventDtos = await _eventService.GetEventsByOrganizerId(organizerId);

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

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetEventById(int id)
        {
            try
            {
                var eventDto = await _eventService.GetEventById(id);

                if (eventDto is null)
                {
                    _response.IsSuccess = false;
                    _response.Message = "Không tìm thấy sự kiện!";
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
        public async Task<IActionResult> CreateEvent([FromBody] CreateEventDto createEventDto)
        {
            try
            {
                var eventDto = await _eventService.CreateEvent(createEventDto);

                _response.Data = eventDto;
                _response.Message = "Create the event successfully!";
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message.ToString();
                return StatusCode(StatusCodes.Status500InternalServerError, _response);
            }

            return Ok(_response);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateEvent(int id, [FromBody] UpdateEventDto updateEventDto)
        {
            try
            {
                var result = await _eventService.UpdateEvent(id, updateEventDto);

                if (!result)
                {
                    _response.IsSuccess = false;
                    _response.Message = "Không tìm thấy sự kiện!";
                    return NotFound(_response);
                }

                _response.Message = "Update the event successfully!";
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message.ToString();
                return StatusCode(StatusCodes.Status500InternalServerError, _response);
            }

            return Ok(_response);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteEvent(int id)
        {
            try
            {
                var result = await _eventService.DeleteEvent(id);

                if (!result)
                {
                    _response.IsSuccess = false;
                    _response.Message = "Không tìm thấy sự kiện!";
                    return NotFound(_response);
                }

                _response.Message = "Delete the event successfully!";
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message.ToString();
                return StatusCode(StatusCodes.Status500InternalServerError, _response);
            }

            return Ok(_response);
        }
        
        [HttpPatch("/increase-favourite/{id:int}")]
        public async Task<IActionResult> IncreaseFavourite(int id)
        {
            try
            {
                var result = await _eventService.IncreaseFavourite(id);
                
                if (!result)
                {
                    _response.IsSuccess = false;
                    _response.Message = "Không tìm thấy sự kiện!";
                    return NotFound(_response);
                }

                _response.Data = result;
                _response.Message = "Create the event successfully!";
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message.ToString();
                return StatusCode(StatusCodes.Status500InternalServerError, _response);
            }

            return Ok(_response);
        }
        
        [HttpPatch("/decrease-favourite/{id:int}")]
        public async Task<IActionResult> DecreaseFavourite(int id)
        {
            try
            {
                var result = await _eventService.DecreaseFavourite(id);
                
                if (!result)
                {
                    _response.IsSuccess = false;
                    _response.Message = "Không tìm thấy sự kiện!";
                    return NotFound(_response);
                }

                _response.Data = result;
                _response.Message = "Create the event successfully!";
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message.ToString();
                return StatusCode(StatusCodes.Status500InternalServerError, _response);
            }

            return Ok(_response);
        }
        
        [HttpPatch("/increase-share/{id:int}")]
        public async Task<IActionResult> IncreaseShare(int id)
        {
            try
            {
                var result = await _eventService.IncreaseShare(id);

                if (!result)
                {
                    _response.IsSuccess = false;
                    _response.Message = "Không tìm thấy sự kiện!";
                    return NotFound(_response);
                }

                _response.Data = result;
                _response.Message = "Create the event successfully!";
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message.ToString();
                return StatusCode(StatusCodes.Status500InternalServerError, _response);
            }

            return Ok(_response);
        }
        
        [HttpPatch("/decrease-share/{id:int}")]
        public async Task<IActionResult> DecreaseShare(int id)
        {
            try
            {
                var result = await _eventService.DecreaseShare(id);

                if (!result)
                {
                    _response.IsSuccess = false;
                    _response.Message = "Không tìm thấy sự kiện!";
                    return NotFound(_response);
                }

                _response.Data = result;
                _response.Message = "Create the event successfully!";
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message.ToString();
                return StatusCode(StatusCodes.Status500InternalServerError, _response);
            }

            return Ok(_response);
        }
    }
}