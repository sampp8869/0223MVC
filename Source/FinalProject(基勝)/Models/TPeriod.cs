using System;
using System.Collections.Generic;

namespace FinalProject.Models
{
    public partial class TPeriod
    {
        public TPeriod()
        {
            TProducts = new HashSet<TProduct>();
        }

        public byte FId { get; set; }
        public string FDescription { get; set; } = null!;

        public virtual ICollection<TProduct> TProducts { get; set; }
    }
}
