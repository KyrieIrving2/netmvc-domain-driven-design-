namespace QJDJ.Entities.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MpCategoryGoodsDetail")]
    public partial class MpCategoryGoodsDetail
    {
        [Key]
        public Guid mp_id { get; set; }

        public long? category_id { get; set; }

        [StringLength(50)]
        public string group_type { get; set; }

        public long? goods_id { get; set; }

        public int? goods_sort { get; set; }
    }
}
