using System;
using System.Collections.Generic;

namespace FinalProject.Models
{
    public partial class TGender
    {
        public TGender()
        {
            TCustomers = new HashSet<TCustomer>();
        }

        public byte FId { get; set; }
        public string FDescription { get; set; } = null!;

        public virtual ICollection<TCustomer> TCustomers { get; set; }
    }
}
