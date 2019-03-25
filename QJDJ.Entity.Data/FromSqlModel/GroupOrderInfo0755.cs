namespace QJDJ.Entity.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GroupOrderInfo0755
    {
        [Key]
        [Column(Order = 0)]
        public Guid goiId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long goiUserId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string goiNumber { get; set; }

        [StringLength(50)]
        public string goiCarNum { get; set; }

        [StringLength(50)]
        public string goiRecUserTel { get; set; }

        [StringLength(50)]
        public string goiRecUserName { get; set; }

        [StringLength(200)]
        public string oiRecAddrStationText { get; set; }

        [StringLength(200)]
        public string goiRecAddrDetail { get; set; }

        public long? goiBuildId { get; set; }

        [StringLength(50)]
        public string goiBuildText { get; set; }

        [StringLength(50)]
        public string goiConfirmCode { get; set; }

        public int? goiGetWay { get; set; }

        public int? goiPayWayId { get; set; }

        [StringLength(50)]
        public string goiPayWayText { get; set; }

        public double? goiFreight { get; set; }

        public double? goiGoodsTotalAmount { get; set; }

        public double? goiPayAmount { get; set; }

        public DateTime? goiPayDate { get; set; }

        public int? goiPayState { get; set; }

        public int? goiState { get; set; }

        public DateTime? goiStateDate { get; set; }

        [StringLength(300)]
        public string goiRemark { get; set; }

        [StringLength(50)]
        public string goiPaySerialNumber { get; set; }

        public string oiPayBack { get; set; }

        public int? goiIsCancel { get; set; }

        public long? goiCancelId { get; set; }

        public DateTime? goiCancelDate { get; set; }

        public long? goiGoodsId { get; set; }

        public int? goiGoodsCount { get; set; }

        [StringLength(50)]
        public string goiGoodsName { get; set; }

        [StringLength(50)]
        public string goiGoodsSkuUnit { get; set; }

        [StringLength(50)]
        public string goiGoodsAttribute { get; set; }

        public int? goiOrderType { get; set; }

        [StringLength(50)]
        public string goiRegionNum { get; set; }

        public double? goiGoodsPrice { get; set; }

        public DateTime? goiDateTime { get; set; }

        [StringLength(50)]
        public string goiUserKey { get; set; }

        [StringLength(50)]
        public string goiGroupId { get; set; }
    }
}
