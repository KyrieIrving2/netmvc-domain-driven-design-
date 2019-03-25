namespace QJDJ.Entity.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OfflineOrderInfo")]
    public partial class OfflineOrderInfo
    {
        [Key]
        [Column(Order = 0)]
        public Guid ooiId { get; set; }

        [StringLength(50)]
        public string ooiUserKey { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ooiNumber { get; set; }

        [StringLength(50)]
        public string ooiRecUserName { get; set; }

        [StringLength(50)]
        public string ooiRecUserTel { get; set; }

        [StringLength(200)]
        public string ooiRecAddrDetail { get; set; }

        public long? oiRecAddrStationId { get; set; }

        [StringLength(200)]
        public string oiRecAddrStationText { get; set; }

        [StringLength(50)]
        public string ooiConfirmCode { get; set; }

        public DateTime? ooiDateTime { get; set; }

        public int? ooiGetWay { get; set; }

        public int? ooiPayWayId { get; set; }

        [StringLength(50)]
        public string ooiPayWayText { get; set; }

        public double? ooiFreight { get; set; }

        public double? ooiTotalAmount { get; set; }

        public double? ooiGoodsAmount { get; set; }

        public int? ooiGoodsCount { get; set; }

        public double? ooiPayAmount { get; set; }

        public DateTime? ooiPayDate { get; set; }

        public int? ooiPayState { get; set; }

        [StringLength(50)]
        public string ooiPaySerialNumber { get; set; }

        public int? ooiState { get; set; }

        public DateTime? ooiStateDate { get; set; }

        [StringLength(300)]
        public string ooiRemark { get; set; }

        public string oiPayBack { get; set; }

        public int? ooiIsCancel { get; set; }

        public long? ooiCancelId { get; set; }

        public DateTime? ooiCancelDate { get; set; }
    }
}
