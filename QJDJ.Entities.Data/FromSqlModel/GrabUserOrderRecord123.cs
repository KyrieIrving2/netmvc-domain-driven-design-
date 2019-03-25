namespace QJDJ.Entities.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GrabUserOrderRecord123
    {
        [Key]
        [Column(Order = 0)]
        public Guid guorId { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid guorGrabUserOrderId { get; set; }

        public DateTime? guorTime { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(200)]
        public string guorContent { get; set; }
    }
}
