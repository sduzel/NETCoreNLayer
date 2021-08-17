using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NETCoreNLayer.API.Dto;
using NETCoreNLayer.Core.Models;
using NETCoreNLayer.Core.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NETCoreNLayer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        public CategoriesController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categories = await _categoryService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<CategoryDto>>(categories));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var category = await _categoryService.GetByIdAsync(id);
            return Ok(_mapper.Map<CategoryDto>(category));
        }
        [HttpPost]
        public async Task<IActionResult> Save(CategoryDto category)
        {
            var newCategory = await _categoryService.AddAsync(_mapper.Map<Category>(category));
            return Created(string.Empty, _mapper.Map<CategoryDto>(newCategory));
        }

        [HttpPut]
        public IActionResult Update(CategoryDto category)
        {
            _categoryService.Update(_mapper.Map<Category>(category));
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var category = _categoryService.GetByIdAsync(id).Result;
            _categoryService.Remove(category);
            return NoContent();
        }
        [HttpGet("{id}/products")]
        public async Task<IActionResult> GetWithProductsById(int id)
        {
            var category = await _categoryService.GetWithProductsByIdAsync(id);
            return Ok(_mapper.Map<CategoryProductsDto>(category));
        }
    }
}
