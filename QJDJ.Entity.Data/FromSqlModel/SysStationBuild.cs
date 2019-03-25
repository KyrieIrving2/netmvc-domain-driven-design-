namespace QJDJ.Entity.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SysStationBuild")]
    public partial class SysStationBuild
    {
        [Key]
        public long sbId { get; set; }

        public long? sbStationId { get; set; }

        [Required]
        [StringLength(50)]
        public string sbText { get; set; }

        public int? sbSort { get; set; }

        public int? sbState { get; set; }

        public int? sbIsCancel { get; set; }

        public long? sbCancelId { get; set; }

        public DateTime? sbCancelDate { get; set; }

        public double? sbLongitude { get; set; }

        public double? sbLatitude { get; set; }
    }
}
