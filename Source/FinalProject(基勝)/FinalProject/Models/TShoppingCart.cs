using System;
using System.Collections.Generic;

namespace FinalProject.Models
{
    public partial class TShoppingCart
    {
        public int FSid { get; set; }
        public int FCustomerId { get; set; }
        public int FProductId { get; set; }
        public int FPurchaseQuantity { get; set; }
        public DateTime FAddDate { get; set; }

        public virtual TCustomer FCustomer { get; set; } = null!;
        public virtual TProduct FProduct { get; set; } = null!;
    }
}
