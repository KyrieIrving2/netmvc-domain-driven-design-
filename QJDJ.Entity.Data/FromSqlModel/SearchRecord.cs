namespace QJDJ.Entity.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SearchRecord")]
    public partial class SearchRecord
    {
        [Key]
        public long srId { get; set; }

        public long? srStationId { get; set; }

        [StringLength(50)]
        public string srText { get; set; }

        public int? srCount { get; set; }

        public int? srIsHot { get; set; }

        public int? srSort { get; set; }

        [StringLength(200)]
        public string srRemark { get; set; }

        public DateTime? srUpdateDate { get; set; }
    }
}
