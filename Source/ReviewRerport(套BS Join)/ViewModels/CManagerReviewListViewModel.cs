using System.ComponentModel;

namespace ReviewRerport.ViewModels
{
    public class CManagerReviewListViewModel
    {
        public int ReviewID { get; set; }
        [DisplayName("商品名稱")]
        public string ProductName { get; set; }
        [DisplayName("廠商名稱")]
        public string ProductProvider { get; set; }

        [DisplayName("評論分數")]
        public int ReviewScore { get; set; }

        [DisplayName("評論內容")]
        public string ReviewContent { get; set; }

        [DisplayName("評論時間")]
        public DateTime CreateDateTime { get; set; }
    }
}
