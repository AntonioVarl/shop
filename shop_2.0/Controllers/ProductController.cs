using Microsoft.AspNetCore.Mvc;
using shop_2._0.Models;
using static shop_2._0.Data.ProductsData;

namespace shop_2._0.Controllers;

[Route("[controller]")]
public class ProductController : ControllerBase
{
    [HttpPost("")]
    public Product CreateProduct([FromBody] Product product)
    {
        product.Id = PRODUCTS_LIST.Count == 0 ? 1 : PRODUCTS_LIST.Last().Id + 1;
        product.Price = Math.Round(product.Price, 2);
        PRODUCTS_LIST.Add(product);
        return PRODUCTS_LIST.Last();
    }
    
    
    [HttpGet("{id}")]
    public Product ReadProduct([FromRoute]int id)
    {
        return PRODUCTS_LIST[id];
    }
    
    [HttpPost("{id}")]
    public Product UpdateProduct([FromRoute]int id, [FromBody] Product updatedProduct)
    {
        updatedProduct.Price = Math.Round(updatedProduct.Price, 2);
        updatedProduct.Id = PRODUCTS_LIST[id].Id;
        PRODUCTS_LIST[id] = updatedProduct;
        return PRODUCTS_LIST[id];
    }

    [HttpDelete("{id}")]
    public void DeleteProduct([FromRoute] int id)
    {
        var i = PRODUCTS_LIST.FindIndex(x => x.Id == id);
        PRODUCTS_LIST.RemoveAt(i);
    }

   
}