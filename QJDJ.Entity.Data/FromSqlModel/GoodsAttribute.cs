namespace QJDJ.Entity.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GoodsAttribute")]
    public partial class GoodsAttribute
    {
        [Key]
        [Column(Order = 0)]
        public long gaId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long gaGoodsId { get; set; }

        [StringLength(50)]
        public string gaName { get; set; }

        public int? gaIndex { get; set; }

        public double? gaWeight { get; set; }

        public double? gaWeightJZ { get; set; }

        public double? gaWeightMin { get; set; }

        public double? gaWeightMax { get; set; }

        public double? gaPriceCGJ { get; set; }

        public double? gaPriceTJ { get; set; }

        public double? gaPriceVIP { get; set; }

        public double? gaPriceSCJ { get; set; }

        public double? gaPriceTGJ { get; set; }

        [StringLength(50)]
        public string gaPriceText { get; set; }

        public int? gaStock { get; set; }

        public int? gaWarnCount { get; set; }

        public int? gaUnit { get; set; }

        [StringLength(200)]
        public string gaRemark { get; set; }

        [StringLength(50)]
        public string gaBarcode { get; set; }

        public double? gaPriceCG { get; set; }

        [StringLength(50)]
        public string gaOrderAttr { get; set; }

        [StringLength(50)]
        public string gaOrderUnit { get; set; }

        public double? gaOrderWeight { get; set; }

        public double? gaOrderCount { get; set; }

        public double? gaOrderCountLoss { get; set; }
    }
}
