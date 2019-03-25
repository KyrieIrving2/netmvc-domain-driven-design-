namespace QJDJ.Entities.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GoodsSupplier")]
    public partial class GoodsSupplier
    {
        [Key]
        [Column(Order = 0)]
        public long gsId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string gsName { get; set; }
    }
}
