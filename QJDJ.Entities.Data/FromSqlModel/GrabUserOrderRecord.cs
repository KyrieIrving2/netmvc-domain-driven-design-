namespace QJDJ.Entities.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GrabUserOrderRecord")]
    public partial class GrabUserOrderRecord
    {
        [Key]
        [Column(Order = 0)]
        public Guid guorId { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid guorGrabUserOrderId { get; set; }

        public DateTime? guorTime { get; set; }

        [StringLength(200)]
        public string guorContent { get; set; }
    }
}
