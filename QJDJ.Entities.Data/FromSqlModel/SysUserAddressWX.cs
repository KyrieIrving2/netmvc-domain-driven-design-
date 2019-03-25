namespace QJDJ.Entities.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SysUserAddressWX")]
    public partial class SysUserAddressWX
    {
        [Key]
        public long uaId { get; set; }

        public long uaUserId { get; set; }

        public int? uaIsDefault { get; set; }

        public long? uaStationId { get; set; }

        [StringLength(50)]
        public string uaProvince { get; set; }

        [StringLength(50)]
        public string uaCity { get; set; }

        [StringLength(50)]
        public string uaBlock { get; set; }

        [StringLength(200)]
        public string uaDetail { get; set; }

        [StringLength(50)]
        public string uaRecUserName { get; set; }

        [StringLength(50)]
        public string uaRecUserTel { get; set; }

        [StringLength(50)]
        public string uaTag { get; set; }

        [StringLength(300)]
        public string uaRemark { get; set; }

        public long? uaFillerId { get; set; }

        public DateTime? uaFillDate { get; set; }

        public int? uaIsCancel { get; set; }

        public long? uaCancelId { get; set; }

        public DateTime? uaCancelDate { get; set; }

        public long? uaBuildId { get; set; }

        [StringLength(50)]
        public string uaCityId { get; set; }
    }
}
