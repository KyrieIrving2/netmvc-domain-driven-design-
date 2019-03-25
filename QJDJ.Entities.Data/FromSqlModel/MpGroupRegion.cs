namespace QJDJ.Entities.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MpGroupRegion")]
    public partial class MpGroupRegion
    {
        [Key]
        public Guid grId { get; set; }

        [StringLength(50)]
        public string grFatherId { get; set; }

        [StringLength(50)]
        public string grName { get; set; }

        public int? grLevel { get; set; }

        public int? grState { get; set; }

        public int? grIsHot { get; set; }

        public int? grSort { get; set; }

        [StringLength(200)]
        public string grRemark { get; set; }

        public long? grFillerId { get; set; }

        public DateTime? grFillDate { get; set; }

        public int? grIsCancel { get; set; }

        public long? grCancelId { get; set; }

        public DateTime? grCancelDate { get; set; }
    }
}
