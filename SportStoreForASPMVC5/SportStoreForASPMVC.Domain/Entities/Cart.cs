using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportStoreForASPMVC.Domain.Entities
{
    public class Cart
    {
        public List<QuartLine> CartLineCollection = new List<QuartLine>();
        
        public void AddItem(Product prod, int Quantity)
        {
            QuartLine cartline = CartLineCollection
                .Where(e => e.Productes.ProductID == prod.ProductID)
                .FirstOrDefault();

            if (cartline == null)
            {
                CartLineCollection.Add(new QuartLine { Productes = prod, Quantity = Quantity });
            }
            else
                cartline.Quantity += Quantity;
        }
        public void Remouve(Product product)
        {
            CartLineCollection.RemoveAll(l => l.Productes.ProductID == product.ProductID);
        }
        public void Clear()
        {
            CartLineCollection.Clear();
        }
        public decimal CalculateValue()
        {
            return CartLineCollection.Sum(l => l.Productes.Price * l.Quantity);
        }

        public IEnumerable<QuartLine> Lines
        {
            get { return CartLineCollection; }
        }
    }
}
