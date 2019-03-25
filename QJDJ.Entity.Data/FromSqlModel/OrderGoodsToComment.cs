namespace QJDJ.Entity.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderGoodsToComment")]
    public partial class OrderGoodsToComment
    {
        [Key]
        [Column(Order = 0)]
        public Guid gotcId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long gotcUserId { get; set; }

        [StringLength(50)]
        public string gotcOrderNumber { get; set; }

        public DateTime? gotcOrderDateTime { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long gotcGoodsId { get; set; }

        [StringLength(50)]
        public string gotcGoodsName { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long gotcGoodsAttrId { get; set; }

        [StringLength(50)]
        public string gotcGoodsAttrName { get; set; }

        [StringLength(50)]
        public string gotcGoodsThumbImg1 { get; set; }

        [StringLength(50)]
        public string gotcGoodsThumbImg2 { get; set; }

        public int? gotcState { get; set; }

        [StringLength(200)]
        public string gotcRemark { get; set; }
    }
}
