using System;
using System.Collections.Generic;

namespace FinalProject.Models
{
    public partial class TCustomer
    {
        public TCustomer()
        {
            TCustomerOrderSheets = new HashSet<TCustomerOrderSheet>();
            TShoppingCarts = new HashSet<TShoppingCart>();
        }

        public int FId { get; set; }
        public string FLastName { get; set; } = null!;
        public string FFirstName { get; set; } = null!;
        public byte FGender { get; set; }
        public string FTel { get; set; } = null!;
        public string FMobile { get; set; } = null!;
        public string FEmail { get; set; } = null!;
        public string FPassword { get; set; } = null!;
        public DateTime FBirthDate { get; set; }
        public int FPoint { get; set; }
        public bool FBlackList { get; set; }
        public string? FRemark { get; set; }
        public DateTime FCreationDate { get; set; }
        public DateTime FLastUpdateDate { get; set; }

        public virtual TGender FGenderNavigation { get; set; } = null!;
        public virtual ICollection<TCustomerOrderSheet> TCustomerOrderSheets { get; set; }
        public virtual ICollection<TShoppingCart> TShoppingCarts { get; set; }
    }
}
