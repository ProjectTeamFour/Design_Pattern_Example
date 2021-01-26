using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModels;
using WebApplication1.Sever;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        private ProductServer _productserver;
        public ProductController() 
        {
            _productserver = new ProductServer();
        }

        // GET: Product
        public ActionResult Index()
        {

            var Result = _productserver.GetByFilter(100);
            var viewRes = Result.Select(x => new ProductViewModel() { Name = x.Name});
            return View(viewRes);
        }
    }
}