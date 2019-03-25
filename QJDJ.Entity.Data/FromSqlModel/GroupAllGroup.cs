namespace QJDJ.Entity.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GroupAllGroup")]
    public partial class GroupAllGroup
    {
        [Key]
        [Column(Order = 0)]
        public Guid gagKey { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long gagGoodsId { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime gagStartTime { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime gagEndTime { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int gagTotalCount { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int gagCurrentCount { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int gagMinCount { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int gagMaxCount { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int gagState { get; set; }

        [Key]
        [Column(Order = 9)]
        public double gagPurchasePrice { get; set; }

        [Key]
        [Column(Order = 10)]
        public double gagMarketPrice { get; set; }

        [Key]
        [Column(Order = 11)]
        public double gagWebPrice { get; set; }

        [Key]
        [Column(Order = 12)]
        public double gagAppPrice { get; set; }

        [StringLength(50)]
        public string gagAttribute { get; set; }

        public double? gagFreight { get; set; }

        [StringLength(50)]
        public string gagGoodsName { get; set; }
    }
}
