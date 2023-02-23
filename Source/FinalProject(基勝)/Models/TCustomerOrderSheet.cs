using System;
using System.Collections.Generic;

namespace FinalProject.Models
{
    public partial class TCustomerOrderSheet
    {
        public TCustomerOrderSheet()
        {
            TOrderDetails = new HashSet<TOrderDetail>();
        }

        public int FId { get; set; }
        public int FCustomerId { get; set; }
        public string? FCouponCode { get; set; }
        public DateTime FCreationDate { get; set; }
        public DateTime? FCheckedDate { get; set; }

        public virtual TCoupon? FCouponCodeNavigation { get; set; }
        public virtual TCustomer FCustomer { get; set; } = null!;
        public virtual ICollection<TOrderDetail> TOrderDetails { get; set; }
    }
}
