namespace QJDJ.Entities.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SysRegionInfo")]
    public partial class SysRegionInfo
    {
        [Key]
        public long riId { get; set; }

        public long? riFatherId { get; set; }

        [StringLength(50)]
        public string riName { get; set; }

        public int? riLevel { get; set; }

        public int? riState { get; set; }

        public int? riIsHot { get; set; }

        public int? riSort { get; set; }

        [StringLength(50)]
        public string riRemark { get; set; }

        public long? riFillerId { get; set; }

        public DateTime? riFillDate { get; set; }

        public int? riIsCancel { get; set; }

        public long? riCancelId { get; set; }

        public DateTime? riCancelDate { get; set; }
    }
}
