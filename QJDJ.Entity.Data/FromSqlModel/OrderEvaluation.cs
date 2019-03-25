namespace QJDJ.Entity.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderEvaluation")]
    public partial class OrderEvaluation
    {
        [Key]
        public Guid oeId { get; set; }

        public long? oeStationId { get; set; }

        public Guid? oeOrderId { get; set; }

        public long? oeUserId { get; set; }

        public int? oeOrderLV { get; set; }

        public int? oeWaiterLV { get; set; }

        public DateTime? oeDate { get; set; }

        [StringLength(200)]
        public string oeRemark { get; set; }
    }
}
