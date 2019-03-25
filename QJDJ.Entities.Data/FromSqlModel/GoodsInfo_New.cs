namespace QJDJ.Entities.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GoodsInfo_New
    {
        [Key]
        [Column(Order = 0)]
        public long gId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long gStationId { get; set; }

        public long? gSupplierId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string gNumber { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string gName { get; set; }

        [StringLength(50)]
        public string gThumbImg1 { get; set; }

        [StringLength(50)]
        public string gThumbImg2 { get; set; }

        [StringLength(500)]
        public string gPicArray { get; set; }

        [StringLength(50)]
        public string gTagText { get; set; }

        public int? gTagValue1 { get; set; }

        public int? gTagValue2 { get; set; }

        public int? gTagValue3 { get; set; }

        public int? gTagValue4 { get; set; }

        public int? gTagValue5 { get; set; }

        public int? gTagValue6 { get; set; }

        public int? gTagValue7 { get; set; }

        public int? gTagValue8 { get; set; }

        public int? gTagValue9 { get; set; }

        [StringLength(50)]
        public string gConentSummary { get; set; }

        [Column(TypeName = "ntext")]
        public string gContentDetail { get; set; }

        [StringLength(50)]
        public string gSlogan { get; set; }

        [StringLength(200)]
        public string gReminder { get; set; }

        [StringLength(200)]
        public string gDistribution { get; set; }

        public int? gSalesVolume { get; set; }

        [StringLength(50)]
        public string gBrand { get; set; }

        [StringLength(50)]
        public string gSourceArea { get; set; }

        [StringLength(50)]
        public string gStoreMode { get; set; }

        [StringLength(50)]
        public string gServiceMode { get; set; }

        [StringLength(50)]
        public string gKeys { get; set; }

        [StringLength(50)]
        public string gLabel { get; set; }

        public double? gDiscount { get; set; }

        public int? gWarnCount { get; set; }

        public int? gSafeDate { get; set; }

        public DateTime? gShangjiaDate { get; set; }

        public DateTime? gXiajiaDate { get; set; }

        public DateTime? gAddDate { get; set; }

        public int? gState { get; set; }

        [StringLength(200)]
        public string gRemark { get; set; }

        public long? gFillerId { get; set; }

        public DateTime? gFillDate { get; set; }

        public int? gIsCancel { get; set; }

        public long? gCancelId { get; set; }

        public DateTime? gCancelDate { get; set; }

        [StringLength(100)]
        public string gContentDetailUrl { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string gShortPinyin { get; set; }

        [StringLength(50)]
        public string gStorage { get; set; }

        [StringLength(50)]
        public string gSeason { get; set; }

        public long? gShopId { get; set; }

        public int? gDaySalesAverage { get; set; }

        [StringLength(50)]
        public string gExternalNumber { get; set; }
    }
}
