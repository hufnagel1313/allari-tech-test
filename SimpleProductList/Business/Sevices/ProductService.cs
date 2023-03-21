using System;
using SimpleProductList.Business.Repositories;
using SimpleProductList.Models;

namespace SimpleProductList.Business.Sevices
{
	public class ProductService : IProductService
	{
		private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public List<ProductModel> GetList(string orderByProperty = null)
		{
            return _productRepository.GetList(orderByProperty);
		}

    }
}

