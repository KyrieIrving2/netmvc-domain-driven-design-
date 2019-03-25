namespace QJDJ.Entities.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MpGroupInfo")]
    public partial class MpGroupInfo
    {
        [Key]
        [Column(Order = 0)]
        public Guid giId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string giName { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime giBeginTime { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime giEndTime { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int giGroupValue { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int giTotalCount { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int giSysCount { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int giState { get; set; }

        [StringLength(50)]
        public string giGoodsId { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(50)]
        public string giGoodsName { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(50)]
        public string giGoodsAttr { get; set; }

        [Key]
        [Column(Order = 10)]
        public double giPurchasePrice { get; set; }

        [Key]
        [Column(Order = 11)]
        public double giMarketPrice { get; set; }

        [Key]
        [Column(Order = 12)]
        public double giPrice { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(50)]
        public string giCity { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(200)]
        public string giRegion { get; set; }

        [StringLength(300)]
        public string giGoodsBanner { get; set; }

        [StringLength(50)]
        public string giGoodsSlogan { get; set; }

        [StringLength(300)]
        public string giGoodsDetail { get; set; }

        [StringLength(50)]
        public string giGoodsSupply { get; set; }

        [StringLength(300)]
        public string giDescribe { get; set; }

        [StringLength(300)]
        public string giDistribution { get; set; }

        [StringLength(50)]
        public string giServiceTel { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(50)]
        public string giFillUser { get; set; }

        public DateTime? giFillDate { get; set; }

        [StringLength(200)]
        public string giGroupTitle { get; set; }

        [StringLength(200)]
        public string giShareTitle { get; set; }

        [StringLength(200)]
        public string giShareDescribe { get; set; }

        [StringLength(200)]
        public string giShareImg { get; set; }

        [StringLength(200)]
        public string giGoodsThumb { get; set; }

        [StringLength(300)]
        public string giRemark { get; set; }

        public int? giIsCancel { get; set; }

        [StringLength(50)]
        public string giCancelId { get; set; }

        public DateTime? giCancelDate { get; set; }
    }
}
