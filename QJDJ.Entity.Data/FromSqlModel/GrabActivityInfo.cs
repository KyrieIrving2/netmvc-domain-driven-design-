namespace QJDJ.Entity.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GrabActivityInfo")]
    public partial class GrabActivityInfo
    {
        [Key]
        public Guid gaiId { get; set; }

        [StringLength(50)]
        public string gaiTitle { get; set; }

        [StringLength(200)]
        public string gaiSummary { get; set; }

        [StringLength(50)]
        public string gaiImg { get; set; }

        public int? gaiState { get; set; }

        public DateTime? gaiDate { get; set; }

        [StringLength(50)]
        public string gaiLinkTip { get; set; }

        [StringLength(50)]
        public string gaiUrlTitle { get; set; }

        [StringLength(50)]
        public string gaiUrl { get; set; }
    }
}
