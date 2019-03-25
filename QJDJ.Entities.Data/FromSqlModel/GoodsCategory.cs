namespace QJDJ.Entities.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GoodsCategory")]
    public partial class GoodsCategory
    {
        [Key]
        [Column(Order = 0)]
        public long gcId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long gcStationId { get; set; }

        public long? gcFatherId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string gcName { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string gcNumber { get; set; }

        [StringLength(50)]
        public string gcImg { get; set; }

        public int? gcIsHot { get; set; }

        public int? gcSort { get; set; }

        public int? gcState { get; set; }

        [StringLength(200)]
        public string gcRemark { get; set; }

        public long? gcFillerId { get; set; }

        public DateTime? gcFillDate { get; set; }

        public int? gcIsCancel { get; set; }

        public long? gcCancelId { get; set; }

        public DateTime? gcCancelDate { get; set; }
    }
}
