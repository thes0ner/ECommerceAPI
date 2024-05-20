using ECommerceAPI.Application.Repositories;
using ECommerceAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        readonly private IProductReadRepository _productReadRepository;
        readonly private IProductWriteRepository _productWriteRepository;

        public ProductsController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
        }

        [HttpGet]
        public async Task Get()
        {
            //await _productWriteRepository.AddRangeAsync(new()
            //{
            //    new() {Id = Guid.NewGuid(), Name = "Product 1", Stock = 100,Price =100, CreatedDate = DateTime.Now},
            //    new() {Id = Guid.NewGuid(), Name = "Product 2", Stock = 200,Price =200, CreatedDate = DateTime.Now},
            //    new() {Id = Guid.NewGuid(), Name = "Product 3", Stock = 300,Price =300, CreatedDate = DateTime.Now},
            //});

            //await _productWriteRepository.SaveAsync();

            Product product = await _productReadRepository.GetByIdAsync("16F2E843-54C6-4650-BAA2-98718AD5901D", false);
            product.Name = "Socks2";

            await _productWriteRepository.SaveAsync();

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            Product product = await _productReadRepository.GetByIdAsync(id);
            return Ok(product);
        }

    }

}
