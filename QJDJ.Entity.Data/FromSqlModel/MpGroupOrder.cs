namespace QJDJ.Entity.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MpGroupOrder")]
    public partial class MpGroupOrder
    {
        [Key]
        [Column(Order = 0)]
        public Guid goId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long goUserId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string goNumber { get; set; }

        public DateTime? goDateTime { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string goRecUserTel { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string goRecUserName { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(200)]
        public string goRecAddrDetail { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string goGroupId { get; set; }

        [Key]
        [Column(Order = 7)]
        public double goGoodsPrice { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int goGoodsCount { get; set; }

        public int? goState { get; set; }

        public DateTime? goStateDate { get; set; }

        public double? goTotalAmount { get; set; }

        public double? goPayAmount { get; set; }

        public DateTime? goPayDate { get; set; }

        public int? goPayState { get; set; }

        [StringLength(50)]
        public string goPaySerialNumber { get; set; }

        public string goPayBack { get; set; }

        [StringLength(300)]
        public string goRemark { get; set; }

        public int? goIsCancel { get; set; }

        public long? goCancelId { get; set; }

        public DateTime? goCancelDate { get; set; }

        public double? goConfirmAmount { get; set; }

        [StringLength(300)]
        public string goConfirmRemark { get; set; }
    }
}
