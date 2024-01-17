namespace shop_2._0.Models;

public class Product
{
    public int Id { get; set; }
    
    public ProductType ProductType { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public int Count { get; set; }
}