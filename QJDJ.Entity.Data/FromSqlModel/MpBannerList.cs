namespace QJDJ.Entity.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MpBannerList")]
    public partial class MpBannerList
    {
        [Key]
        public Guid mp_id { get; set; }

        public long? category_id { get; set; }

        [StringLength(50)]
        public string banner_img { get; set; }

        [StringLength(50)]
        public string banner_type { get; set; }

        [StringLength(50)]
        public string banner_value { get; set; }

        public int? banner_sort { get; set; }

        public int? banner_state { get; set; }

        [StringLength(50)]
        public string banner_url_title { get; set; }

        public int? station_id { get; set; }
    }
}
