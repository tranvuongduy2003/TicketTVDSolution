using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Stripe.Checkout;
using TicketTVD.Services.PaymentAPI.Models.Dto;
using Stripe;
using TicketTVD.MessageBus;
using TicketTVD.Services.PaymentAPI.Data;
using TicketTVD.Services.PaymentAPI.Models;
using TicketTVD.Services.PaymentAPI.Models.Enum;
using TicketTVD.Services.PaymentAPI.Services;
using TicketTVD.Services.PaymentAPI.Services.IServices;

namespace TicketTVD.Services.PaymentAPI.Controllers
{
    [Route("statistic")]
    [ApiController]
    public class StatisticAPIController : ControllerBase
    {
        private readonly IStatisticService _statisticService;
        protected ResponseDto _response;

        public StatisticAPIController(IStatisticService statisticService)
        {
            _statisticService = statisticService;
            _response = new();
        }
        
        [HttpGet("general")]
        public async Task<IActionResult> GetGeneralStatistic()
        {
            try
            {
                var generalStatistic = await _statisticService.GetGeneralStatistic();
                
                _response.Data = generalStatistic;
                _response.Message = "Get statistics successfully!";
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