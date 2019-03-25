namespace QJDJ.Entities.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SysWxAccountInfo")]
    public partial class SysWxAccountInfo
    {
        [Key]
        public Guid wxId { get; set; }

        [Required]
        [StringLength(50)]
        public string wxName { get; set; }

        [Required]
        [StringLength(50)]
        public string wxOriginalId { get; set; }

        [Required]
        [StringLength(50)]
        public string wxAppId { get; set; }

        [Required]
        [StringLength(50)]
        public string wxAppSecret { get; set; }

        [StringLength(50)]
        public string wxToken { get; set; }

        [StringLength(50)]
        public string wxEncodingAesKey { get; set; }

        [StringLength(50)]
        public string wxPayAccount { get; set; }

        [StringLength(50)]
        public string wxPayMchId { get; set; }

        [StringLength(50)]
        public string wxPayKey { get; set; }

        [StringLength(50)]
        public string wxPayAppSecret { get; set; }
    }
}
