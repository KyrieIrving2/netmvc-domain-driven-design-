namespace QJDJ.Entities.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SysUserSigninRecord")]
    public partial class SysUserSigninRecord
    {
        [Key]
        public Guid usrId { get; set; }

        public long usrUserId { get; set; }

        public int usrCount { get; set; }

        public DateTime? usrDateTime { get; set; }

        [StringLength(200)]
        public string usrRemark { get; set; }
    }
}
