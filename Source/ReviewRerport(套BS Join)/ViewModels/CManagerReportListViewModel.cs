using System.ComponentModel;

namespace ReviewRerport.ViewModels
{
	public class CManagerReportListViewModel
	{
		public int ReportID { get; set; }
		[DisplayName("商品名稱")]
		public string ProductName { get; set; }
		[DisplayName("廠商名稱")]
		public string ProductProvider { get; set; }
		[DisplayName("檢舉內容")]
		public string ReportContent { get; set; }
		[DisplayName("檢舉時間")]
		public DateTime CreateDateTime { get; set; }
	}
}
