using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiPractice.Data;
using WebApiPractice.Models;
namespace WebApiPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        public ProductController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("my-rout/{id}")]
        public IActionResult GetAll (int id)
        {
            return Ok();
        }

        [HttpPost]
        public void PostProducts(string Name, decimal Price, string Description)
        {
            var Product = new Product();
            Product.Name = Name;
            Product.Description = Description;
            Product.Price = Price;
            _dbContext.Add(Product);
            _dbContext.SaveChanges();
        }

    }
}
