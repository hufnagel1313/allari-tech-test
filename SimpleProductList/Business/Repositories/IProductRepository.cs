using System;
using SimpleProductList.Models;

namespace SimpleProductList.Business.Repositories
{
    public interface IProductRepository
    {
        List<ProductModel> GetList(string orderByProperty = null);
    }
}

