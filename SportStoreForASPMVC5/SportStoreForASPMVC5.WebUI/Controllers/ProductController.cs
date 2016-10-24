using SportStoreForASPMVC.Domain.Abstract;
using SportStoreForASPMVC5.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportStoreForASPMVC5.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository productrepository;
        public int Pageinfo = 4;
        public ProductController(IProductRepository producrrepository)
        {
            this.productrepository = producrrepository;
        }

        // GET: Product
        public ViewResult List(string category,int page = 1)
        {
            ProductsListViewModel model = new ProductsListViewModel
            {
                Products = productrepository.Products
                .Where(p => category == null || p.Category == category)
                .OrderBy(p => p.ProductID)
                .Skip((page - 1) * Pageinfo)
                .Take(Pageinfo),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = Pageinfo,
                    TotalIteams = category == null ?
                    productrepository.Products.Count() :
                    productrepository.Products.Where(e => e.Category == category).Count()

                },
                CurrentCategory = category
            };
            return View(model);

        }
    }
}