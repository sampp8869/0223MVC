using System;
using System.Collections.Generic;

namespace FinalProject.Models
{
    public partial class TOrderDetail
    {
        public TOrderDetail()
        {
            TProductReports = new HashSet<TProductReport>();
            TProductReviews = new HashSet<TProductReview>();
            TPurchaseOrderSheets = new HashSet<TPurchaseOrderSheet>();
        }

        public int FId { get; set; }
        public int FCustomerOrderSheetId { get; set; }
        public int FProductId { get; set; }
        public int FPurchaseQuantity { get; set; }

        public virtual TCustomerOrderSheet FCustomerOrderSheet { get; set; } = null!;
        public virtual TProduct FProduct { get; set; } = null!;
        public virtual ICollection<TProductReport> TProductReports { get; set; }
        public virtual ICollection<TProductReview> TProductReviews { get; set; }
        public virtual ICollection<TPurchaseOrderSheet> TPurchaseOrderSheets { get; set; }
    }
}
