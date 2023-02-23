using System.ComponentModel;

namespace FinalProject.ViewModels
{
    public class CProviderViewModel
    {
        [DisplayName("供應商編號")]
        public int FId { get; set; }
        [DisplayName("公司名稱")]
        public string FCompanyName { get; set; }
        [DisplayName("密碼")]
        public string FPassword { get; set; }
        [DisplayName("統一編號")]
        public string FTaxId { get; set; }
        [DisplayName("傳真號碼")]
        public string FFax { get; set; }
        [DisplayName("公司所有人")]
        public string FOwnerName { get; set; }
        [DisplayName("所有人電話")]
        public string FOwnerTel { get; set; }
        [DisplayName("所有人手機")]
        public string FOwnerMobile { get; set; }
        [DisplayName("所有人信箱")]
        public string FOwnerEmail { get; set; }
        [DisplayName("公司聯絡人")]
        public string FContactName { get; set; }
        [DisplayName("聯絡人電話")]
        public string FContactTel { get; set; }
        [DisplayName("聯絡人手機")]
        public string FContactMobile { get; set; }
        [DisplayName("聯絡人信箱")]
        public string FContactEmail { get; set; }
        [DisplayName("公司地址")]
        public string FAddress { get; set; }
        [DisplayName("銀行名稱")]
        public string FBankName { get; set; }
        [DisplayName("銀行分行名稱")]
        public string FBankDivisionName { get; set; }
        [DisplayName("銀行帳號")]
        public string FBankAccountNumber { get; set; }
        [DisplayName("銀行帳號戶名")]
        public string FBankAccountName { get; set; }
        [DisplayName("黑名單")]
        public bool FBlackList { get; set; }
        [DisplayName("備註")]
        public string? FRemark { get; set; }
        [DisplayName("資料建立時間")]
        public DateTime FCreationDate { get; set; }
        [DisplayName("資料最近更新時間")]
        public DateTime FLastUpdateDate { get; set; }
    }
}
