namespace QJDJ.Entity.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GrabUserWithdrawRecord")]
    public partial class GrabUserWithdrawRecord
    {
        [Key]
        [Column(Order = 0)]
        public Guid guwrId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long guwrUserId { get; set; }

        public DateTime? guwrDate { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int guwrType { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string guwrAccount { get; set; }

        [StringLength(50)]
        public string guwrUserRealName { get; set; }

        public double? guwrAmount { get; set; }

        [StringLength(100)]
        public string guwrContent { get; set; }

        [StringLength(200)]
        public string guwrRemark { get; set; }

        public int? guwrState { get; set; }

        [StringLength(50)]
        public string guwrPaySerialNumber { get; set; }

        [StringLength(500)]
        public string guwrPayBack { get; set; }

        public DateTime? guwrPayDate { get; set; }
    }
}
