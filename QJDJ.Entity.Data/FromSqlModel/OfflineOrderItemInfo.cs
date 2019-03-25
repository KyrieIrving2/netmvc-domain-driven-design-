namespace QJDJ.Entity.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OfflineOrderItemInfo")]
    public partial class OfflineOrderItemInfo
    {
        [Key]
        [Column(Order = 0)]
        public Guid ooiiId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ooiiOrderId { get; set; }

        [StringLength(50)]
        public string ooiiNumber { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ooiiGoodsId { get; set; }

        [StringLength(50)]
        public string ooiiGoodsName { get; set; }

        [StringLength(50)]
        public string ooiiGoodsImg { get; set; }

        public int? ooiiGoodsCount { get; set; }

        public double? ooiiGoodsPrice { get; set; }

        public DateTime? ooiiPayDate { get; set; }

        public int? ooiiPayState { get; set; }

        public int? ooiiState { get; set; }

        public DateTime? ooiiStateDate { get; set; }

        public int? ooiiIsCancel { get; set; }

        public long? ooiiCancelId { get; set; }

        public DateTime? ooiiCancelDate { get; set; }
    }
}
