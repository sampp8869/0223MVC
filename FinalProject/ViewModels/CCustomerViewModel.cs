using System.ComponentModel;

namespace FinalProject.ViewModels
{
    public class CCustomerViewModel
    {
        [DisplayName("會員編號")]
        public int FCustomerId { get; set; }
        [DisplayName("姓氏")]
        public string FLastName { get; set; }
        [DisplayName("名字")]
        public string FFirstName { get; set; }
        [DisplayName("性別")]
        public string FGender { get; set; }
        [DisplayName("性別編號")]
        public byte FGenderId { get; set; }
        [DisplayName("電話號碼")]
        public string FTel { get; set; }
        [DisplayName("手機號碼")]
        public string FMobile { get; set; }
        [DisplayName("電子信箱")]
        public string FEmail { get; set;}
        [DisplayName("密碼")]
        public string FPassword { get; set; }
        [DisplayName("生日")]
        public DateTime FBirthDate { get; set; }
        [DisplayName("點數")]
        public int FPoint { get; set; }
        [DisplayName("黑名單")]
        public bool FBlackList { get; set; }
        [DisplayName("備註")]
        public string? FRemark { get; set; }
        [DisplayName("資料建立日期")]
        public DateTime FCreationDate { get; set; }
        [DisplayName("資料更新日期")]

        public DateTime FLastUpdateDate { get; set; }
    }
}
