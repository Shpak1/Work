using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportStoreForASPMVC.Domain.Entities
{
    public class QuartLine
    {
        public Product Productes { get; set; }
        public int Quantity { get; set; }
    }
}
