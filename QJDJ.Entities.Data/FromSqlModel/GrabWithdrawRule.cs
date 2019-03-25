namespace QJDJ.Entities.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GrabWithdrawRule")]
    public partial class GrabWithdrawRule
    {
        [Key]
        [Column(Order = 0)]
        public Guid gwrId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int gwrLevel { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string gwrWeek { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string gwrStartTime { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string gwrEndTime { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int gwrLimitCount { get; set; }

        [Key]
        [Column(Order = 6)]
        public double gwrLimitAmount { get; set; }

        [Key]
        [Column(Order = 7)]
        public double gwrMaxAmount { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int gwrState { get; set; }

        public DateTime? gwrStateTime { get; set; }
    }
}
