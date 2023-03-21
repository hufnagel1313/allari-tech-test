using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SimpleProductList.Business.Sevices;
using SimpleProductList.Models;

namespace SimpleProductList.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IProductService _productService;

    public HomeController(ILogger<HomeController> logger, IProductService productService)
    {
        _logger = logger;
        _productService = productService;
    }

    public IActionResult Index()
    {
        var productList = _productService.GetList();
        return View(productList);
    }

    public PartialViewResult GetProduts(string orderByProperty)
    {
        List<ProductModel> productList = _productService.GetList(orderByProperty);
        return PartialView("_ProductListPartial", productList);
    }
}

