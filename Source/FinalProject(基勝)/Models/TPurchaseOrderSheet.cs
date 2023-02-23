using System;
using System.Collections.Generic;

namespace FinalProject.Models
{
    public partial class TPurchaseOrderSheet
    {
        public int FId { get; set; }
        public int FOrderDetailId { get; set; }
        public DateTime FCreationDate { get; set; }

        public virtual TOrderDetail FOrderDetail { get; set; } = null!;
    }
}
