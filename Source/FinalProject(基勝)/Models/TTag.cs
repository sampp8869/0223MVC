using System;
using System.Collections.Generic;

namespace FinalProject.Models
{
    public partial class TTag
    {
        public TTag()
        {
            TProductsTags = new HashSet<TProductsTag>();
        }

        public int FId { get; set; }
        public string FDescription { get; set; } = null!;

        public virtual ICollection<TProductsTag> TProductsTags { get; set; }
    }
}
