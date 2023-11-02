using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TicketTVD.Services.TicketAPI.Models.Dto;
using TicketTVD.Services.TicketAPI.Services.IServices;

namespace TicketTVD.Services.TicketAPI.Controllers
{
    [Route("ticket")]
    [ApiController]
    public class TicketAPIController : ControllerBase
    {
        private readonly ITicketService _ticketService;
        protected ResponseDto _response;

        public TicketAPIController(ITicketService ticketService)
        {
            _ticketService = ticketService;
            _response = new();
        }

        [HttpGet]
        public async Task<IActionResult> GetTickets()
        {
            try
            {
                var ticketDtos = await _ticketService.GetTickets();

                _response.Data = ticketDtos;
                _response.Message = "Get tickets successfully!";
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
        public async Task<IActionResult> GetTicketById(int id)
        {
            try
            {
                var ticketDto = await _ticketService.GetTicketById(id);

                if (ticketDto is null)
                {
                    _response.IsSuccess = false;
                    _response.Message = "Không tìm thấy thông tin vé!";
                    return NotFound(_response);
                }

                _response.Data = ticketDto;
                _response.Message = "Get the ticket successfully!";
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