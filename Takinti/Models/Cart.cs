using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Takinti.Models
{
    public class Cart
    {
        public Cart()
        {
            CreateDate = DateTime.Now;
            UpdateDate = DateTime.Now;
            CartItems = new HashSet<CartItem>();
        }

        public int  Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set;  }
        public int ProductCount { get { return CartItems.Sum(ci => ci.Quantity); } }
        public decimal TotalPrice { get { return CartItems.Sum(ci => ci.TotalPrice); } }



        public virtual ICollection<CartItem> CartItems { get; set; }







    }
}