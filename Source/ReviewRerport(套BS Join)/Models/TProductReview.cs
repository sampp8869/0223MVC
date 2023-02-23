using System;
using System.Collections.Generic;

namespace ReviewRerport.Models
{
    public partial class TProductReview
    {
        public int FId { get; set; }
        public int FOrderDetailId { get; set; }
        public string FReviewContent { get; set; } = null!;
        public byte FScore { get; set; }
        public DateTime FCreationDate { get; set; }

        public virtual TOrderDetail FOrderDetail { get; set; } = null!;
    }
}
