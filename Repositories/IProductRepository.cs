using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using WebApiPractice.Models;

public interface IProductRepository
{
    
    void PostProducts(CreateDTO dto);
    void DeleteProduct(int id);
    IEnumerable<Product> GetProducts(int id);

}