using ContosoCrafts.WebSite.Services;
using DotNetTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNetTest.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileProductService ProductService;
        public IEnumerable<Product> Products { get; private set; }

   

        public IndexModel(ILogger<IndexModel> logger,
            JsonFileProductService productServicce)
        {
            _logger = logger;
            ProductService = productServicce;
        }

        public void OnGet()
        {
            Products = ProductService.GetProducts();
        }
    }
}