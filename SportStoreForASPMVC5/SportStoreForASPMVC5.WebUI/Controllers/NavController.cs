using SportStoreForASPMVC.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportStoreForASPMVC5.WebUI.Controllers
{
    public class NavController : Controller
    {
        private IProductRepository rep;

        public NavController(IProductRepository rep)
        {
            this.rep = rep;
        }

        public PartialViewResult Menu(string category = null)
        {
            ViewBag.SelectedCategory = category;
            IEnumerable<string> categories = rep.Products
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x);
            return PartialView(categories);
        }
    }
}