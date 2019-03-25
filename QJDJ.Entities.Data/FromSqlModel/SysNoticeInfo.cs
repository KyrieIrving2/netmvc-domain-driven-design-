namespace QJDJ.Entities.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SysNoticeInfo")]
    public partial class SysNoticeInfo
    {
        [Key]
        public long sniId { get; set; }

        public long? sniStationId { get; set; }

        [Required]
        [StringLength(50)]
        public string sniTitle { get; set; }

        [Column(TypeName = "ntext")]
        public string sniContent { get; set; }

        [StringLength(50)]
        public string sniContentUrl { get; set; }

        public int? sniType { get; set; }

        [StringLength(50)]
        public string sniValue { get; set; }

        public DateTime? sniStartDate { get; set; }

        public DateTime? sniEndDate { get; set; }

        public int? sniState { get; set; }

        public int? sniSort { get; set; }

        [StringLength(200)]
        public string sniRemark { get; set; }

        public long? sniFillerId { get; set; }

        public DateTime? sniFillDate { get; set; }

        public int? sniIsCancel { get; set; }

        public long? sniCancelId { get; set; }

        public DateTime? sniCancelDate { get; set; }

        [StringLength(50)]
        public string sniText { get; set; }
    }
}
