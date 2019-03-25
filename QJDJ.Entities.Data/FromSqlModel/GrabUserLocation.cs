namespace QJDJ.Entities.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GrabUserLocation")]
    public partial class GrabUserLocation
    {
        [Key]
        [Column(Order = 0)]
        public Guid gulId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long gulUserId { get; set; }

        public double? gulLongitude { get; set; }

        public double? gulLatitude { get; set; }

        public DateTime? gulDate { get; set; }
    }
}
