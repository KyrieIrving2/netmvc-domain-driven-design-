namespace QJDJ.Entities.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SysCommonValue")]
    public partial class SysCommonValue
    {
        [Key]
        public int vId { get; set; }

        [Required]
        [StringLength(50)]
        public string vKeyId { get; set; }

        public int vNum { get; set; }

        [Required]
        [StringLength(50)]
        public string vName { get; set; }

        public int? vSort { get; set; }

        [StringLength(200)]
        public string vRemark { get; set; }

        [StringLength(50)]
        public string vFillerId { get; set; }

        public DateTime? vFillDate { get; set; }

        public int? vIsCancel { get; set; }

        [StringLength(50)]
        public string vCancelId { get; set; }

        public DateTime? vCancelDate { get; set; }

        [StringLength(50)]
        public string vDetail { get; set; }
    }
}
