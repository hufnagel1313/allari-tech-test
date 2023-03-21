using System;
using SimpleProductList.Models;

namespace SimpleProductList.Business.Repositories
{
    public class ProductRepository: IProductRepository
    {
        public ProductRepository()
        {
        }

        public List<ProductModel> GetList(string orderByProperty = null)
        {
            var list = new List<ProductModel> {
                new ProductModel { Id=1, Name="Book", Price = 9.99m, StockCount=50},
                new ProductModel { Id=2, Name="Shampoo", Price = 2.99m, StockCount=324},
                new ProductModel { Id=3, Name="Deodorant", Price = 1.99m, StockCount=643},
                new ProductModel { Id=4, Name="Chalk", Price = 0.59m, StockCount=443},
                new ProductModel { Id=5, Name="Clock", Price = 15.99m, StockCount=345},
                new ProductModel { Id=6, Name="Toothbrush", Price = 4.59m, StockCount=567},
                new ProductModel { Id=7, Name="Knife", Price = 10, StockCount=345},
                new ProductModel { Id=8, Name="Pen", Price = 0.79m, StockCount=876},
                new ProductModel { Id=9, Name="Conditioner", Price = 4, StockCount=345},
                new ProductModel { Id=10, Name="Headphones", Price = 59.99m, StockCount=654},
                new ProductModel { Id=11, Name="Nail clippers", Price = 2.69m, StockCount=987},
                new ProductModel { Id=12, Name="Spoon", Price = 2.99m, StockCount=546},
                new ProductModel { Id=13, Name="Thermometer", Price = 3.5m, StockCount=768},
                new ProductModel { Id=14, Name="Towel", Price = 5.2m, StockCount=234},
                new ProductModel { Id=15, Name="Helmet", Price = 3.8m, StockCount=987},
                new ProductModel { Id=16, Name="Model car", Price = 39.99m, StockCount=345},
                new ProductModel { Id=17, Name="Rubber band", Price = 0.49m, StockCount=656},
                new ProductModel { Id=18, Name="Slippers", Price = 9.99m, StockCount=568},
                new ProductModel { Id=19, Name="Shirt", Price = 19.99m, StockCount=433},
                new ProductModel { Id=20, Name="Purse", Price = 89.99m, StockCount=654}
            };

            if (string.IsNullOrEmpty(orderByProperty))
                return list;

            var sortProperty = typeof(ProductModel).GetProperty(orderByProperty);
            if (sortProperty == null)
                return list;

            return list.OrderBy(p=> sortProperty.GetValue(p)).ToList();
        }
    }
}

