namespace QJDJ.Entities.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SysUserMoneyRecord")]
    public partial class SysUserMoneyRecord
    {
        [Key]
        public Guid umrId { get; set; }

        public long umrUserId { get; set; }

        public int? umrType { get; set; }

        public double? umrCount { get; set; }

        [StringLength(50)]
        public string umrOrderNumber { get; set; }

        [StringLength(50)]
        public string umrContent { get; set; }

        public DateTime? umrDate { get; set; }

        public int? umrState { get; set; }

        [StringLength(200)]
        public string umrRemark { get; set; }
    }
}
