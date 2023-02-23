using System;
using System.Collections.Generic;

namespace FinalProject.Models
{
    public partial class TProduct
    {
        public TProduct()
        {
            TOrderDetails = new HashSet<TOrderDetail>();
            TProductsTags = new HashSet<TProductsTag>();
            TShoppingCarts = new HashSet<TShoppingCart>();
        }

        public int FId { get; set; }
        public string FName { get; set; } = null!;
        public byte FPeriodId { get; set; }
        public decimal FCost { get; set; }
        public decimal FPrice { get; set; }
        public int FStocks { get; set; }
        public string FDescription { get; set; } = null!;
        public string FImagePath { get; set; } = null!;
        public byte FMinParticipants { get; set; }
        public byte FMaxParticipants { get; set; }
        public string FAssemblyPoint { get; set; } = null!;
        public DateTime FStartDate { get; set; }
        public DateTime FEndDate { get; set; }
        public int FProviderId { get; set; }
        public bool FRemoved { get; set; }
        public string? FRemark { get; set; }
        public DateTime FCreationDate { get; set; }
        public DateTime FLastUpdateDate { get; set; }

        public virtual TPeriod FPeriod { get; set; } = null!;
        public virtual TProvider FProvider { get; set; } = null!;
        public virtual ICollection<TOrderDetail> TOrderDetails { get; set; }
        public virtual ICollection<TProductsTag> TProductsTags { get; set; }
        public virtual ICollection<TShoppingCart> TShoppingCarts { get; set; }
    }
}
