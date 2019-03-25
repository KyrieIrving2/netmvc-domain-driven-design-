namespace QJDJ.Entity.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GoodsPriceZhongchu")]
    public partial class GoodsPriceZhongchu
    {
        [Key]
        [Column(Order = 0)]
        public Guid gpId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string gpRecordId { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime gpBeginTime { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime gpEndTime { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string gpGoodsNumber { get; set; }

        [Key]
        [Column(Order = 5)]
        public double gpPrice1 { get; set; }

        [Key]
        [Column(Order = 6)]
        public double gpPrice2 { get; set; }

        [Key]
        [Column(Order = 7)]
        public double gpPrice3 { get; set; }

        [Key]
        [Column(Order = 8)]
        public double gpPrice4 { get; set; }

        public DateTime? gpFillDate { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int gpState { get; set; }

        [StringLength(300)]
        public string gpRemark { get; set; }

        public DateTime? gpCancelDate { get; set; }
    }
}
