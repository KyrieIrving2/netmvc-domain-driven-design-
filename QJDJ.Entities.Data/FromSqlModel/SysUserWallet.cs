namespace QJDJ.Entities.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SysUserWallet")]
    public partial class SysUserWallet
    {
        [Key]
        public Guid uwId { get; set; }

        public long uwUserId { get; set; }

        public int uwIntegral { get; set; }

        public double uwMoney { get; set; }

        public int uwCouponsCount { get; set; }

        [StringLength(200)]
        public string uwRemark { get; set; }
    }
}
