using System;
using System.Collections.Generic;

namespace FinalProject.Models
{
    public partial class TCoupon
    {
        public TCoupon()
        {
            TCustomerOrderSheets = new HashSet<TCustomerOrderSheet>();
        }

        public int FSid { get; set; }
        public string FCode { get; set; } = null!;
        public DateTime FStartDate { get; set; }
        public DateTime FEndDate { get; set; }
        public byte FRatio { get; set; }
        public int FAvailableTimes { get; set; }
        public int FUsedTimes { get; set; }

        public virtual ICollection<TCustomerOrderSheet> TCustomerOrderSheets { get; set; }
    }
}
