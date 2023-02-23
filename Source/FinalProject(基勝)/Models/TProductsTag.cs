using System;
using System.Collections.Generic;

namespace FinalProject.Models
{
    public partial class TProductsTag
    {
        public int FSid { get; set; }
        public int FProductId { get; set; }
        public int FTagId { get; set; }

        public virtual TProduct FProduct { get; set; } = null!;
        public virtual TTag FTag { get; set; } = null!;
    }
}
