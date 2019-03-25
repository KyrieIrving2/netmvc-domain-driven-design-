namespace QJDJ.Entities.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GrabUserAssetInfo")]
    public partial class GrabUserAssetInfo
    {
        [Key]
        [Column(Order = 0)]
        public Guid guaiId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long guaiUserId { get; set; }

        [Key]
        [Column(Order = 2)]
        public double guaiCashAmount { get; set; }

        [Key]
        [Column(Order = 3)]
        public double guaiFrozenAmount { get; set; }

        [Key]
        [Column(Order = 4)]
        public double guaiWaitAmount { get; set; }
    }
}
