using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TicketTVD.Services.CategoryAPI.Models.Dto;
using TicketTVD.Services.CategoryAPI.Services.IServices;

namespace TicketTVD.Services.CategoryAPI.Controllers
{
    [Route("category")]
    [ApiController]
    public class CategoryAPIController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        protected ResponseDto _response;

        public CategoryAPIController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
            _response = new();
        }

        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            try
            {
                var categoryDtos = await _categoryService.GetCategories();

                _response.Data = categoryDtos;
                _response.Message = "Get categories successfully!";
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
        public async Task<IActionResult> GetCategoryById(int id)
        {
            try
            {
                var categoryDto = await _categoryService.GetCategoryById(id);

                if (categoryDto is null)
                {
                    _response.IsSuccess = false;
                    _response.Message = "Không tìm thấy thể loại!";
                    return NotFound(_response);
                }

                _response.Data = categoryDto;
                _response.Message = "Get the category successfully!";
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
        public async Task<IActionResult> CreateCategory([FromBody] CreateCategoryDto createCategoryDto)
        {
            try
            {
                var categoryDto = await _categoryService.CreateCategory(createCategoryDto);

                _response.Data = categoryDto;
                _response.Message = "Create the category successfully!";
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
        public async Task<IActionResult> UpdateCategory(int id, [FromBody] CreateCategoryDto updateCategoryDto)
        {
            try
            {
                var result = await _categoryService.UpdateCategory(id, updateCategoryDto);

                if (!result)
                {
                    _response.IsSuccess = false;
                    _response.Message = "Không tìm thấy thể loại!";
                    return NotFound(_response);
                }

                _response.Message = "Update the category successfully!";
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
        public async Task<IActionResult> DeleteCategory(int id)
        {
            try
            {
                var result = await _categoryService.DeleteCategory(id);

                if (!result)
                {
                    _response.IsSuccess = false;
                    _response.Message = "Không tìm thấy thể loại!";
                    return NotFound(_response);
                }

                _response.Message = "Delete the category successfully!";
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