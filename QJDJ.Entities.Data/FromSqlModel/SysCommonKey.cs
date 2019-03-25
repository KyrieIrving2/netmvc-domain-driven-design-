namespace QJDJ.Entities.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SysCommonKey")]
    public partial class SysCommonKey
    {
        [Key]
        public int kId { get; set; }

        [Required]
        [StringLength(50)]
        public string kName { get; set; }

        public int kNum { get; set; }

        [StringLength(200)]
        public string kRemark { get; set; }

        [StringLength(50)]
        public string kFillerId { get; set; }

        public DateTime? kFillDate { get; set; }

        public int? kIsCancel { get; set; }

        [StringLength(50)]
        public string kCancelId { get; set; }

        public DateTime? kCancelDate { get; set; }
    }
}
