namespace QJDJ.Entity.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SysUserGoodsFavorite")]
    public partial class SysUserGoodsFavorite
    {
        [Key]
        public Guid ugfId { get; set; }

        public long ugfUserId { get; set; }

        public long ugfGoodsId { get; set; }

        public double? ugfGoodsPrice { get; set; }

        public DateTime? ugfUpdateTime { get; set; }

        [StringLength(200)]
        public string ugfRemark { get; set; }
    }
}
