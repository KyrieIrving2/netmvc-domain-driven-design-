namespace QJDJ.Entity.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GrabUserOrder123
    {
        [Key]
        [Column(Order = 0)]
        public Guid guoId { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid guoGrabOrderInfoId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long guoUserId { get; set; }

        public DateTime? guoGetTime { get; set; }

        public int? guoGetMode { get; set; }

        public int? guoState { get; set; }

        public DateTime? guoStateTime { get; set; }

        [StringLength(100)]
        public string guoGrabNmuber { get; set; }

        [StringLength(50)]
        public string guoPickupCode { get; set; }

        [StringLength(50)]
        public string guoPaySerialNumber { get; set; }

        public string guoPayBack { get; set; }

        public DateTime? guoPayDate { get; set; }

        public int? guoPayState { get; set; }

        public double? guoCommonIncome { get; set; }

        public double? guoRewardIncome { get; set; }
    }
}
