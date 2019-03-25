namespace QJDJ.Entity.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SysStationOrderRec")]
    public partial class SysStationOrderRec
    {
        [Key]
        public long sorId { get; set; }

        public long sorStationId { get; set; }

        public int sorNum { get; set; }

        [Required]
        [StringLength(50)]
        public string sorText { get; set; }

        public int sorInterval { get; set; }

        [Required]
        [StringLength(50)]
        public string sorCondition { get; set; }

        public int? sorSort { get; set; }

        public int? sorState { get; set; }

        public int? sorIsCancel { get; set; }

        public long? sorCancelId { get; set; }

        public DateTime? sorCancelDate { get; set; }
    }
}
