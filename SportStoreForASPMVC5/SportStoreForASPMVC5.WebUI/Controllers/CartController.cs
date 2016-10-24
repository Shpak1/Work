using SportStoreForASPMVC.Domain.Abstract;
using SportStoreForASPMVC.Domain.Entities;
using SportStoreForASPMVC5.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportStoreForASPMVC5.WebUI.Controllers
{
    public class CartController : Controller
    {
        private IProductRepository Prodrepo;

        public CartController(IProductRepository prodrepo)
        {
            this.Prodrepo = prodrepo;
        }

        public RedirectToRouteResult AddCart(int ProductId, string ReturnUrl)
        {
            Product product = Prodrepo.Products
                .FirstOrDefault(l => l.ProductID == ProductId);

            if (product != null)
            {
                GetCart().AddItem(product, 5);
            }
            return RedirectToAction("Index", new { ReturnUrl });
        }

        public RedirectToRouteResult RemouveFronCart(int ProductId, string RetutnUrl)
        {
            Product product = Prodrepo.Products
                .FirstOrDefault(l => l.ProductID == ProductId);

            if (product != null)
            {
                GetCart().Remouve(product);
            }
            return RedirectToAction("Index", new { RetutnUrl });
        }

        private Cart GetCart()
        {
            Cart cart = (Cart)Session["Cart"];
            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        }

        public ViewResult Index(string ReturnUrl)
        {
            return View(new CartIndexViewModel
            {
                cart = GetCart(),
                ResultURL = ReturnUrl
            }
                );
        }
    }
}