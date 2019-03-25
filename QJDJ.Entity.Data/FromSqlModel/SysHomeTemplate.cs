namespace QJDJ.Entity.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SysHomeTemplate")]
    public partial class SysHomeTemplate
    {
        [Key]
        public long htId { get; set; }

        public long htStationId { get; set; }

        [Required]
        [StringLength(50)]
        public string htName { get; set; }

        [StringLength(200)]
        public string htRemark { get; set; }

        public int htState { get; set; }

        public DateTime? htStartDate { get; set; }

        public DateTime? htEndDate { get; set; }

        public long? htFillerId { get; set; }

        public DateTime? htFillDate { get; set; }

        public int? htIsCancel { get; set; }

        public long? htCancelId { get; set; }

        public DateTime? htCancelDate { get; set; }
    }
}
