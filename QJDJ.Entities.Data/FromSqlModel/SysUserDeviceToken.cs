namespace QJDJ.Entities.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SysUserDeviceToken")]
    public partial class SysUserDeviceToken
    {
        [Key]
        public Guid udtId { get; set; }

        public long? udtUserId { get; set; }

        public int? udtDeviceType { get; set; }

        [Required]
        [StringLength(50)]
        public string udtDeviceToken { get; set; }

        public DateTime? udtDateTime { get; set; }
    }
}
