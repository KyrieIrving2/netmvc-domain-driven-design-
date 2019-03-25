namespace QJDJ.Entities.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SysUserAddressMiniWX")]
    public partial class SysUserAddressMiniWX
    {
        [Key]
        public Guid uaId { get; set; }

        public long uaUserId { get; set; }

        [StringLength(50)]
        public string uaUserName { get; set; }

        [StringLength(50)]
        public string uaUserTel { get; set; }

        [StringLength(50)]
        public string uaProvince { get; set; }

        [StringLength(50)]
        public string uaCity { get; set; }

        [StringLength(50)]
        public string uaDistrict { get; set; }

        [StringLength(50)]
        public string uaCityId { get; set; }

        [StringLength(50)]
        public string uaCityName { get; set; }

        [StringLength(200)]
        public string uaDetail { get; set; }

        public DateTime? uaFillDate { get; set; }
    }
}
