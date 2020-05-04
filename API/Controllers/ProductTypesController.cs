using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductTypesController : ControllerBase
    {
        private readonly IProductTypeRepository _repo;

        public ProductTypesController(IProductTypeRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProductType>>> GetProductTypes()
        {
            var productTypes = await _repo.GetProductTypesAsync();
            return Ok(productTypes);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductType>> GetProductTypesById(int id)
        {
            return await _repo.GetProductTypesByIdAsync(id);
        }
        
    }
}