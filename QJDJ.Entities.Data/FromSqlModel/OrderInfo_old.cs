namespace QJDJ.Entities.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderInfo_old
    {
        [Key]
        public long oiId { get; set; }

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
    }
}
