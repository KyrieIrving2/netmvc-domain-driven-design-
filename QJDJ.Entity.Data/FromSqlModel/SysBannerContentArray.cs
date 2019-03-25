namespace QJDJ.Entity.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SysBannerContentArray")]
    public partial class SysBannerContentArray
    {
        [Key]
        public long sbcaId { get; set; }

        public long sbcaBannerId { get; set; }

        [StringLength(50)]
        public string sbcaOriginalPath { get; set; }

        [StringLength(50)]
        public string sbcaThumbPath { get; set; }

        [StringLength(50)]
        public string sbcaCutPath1 { get; set; }

        [StringLength(50)]
        public string sbcaCutPath2 { get; set; }

        [StringLength(50)]
        public string sbcaCutPath3 { get; set; }

        [StringLength(50)]
        public string sbcaText { get; set; }

        public int? sbcaType { get; set; }

        [StringLength(200)]
        public string sbcaValue { get; set; }

        public int? sbcaState { get; set; }

        public int? sbcaSort { get; set; }

        [StringLength(200)]
        public string sbcaRemark { get; set; }

        public DateTime? sbcaAddDate { get; set; }

        [StringLength(50)]
        public string sbcaTitle { get; set; }
    }
}
