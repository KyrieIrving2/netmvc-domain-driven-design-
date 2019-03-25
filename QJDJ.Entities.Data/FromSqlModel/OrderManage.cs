namespace QJDJ.Entities.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderManage")]
    public partial class OrderManage
    {
        [Key]
        public Guid omId { get; set; }

        public Guid? omOrderId { get; set; }

        public long? om1StationId { get; set; }

        public int? om1State { get; set; }

        public long? om1OperaterId { get; set; }

        public DateTime? om1OperaterDate { get; set; }

        public long? om2StationId { get; set; }

        public int? om2State { get; set; }

        public long? om2OperaterId { get; set; }

        public DateTime? om2OperaterDate { get; set; }

        public long? om3StationId { get; set; }

        public int? om3State { get; set; }

        public long? om3OperaterId { get; set; }

        public DateTime? om3OperaterDate { get; set; }

        public long? om4StationId { get; set; }

        public int? om4State { get; set; }

        public long? om4OperaterId { get; set; }

        public DateTime? om4OperaterDate { get; set; }

        public long? om5StationId { get; set; }

        public int? om5State { get; set; }

        public long? om5OperaterId { get; set; }

        public DateTime? om5OperaterDate { get; set; }

        [StringLength(200)]
        public string omRemark { get; set; }
    }
}
