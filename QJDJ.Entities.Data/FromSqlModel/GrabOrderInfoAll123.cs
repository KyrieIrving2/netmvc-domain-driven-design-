namespace QJDJ.Entities.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GrabOrderInfoAll123
    {
        [Key]
        [Column(Order = 0)]
        public Guid goiId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string goiOrderNumber { get; set; }

        public DateTime? goiStartTime { get; set; }

        public DateTime? goiEndTime { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long goiSendUserId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long goiStationId { get; set; }

        public int? goiState { get; set; }

        public DateTime? goiStateTime { get; set; }

        public double? goiRewardMin { get; set; }

        public double? goiRewardMax { get; set; }
    }
}
