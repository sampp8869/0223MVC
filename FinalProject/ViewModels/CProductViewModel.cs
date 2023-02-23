using FinalProject.Models;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System.ComponentModel;

namespace FinalProject.ViewModels
{
    public class CProductViewModel
    {
        private TProduct _product;
        public TProduct product
        {
            get { return _product; }
            set { _product = value; }
        }
        public CProductViewModel()
        {
            _product = new TProduct();
        }
        [DisplayName("商品編號")]
        public int FId
        {
            get { return _product.FId; }
            set { _product.FId = value; }
        }
        [DisplayName("名稱")]
        public string FName
        {
            get { return _product.FName; }
            set { _product.FName = value; }
        }
        [DisplayName("時段編號")]
        public byte FPeriodId
        {
            get { return _product.FPeriodId;}
            set { _product.FPeriodId = value; }
        }
        [DisplayName("時段")]
        public string FPeriod{get; set;}
        [DisplayName("成本")]
        public decimal FCost
        {
            get { return _product.FCost; }
            set { _product.FCost = value; }
        }
        [DisplayName("售價")]
        public decimal FPrice
        {
            get { return _product.FPrice; }
            set { _product.FPrice = value; }
        }
        [DisplayName("庫存")]
        public int FStocks
        {
            get { return _product.FStocks; }
            set { _product.FStocks = value; }
        }
        [DisplayName("商品描述")]
        public string FDescription
        {
            get { return _product.FDescription; }
            set { _product.FDescription = value;}
        }
        [DisplayName("圖片")]
        public string FImagePath
        {
            get { return _product.FImagePath; }
            set { _product.FImagePath = value; }
        }
        [DisplayName("最少參加人數")]
        public byte FMinParticipants
        {
            get { return _product.FMinParticipants; }
            set { _product.FMinParticipants = value; }
        }
        [DisplayName("最多參加人數")]
        public byte FMaxParticipants
        {
            get { return _product.FMaxParticipants; }
            set { _product.FMaxParticipants = value; }
        }
        [DisplayName("集合地點")]
        public string FAssemblyPoint
        {
            get { return _product.FAssemblyPoint;}
            set { _product.FAssemblyPoint = value;}
        }
        [DisplayName("販售開始時間")]
        public DateTime FStartDate
        {
            get { return _product.FStartDate; }
            set { _product.FStartDate = value;}
        }
        [DisplayName("販售截止時間")]
        public DateTime FEndDate
        {
            get { return _product.FEndDate; }
            set { _product.FEndDate = value; }
        }
        [DisplayName("供應商編號")]
        public int FProviderId
        {
            get { return _product.FProviderId; }
            set { _product.FProviderId = value; }
        }
        [DisplayName("供應商")]
        public string FProvider { get; set; }
        [DisplayName("備註")]
        public string? FRemark
        {
            get { return _product.FRemark; }
            set { _product.FRemark = value;}
        }
        [DisplayName("商品建立時間")]
        public DateTime FCreationDate
        {
            get { return _product.FCreationDate; }
            set { _product.FCreationDate = value; }
        }
        [DisplayName("商品更新時間")]
        public DateTime FLastUpdateDate
        {
            get {return _product.FLastUpdateDate; }
            set {_product.FLastUpdateDate = value; }
        }
        public IFormFile photo { get; set; }
    }
}
