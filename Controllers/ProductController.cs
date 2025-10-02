using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
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
        public IEnumerable<Product> GetProducts(int id)
        {
            return _dbContext.Products.Where(p => p.Id == id).ToList();
        }


        [HttpPost]
        public void PostProducts(CreateDTO dto)
        {
            var Product = new Product();
            Product.Name = dto.Name;
            Product.Description = dto.Description;
            Product.Price = dto.Price;
            _dbContext.Add(Product);
            _dbContext.SaveChanges();
        }



        [HttpGet]
   

        public ActionResult<List<ResponseDTO>> GetAllProducts()
        {
            var products = _dbContext.Products.Select(p => new ResponseDTO
            {
                Name = p.Name,
                Price = p.Price,
                Description = p.Description,
                Id = p.Id
            }
            );
               
            
            return products.ToList();
        }





        [HttpDelete]
        public void DeleteProduct(int id)
        {
            var product = _dbContext.Products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                _dbContext.Products.Remove(product);
                _dbContext.SaveChanges();
            }
            else
            {
                throw new Exception("Product not found");
            }

        


        }
            
    }
}


