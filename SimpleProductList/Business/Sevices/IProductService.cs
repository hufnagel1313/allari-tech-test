using System;
using SimpleProductList.Models;

namespace SimpleProductList.Business.Sevices
{
	public interface IProductService
	{
        List<ProductModel> GetList(string orderByProperty = null);
    }
}

