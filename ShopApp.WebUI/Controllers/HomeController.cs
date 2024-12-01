using Microsoft.AspNetCore.Mvc;
using ShopApp.DataAccess.Abstract;
using ShopApp.WebUI.ViewModel;


namespace ShopApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
       private readonly IProductRepository _productRepository;
        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var ProductViewModel = new ProductViewModel
            {
                Products = _productRepository.GetAll()
            };
            return View(ProductViewModel);
        }

    }
}
