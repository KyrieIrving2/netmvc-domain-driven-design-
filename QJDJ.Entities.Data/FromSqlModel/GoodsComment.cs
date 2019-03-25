namespace QJDJ.Entities.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GoodsComment")]
    public partial class GoodsComment
    {
        [Key]
        [Column(Order = 0)]
        public Guid gcId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long gcGoodsId { get; set; }

        [StringLength(50)]
        public string gcOrderNumber { get; set; }

        public int? gcLevel { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long gcUserId { get; set; }

        public DateTime? gcTime { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(500)]
        public string gcContent { get; set; }

        [StringLength(300)]
        public string gcImage { get; set; }

        public int? gcCheck { get; set; }

        [StringLength(200)]
        public string gcRemark { get; set; }

        public int? gcIsCancel { get; set; }

        public long? gcCancelId { get; set; }

        public DateTime? gcCancelDate { get; set; }
    }
}
