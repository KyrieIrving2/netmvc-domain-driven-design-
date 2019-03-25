namespace QJDJ.Entity.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SysBannerInfo")]
    public partial class SysBannerInfo
    {
        [Key]
        public long sbiId { get; set; }

        public long? sbiStationId { get; set; }

        [Required]
        [StringLength(50)]
        public string sbiTitle { get; set; }

        public int? sbiType { get; set; }

        [Column(TypeName = "ntext")]
        public string sbiContent { get; set; }

        public DateTime? sbiStartDate { get; set; }

        public DateTime? sbiEndDate { get; set; }

        public int? sbiState { get; set; }

        public int? sbiSort { get; set; }

        [StringLength(200)]
        public string sbiRemark { get; set; }

        public long? sbiFillerId { get; set; }

        public DateTime? sbiFillDate { get; set; }

        public int? sbiIsCancel { get; set; }

        public long? sbiCancelId { get; set; }

        public DateTime? sbiCancelDate { get; set; }
    }
}
