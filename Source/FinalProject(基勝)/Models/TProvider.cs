using System;
using System.Collections.Generic;

namespace FinalProject.Models
{
    public partial class TProvider
    {
        public TProvider()
        {
            TProducts = new HashSet<TProduct>();
        }

        public int FId { get; set; }
        public string FCompanyName { get; set; } = null!;
        public string FPassword { get; set; } = null!;
        public string FTaxId { get; set; } = null!;
        public string? FFax { get; set; }
        public string FOwnerName { get; set; } = null!;
        public string FOwnerTel { get; set; } = null!;
        public string FOwnerMobile { get; set; } = null!;
        public string FOwnerEmail { get; set; } = null!;
        public string FContactName { get; set; } = null!;
        public string FContactTel { get; set; } = null!;
        public string FContactMobile { get; set; } = null!;
        public string FContactEmail { get; set; } = null!;
        public string FAddress { get; set; } = null!;
        public string FBankName { get; set; } = null!;
        public string FBankDivisionName { get; set; } = null!;
        public string FBankAccountNumber { get; set; } = null!;
        public string FBankAccountName { get; set; } = null!;
        public bool FBlackList { get; set; }
        public string? FRemark { get; set; }
        public DateTime FCreationDate { get; set; }
        public DateTime FLastUpdateDate { get; set; }

        public virtual ICollection<TProduct> TProducts { get; set; }
    }
}
