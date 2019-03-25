namespace QJDJ.Entities.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SysUserThird")]
    public partial class SysUserThird
    {
        [Key]
        public Guid utId { get; set; }

        public long utUserId { get; set; }

        public int utType { get; set; }

        [Required]
        [StringLength(50)]
        public string utValue { get; set; }

        [StringLength(50)]
        public string utAccount { get; set; }

        [StringLength(50)]
        public string utText { get; set; }

        public DateTime? utDate { get; set; }
    }
}
