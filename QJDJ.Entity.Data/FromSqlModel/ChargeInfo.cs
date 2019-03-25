namespace QJDJ.Entity.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChargeInfo")]
    public partial class ChargeInfo
    {
        [Key]
        [Column(Order = 0)]
        public long cId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string cType { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string cName { get; set; }

        [Key]
        [Column(Order = 3)]
        public double cPrice { get; set; }

        [StringLength(50)]
        public string cImgUrl { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long cState { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime cFillDate { get; set; }
    }
}
