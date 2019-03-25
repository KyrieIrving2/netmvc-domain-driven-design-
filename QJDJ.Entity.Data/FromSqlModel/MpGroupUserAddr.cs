namespace QJDJ.Entity.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MpGroupUserAddr")]
    public partial class MpGroupUserAddr
    {
        [Key]
        [Column(Order = 0)]
        public Guid guId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long guUserId { get; set; }

        [StringLength(50)]
        public string guUserName { get; set; }

        [StringLength(50)]
        public string guUserTel { get; set; }

        [StringLength(200)]
        public string guUserAddr { get; set; }

        [StringLength(50)]
        public string guCity { get; set; }

        [StringLength(50)]
        public string guRegion { get; set; }

        public DateTime? guFillDate { get; set; }
    }
}
