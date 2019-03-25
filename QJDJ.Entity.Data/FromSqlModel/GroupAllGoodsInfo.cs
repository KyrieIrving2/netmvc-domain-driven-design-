namespace QJDJ.Entity.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GroupAllGoodsInfo")]
    public partial class GroupAllGoodsInfo
    {
        [Key]
        [Column(Order = 0)]
        public Guid gagiKey { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long gagiId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string gagiName { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string gagiNumber { get; set; }

        [Key]
        [Column(Order = 4)]
        public double gagiPurchasePrice { get; set; }

        [Key]
        [Column(Order = 5)]
        public double gagiMarketPrice { get; set; }

        [Key]
        [Column(Order = 6)]
        public double gagiWebPrice { get; set; }

        [Key]
        [Column(Order = 7)]
        public double gagiAppPrice { get; set; }

        [StringLength(300)]
        public string gagiDescribe { get; set; }

        [StringLength(50)]
        public string gagiThumbImg1 { get; set; }

        [StringLength(50)]
        public string gagiThumbImg2 { get; set; }

        [StringLength(300)]
        public string gagiPicArray { get; set; }

        public int? gagiSalesVolume { get; set; }

        [StringLength(200)]
        public string gagiDetailUrl { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int gagiState { get; set; }

        [StringLength(50)]
        public string gagiExternalNumber { get; set; }

        public double? gagiFreight { get; set; }

        [StringLength(50)]
        public string gagiSkuUnit { get; set; }

        [StringLength(50)]
        public string gagiAttribute { get; set; }

        [StringLength(50)]
        public string gagiSourceArea { get; set; }

        public double? gagiHeadIncomePercent { get; set; }
    }
}
