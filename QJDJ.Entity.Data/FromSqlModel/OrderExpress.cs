namespace QJDJ.Entity.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderExpress")]
    public partial class OrderExpress
    {
        [Key]
        [Column(Order = 0)]
        public Guid oeId { get; set; }

        public Guid? omOrderId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string oeTrackNumber { get; set; }

        public DateTime? oeDate { get; set; }

        public long? oeOperatorId { get; set; }

        [StringLength(200)]
        public string oeRemark { get; set; }
    }
}
