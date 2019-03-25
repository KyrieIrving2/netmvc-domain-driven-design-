namespace QJDJ.Entity.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderLogisticsInfo")]
    public partial class OrderLogisticsInfo
    {
        [Key]
        public Guid oliId { get; set; }

        public Guid oliOrderExpressId { get; set; }

        public DateTime? oliDate { get; set; }

        [StringLength(100)]
        public string oliContent { get; set; }

        [StringLength(200)]
        public string oliRemark { get; set; }
    }
}
