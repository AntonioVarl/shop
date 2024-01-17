using shop_2._0.Models;

namespace shop_2._0.Data;

public static class ProductsData
{
    public static readonly List<Product> PRODUCTS_LIST = new()
    {
        new Product() {Id = 1 , ProductType = ProductType.Adventure, Name = "Книга", Description = "Думай как программист", Price = 580.50, Count = 100},
        new Product() {Id = 2 , ProductType = ProductType.Undefined ,Name = "Тетрадь", Description = "96 листов", Price = 50, Count = 150},
        new Product() {Id = 3 , ProductType = ProductType.Undefined, Name = "Карандаши", Description = "Цветные", Price = 580.50, Count = 20},
    };
}