namespace QJDJ.Entities.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GoodsShelves
    {
        [Key]
        public Guid gsId { get; set; }

        public long? gsStationId { get; set; }

        public long? gsGoodsId { get; set; }

        public long? gsShangjiaUserId { get; set; }

        public DateTime? gsShangjiaDate { get; set; }

        public long? gsXiajiaUserId { get; set; }

        public DateTime? gsXiajiaDate { get; set; }

        public int? gsState { get; set; }

        [StringLength(200)]
        public string gsRemark { get; set; }
    }
}
