using SportStoreForASPMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportStoreForASPMVC5.WebUI.Models
{
    public class CartIndeViewModel
    {
        public Cart cart { get; set; }
        public string ResultURL { get; set; }
    }
}