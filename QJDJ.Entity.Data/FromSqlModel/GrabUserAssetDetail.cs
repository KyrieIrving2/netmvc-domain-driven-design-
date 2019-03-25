namespace QJDJ.Entity.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GrabUserAssetDetail")]
    public partial class GrabUserAssetDetail
    {
        [Key]
        [Column(Order = 0)]
        public Guid guadId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long guadUserId { get; set; }

        public DateTime? guadDate { get; set; }

        [StringLength(200)]
        public string guadContent { get; set; }

        public int? guadType { get; set; }

        [Key]
        [Column(Order = 2)]
        public double guadCount { get; set; }
    }
}
