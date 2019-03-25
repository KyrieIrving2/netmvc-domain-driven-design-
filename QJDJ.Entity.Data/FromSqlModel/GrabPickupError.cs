namespace QJDJ.Entity.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GrabPickupError")]
    public partial class GrabPickupError
    {
        [Key]
        [Column(Order = 0)]
        public Guid gpeId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long gpeUserId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string gpeGrabNmuber { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int gpeErrorCode { get; set; }

        [StringLength(200)]
        public string gpeErrorDetail { get; set; }

        public DateTime? gpeDate { get; set; }

        public int? gpeState { get; set; }

        [StringLength(50)]
        public string gpeHandleUser { get; set; }

        [StringLength(100)]
        public string gpeHandleResult { get; set; }

        public DateTime? gpeHandleDate { get; set; }
    }
}
