namespace QJDJ.Entities.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MpCategoryList")]
    public partial class MpCategoryList
    {
        [Key]
        public Guid mp_id { get; set; }

        public long? category_id { get; set; }

        [StringLength(50)]
        public string category_name { get; set; }

        public int? category_level { get; set; }

        [StringLength(50)]
        public string category_img { get; set; }

        public long? category_father_id { get; set; }

        public int? category_sort { get; set; }

        [StringLength(50)]
        public string category_value { get; set; }

        public int? category_state { get; set; }

        [StringLength(50)]
        public string btn_tip_show { get; set; }

        [StringLength(50)]
        public string btn_tip_text { get; set; }

        [StringLength(50)]
        public string btn_url_title { get; set; }

        public int? station_id { get; set; }
    }
}
