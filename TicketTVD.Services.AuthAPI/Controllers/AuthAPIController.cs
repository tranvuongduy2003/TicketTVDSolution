using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using TicketTVD.Services.AuthAPI.Models.Dto;
using TicketTVD.Services.AuthAPI.Services.IServices;

namespace TicketTVD.Services.AuthAPI.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthAPIController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly IConfiguration _configuration;
        protected ResponseDto _response;

        public AuthAPIController(IAuthService authService, IConfiguration configuration)
        {
            _authService = authService;
            _configuration = configuration;
            _response = new();
        }


        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegistrationRequestDto model)
        {
            try
            {
                var errorMessage = await _authService.Register(model);
                if (!string.IsNullOrEmpty(errorMessage))
                {
                    _response.IsSuccess = false;
                    _response.Message = errorMessage;
                    return BadRequest(_response);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message.ToString());
            }

            return Ok(_response);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDto model)
        {
            try
            {
                var loginResponse = await _authService.Login(model);
                if (loginResponse.User == null)
                {
                    _response.IsSuccess = false;
                    _response.Message = "Tài khoản hoặc mật khẩu không đúng";
                    return Unauthorized(_response);
                }

                _response.Data = loginResponse;
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message.ToString());
            }

            return Ok(_response);
        }
        
        [HttpPost("login/google")]
        public async Task<IActionResult> LoginGoogle([FromBody] LoginGoogleRequestDto model)
        {
            try
            {
                var loginResponse = await _authService.LoginWithGoogle(model);
                if (loginResponse.User == null)
                {
                    _response.IsSuccess = false;
                    _response.Message = "Tài khoản hoặc mật khẩu không đúng";
                    return Unauthorized(_response);
                }

                _response.Data = loginResponse;
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message.ToString());
            }

            return Ok(_response);
        }

        [HttpPost("assign-role")]
        public async Task<IActionResult> AssignRole([FromBody] RegistrationRequestDto model)
        {
            try
            {
                var assignRoleSuccessful = await _authService.AssignRole(model.Email, model.Role.ToUpper());
                if (!assignRoleSuccessful)
                {
                    _response.IsSuccess = false;
                    _response.Message = "Something went wrong";
                    return BadRequest(_response);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message.ToString());
            }

            return Ok(_response);
        }

        [HttpPost("refresh-token")]
        public async Task<IActionResult> RefreshToken([FromBody] RefreshTokenRequestDto tokenRequestDto)
        {
            try
            {
                var accessToken = Request.Headers[HeaderNames.Authorization].ToString().Replace("Bearer ", "");
                if (tokenRequestDto is null || tokenRequestDto.RefreshToken is null || tokenRequestDto.RefreshToken == "" ||
                    accessToken is null || accessToken == "")
                {
                    _response.IsSuccess = false;
                    _response.Message = "Invalid client request";
                    return BadRequest(_response);
                }


                var newAccessToken = await _authService.RefreshToken(accessToken, tokenRequestDto.RefreshToken);

                if (newAccessToken == "" || newAccessToken is null)
                {
                    _response.IsSuccess = false;
                    _response.Message = "Invalid access token or refresh token";
                    return BadRequest(_response);
                }

                _response.Data = newAccessToken;
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message.ToString());
            }

            return Ok(_response);
        }
        
        [HttpGet("profile")]
        public async Task<IActionResult> GetUserProfile()
        {
            try
            {
                var accessToken = Request.Headers[HeaderNames.Authorization].ToString().Replace("Bearer ", "");
                var user = await _authService.GetUserProfile(accessToken);
                if (user is null)
                {
                    _response.IsSuccess = false;
                    _response.Message = "Unauthorized";
                    return Unauthorized(_response);
                }

                _response.Data = user;
                _response.Message = "Get user profile successfully";
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message.ToString());
            }

            return Ok(_response);
        }
    }
}