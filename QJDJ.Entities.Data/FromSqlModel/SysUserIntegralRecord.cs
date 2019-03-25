namespace QJDJ.Entities.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SysUserIntegralRecord")]
    public partial class SysUserIntegralRecord
    {
        [Key]
        public Guid uirId { get; set; }

        public long uirUserId { get; set; }

        public int? uirType { get; set; }

        public int? uirCount { get; set; }

        [StringLength(50)]
        public string uirOrderNumber { get; set; }

        [StringLength(50)]
        public string uirContent { get; set; }

        public DateTime? uirDate { get; set; }

        public int? uirState { get; set; }

        [StringLength(200)]
        public string uirRemark { get; set; }
    }
}
