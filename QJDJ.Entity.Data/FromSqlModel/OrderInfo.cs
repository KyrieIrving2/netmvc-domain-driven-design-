namespace QJDJ.Entity.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderInfo")]
    public partial class OrderInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderInfo()
        {
            OrderItemInfo = new HashSet<OrderItemInfo>();
        }

        [Key]
        public Guid oiId { get; set; }

        public long? oiStationId { get; set; }

        public long oiUserId { get; set; }

        public int? oiType { get; set; }

        [Required]
        [StringLength(50)]
        public string oiNumber { get; set; }

        [StringLength(50)]
        public string oiPaySerialNumber { get; set; }

        public long? oiAddressId { get; set; }

        [StringLength(50)]
        public string oiRecUserTel { get; set; }

        [StringLength(50)]
        public string oiRecUserName { get; set; }

        [StringLength(200)]
        public string oiRecAddrStationText { get; set; }

        [StringLength(200)]
        public string oiRecAddrDetail { get; set; }

        public int? oiGetWay { get; set; }

        public int? oiRecDateTime { get; set; }

        public DateTime? oiDateTime { get; set; }

        public int? oiIsUseMoney { get; set; }

        public double? oiMoneyAmount { get; set; }

        public int? oiIsUseIntegral { get; set; }

        public int? oiIntegralCount { get; set; }

        public double? oiIntegralAmount { get; set; }

        public int? oiIsUseCoupons { get; set; }

        [StringLength(50)]
        public string oiUseCouponsNum { get; set; }

        public double? oiUseCouponsAmount { get; set; }

        public int? oiPayWayId { get; set; }

        [StringLength(50)]
        public string oiPayWayText { get; set; }

        public double? oiFreight { get; set; }

        public double? oiGoodsTotalAmount { get; set; }

        public double? oiPayAmount { get; set; }

        public double? oiPayAmountMin { get; set; }

        public double? oiPayAmountMax { get; set; }

        public DateTime? oiPayDate { get; set; }

        public int? oiPayState { get; set; }

        public int? oiIsNeedInvoice { get; set; }

        public int? oiInvoiceType { get; set; }

        [StringLength(50)]
        public string oiInvoiceTitle { get; set; }

        public int? oiInvoiceContent { get; set; }

        public int? oiState { get; set; }

        public DateTime? oiStateDate { get; set; }

        [StringLength(300)]
        public string oiRemark { get; set; }

        public int? oiIsCancel { get; set; }

        public long? oiCancelId { get; set; }

        public DateTime? oiCancelDate { get; set; }

        public string oiPayBack { get; set; }

        public long? oiBuildId { get; set; }

        [StringLength(50)]
        public string oiBuildText { get; set; }

        [StringLength(50)]
        public string oiRecDateTimeText { get; set; }

        [StringLength(50)]
        public string oiConfirmCode { get; set; }

        [StringLength(50)]
        public string oiSupplierId { get; set; }

        public double? oiConfirmAmount { get; set; }

        [StringLength(300)]
        public string oiConfirmRemark { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItemInfo> OrderItemInfo { get; set; }
    }
}
