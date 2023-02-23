using System.ComponentModel;

namespace FinalProject.ViewModels
{
    public class CCouponViewModel
    {
        [DisplayName("系統編號")]
        public int FSid { get; set; }
        [DisplayName("優惠券代碼")]
        public string FCode { get; set; }
        [DisplayName("使用開始時間")]
        public DateTime FStartDate { get; set; }
        [DisplayName("使用截止時間")]
        public DateTime FEndDate { get; set; }
        [DisplayName("折扣幅度（%）")]
        public byte FRatio { get; set; }
        [DisplayName("可使用次數")]
        public int FAvailableTimes { get; set; }
        [DisplayName("已使用次數")]
        public int FUsedTimes { get; set; }
    }
}
