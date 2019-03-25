namespace QJDJ.Entity.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GrabFinishError")]
    public partial class GrabFinishError
    {
        [Key]
        [Column(Order = 0)]
        public Guid gfeId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long gfeUserId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string gfeGrabNmuber { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int gfeErrorCode { get; set; }

        [StringLength(200)]
        public string gfeErrorDetail { get; set; }

        public DateTime? gfeDate { get; set; }

        public int? gfeState { get; set; }

        [StringLength(50)]
        public string gfeHandleUser { get; set; }

        [StringLength(100)]
        public string gfeHandleResult { get; set; }

        public DateTime? gfeHandleDate { get; set; }
    }
}
