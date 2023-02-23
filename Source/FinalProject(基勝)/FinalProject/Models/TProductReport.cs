using System;
using System.Collections.Generic;

namespace FinalProject.Models
{
    public partial class TProductReport
    {
        public int FId { get; set; }
        public int FOrderDetailId { get; set; }
        public string FReportContent { get; set; } = null!;
        public DateTime FCreationDate { get; set; }

        public virtual TOrderDetail FOrderDetail { get; set; } = null!;
    }
}
