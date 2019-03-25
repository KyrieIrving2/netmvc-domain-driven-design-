namespace QJDJ.Entities.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SysUserShopCar")]
    public partial class SysUserShopCar
    {
        [Key]
        public Guid uscId { get; set; }

        public long uscUserId { get; set; }

        public long uscGoodsId { get; set; }

        public long uscGoodsAttributeId { get; set; }

        public int? uscGoodsCount { get; set; }

        public double? uscGoodsPrice { get; set; }

        public DateTime? uscUpdateTime { get; set; }

        public long? uscStationId { get; set; }

        [StringLength(200)]
        public string uscRemark { get; set; }

        public int? uscSelected { get; set; }

        [StringLength(50)]
        public string uscSubmitFlag { get; set; }
    }
}
