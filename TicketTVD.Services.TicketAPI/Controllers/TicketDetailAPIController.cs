using Microsoft.AspNetCore.Mvc;
using TicketTVD.Services.TicketAPI.Models.Dto;
using TicketTVD.Services.TicketAPI.Services.IServices;

namespace TicketTVD.Services.TicketAPI.Controllers
{
    [Route("ticket-detail")]
    [ApiController]
    public class TicketDetailAPIController : ControllerBase
    {
        private readonly ITicketService _ticketService;
        protected ResponseDto _response;

        public TicketDetailAPIController(ITicketService ticketService)
        {
            _ticketService = ticketService;
            _response = new();
        }

        [HttpGet]
        public async Task<IActionResult> GetTicketDetails()
        {
            try
            {
                var ticketDetailDtos = await _ticketService.GetTicketDetails();

                _response.Data = ticketDetailDtos;
                _response.Message = "Get detailed tickets successfully!";
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
        public async Task<IActionResult> GetTicketDetailById(int id)
        {
            try
            {
                var ticketDetailDto = await _ticketService.GetTicketDetailById(id);

                if (ticketDetailDto is null)
                {
                    _response.IsSuccess = false;
                    _response.Message = "Không tìm thấy thông tin chi tiết vé!";
                    return NotFound(_response);
                }

                _response.Data = ticketDetailDto;
                _response.Message = "Get the detailed ticket successfully!";
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
        [Route("event/{eventId:int}")]
        public async Task<IActionResult> GetTicketDetailByEventId(int eventId)
        {
            try
            {
                var ticketDetailDto = await _ticketService.GetTicketDetailByEventId(eventId);

                if (ticketDetailDto is null)
                {
                    _response.IsSuccess = false;
                    _response.Message = "Không tìm thấy thông tin chi tiết vé!";
                    return NotFound(_response);
                }

                _response.Data = ticketDetailDto;
                _response.Message = "Get the detailed ticket successfully!";
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
        public async Task<IActionResult> CreateTicketDetail([FromBody] CreateTicketDetailDto createTicketDetailDto)
        {
            try
            {
                var result = await _ticketService.CreateTicketDetail(createTicketDetailDto);
                
                _response.Message = "Create new detailed ticket successfully!";
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message.ToString();
                return StatusCode(StatusCodes.Status500InternalServerError, _response);
            }

            return Ok(_response);
        }
        
        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> UpdateTicketDetail(int id, [FromBody] CreateTicketDetailDto udpateTicketDetailDto)
        {
            try
            {
                var result = await _ticketService.UpdateTicketDetail(id, udpateTicketDetailDto);

                if (!result)
                {
                    _response.IsSuccess = false;
                    _response.Message = "Thông tin chi tiết vé không tồn tại!";
                    return NotFound(_response);
                }
                
                _response.Message = "Update the detailed ticket successfully!";
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message.ToString();
                return StatusCode(StatusCodes.Status500InternalServerError, _response);
            }

            return Ok(_response);
        }
        
        [HttpPut]
        [Route("event/{eventId:int}")]
        public async Task<IActionResult> UpdateTicketDetailByEventId(int eventId, [FromBody] CreateTicketDetailDto udpateTicketDetailDto)
        {
            try
            {
                var result = await _ticketService.UpdateTicketDetailByEventId(eventId, udpateTicketDetailDto);

                if (!result)
                {
                    _response.IsSuccess = false;
                    _response.Message = "Thông tin chi tiết vé không tồn tại!";
                    return NotFound(_response);
                }
                
                _response.Message = "Update the detailed ticket successfully!";
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