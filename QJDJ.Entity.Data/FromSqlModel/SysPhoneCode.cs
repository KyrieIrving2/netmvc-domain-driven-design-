namespace QJDJ.Entity.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SysPhoneCode")]
    public partial class SysPhoneCode
    {
        [Key]
        public Guid spcId { get; set; }

        [Required]
        [StringLength(50)]
        public string spcTel { get; set; }

        [Required]
        [StringLength(50)]
        public string spcCode { get; set; }

        [Required]
        [StringLength(50)]
        public string spcType { get; set; }

        public DateTime spcDate { get; set; }

        public int spcState { get; set; }

        public DateTime? spcCheckTime { get; set; }

        public int? spcCount { get; set; }
    }
}
