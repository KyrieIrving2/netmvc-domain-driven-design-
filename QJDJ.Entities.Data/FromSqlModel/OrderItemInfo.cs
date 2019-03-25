namespace QJDJ.Entities.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderItemInfo")]
    public partial class OrderItemInfo
    {
        [Key]
        public Guid oiiId { get; set; }

        public Guid oiiOrderId { get; set; }

        [StringLength(50)]
        public string oiiNumber { get; set; }

        [StringLength(50)]
        public string oiiBatchNumber { get; set; }

        public long oiiGoodsId { get; set; }

        [StringLength(50)]
        public string oiiGoodsName { get; set; }

        public long? oiiGoodsAttrId { get; set; }

        [StringLength(50)]
        public string oiiGoodsAttrName { get; set; }

        public double? oiiGoodsPrice { get; set; }

        public double? oiiGoodsPriceCGJ { get; set; }

        public double? oiiGoodsPriceTJ { get; set; }

        public double? oiiGoodsPriceVIP { get; set; }

        public double? oiiGoodsPriceSCJ { get; set; }

        public double? oiiGoodsPriceTGJ { get; set; }

        [StringLength(50)]
        public string oiiGoodsPriceText { get; set; }

        public int? oiiGoodsCount { get; set; }

        public double? oiiGoodsWeight { get; set; }

        public double? oiiGoodsWeightJZ { get; set; }

        public double? oiiGoodsWeightMin { get; set; }

        public double? oiiGoodsWeightMax { get; set; }

        [StringLength(50)]
        public string oiiGoodsThumbImg1 { get; set; }

        [StringLength(50)]
        public string oiiGoodsThumbImg2 { get; set; }

        [StringLength(50)]
        public string oiiGoodsBarcode { get; set; }

        public int? oiiState { get; set; }

        public int? oiiPayState { get; set; }

        public DateTime? oiiPayDate { get; set; }

        public DateTime? oiiStateDate { get; set; }

        public int? oiiIsCancel { get; set; }

        public long? oiiCancelId { get; set; }

        public DateTime? oiiCancelDate { get; set; }

        public long? oiiGoodsShopId { get; set; }

        public virtual OrderInfo OrderInfo { get; set; }
    }
}
