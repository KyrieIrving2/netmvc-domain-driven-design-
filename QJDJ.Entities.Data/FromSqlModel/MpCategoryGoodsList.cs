namespace QJDJ.Entities.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MpCategoryGoodsList")]
    public partial class MpCategoryGoodsList
    {
        [Key]
        public Guid mp_id { get; set; }

        public long? category_id { get; set; }

        [StringLength(50)]
        public string group_type { get; set; }

        [StringLength(50)]
        public string group_text { get; set; }

        [StringLength(50)]
        public string group_default_color { get; set; }

        [StringLength(50)]
        public string group_ad_show { get; set; }

        [StringLength(50)]
        public string group_ad_img { get; set; }

        [StringLength(50)]
        public string group_ad_url_type { get; set; }

        [StringLength(50)]
        public string group_ad_url { get; set; }

        [StringLength(50)]
        public string background_show { get; set; }

        [StringLength(50)]
        public string background_type { get; set; }

        [StringLength(50)]
        public string background_value { get; set; }

        [StringLength(50)]
        public string goods_name_color { get; set; }

        [StringLength(50)]
        public string goods_attr_color { get; set; }

        [StringLength(50)]
        public string goods_slogan_color { get; set; }

        [StringLength(50)]
        public string price_normal_color { get; set; }

        [StringLength(50)]
        public string price_normal_title { get; set; }

        [StringLength(50)]
        public string price_market_color { get; set; }

        [StringLength(50)]
        public string price_market_title { get; set; }

        [StringLength(50)]
        public string goods_car_type { get; set; }

        [StringLength(50)]
        public string goods_car_text { get; set; }

        [StringLength(50)]
        public string goods_car_bgcolor { get; set; }

        [StringLength(50)]
        public string goods_tip_show { get; set; }

        [StringLength(50)]
        public string goods_tip_position { get; set; }

        [StringLength(50)]
        public string goods_tip_value { get; set; }

        [StringLength(50)]
        public string goods_tab_color { get; set; }

        [StringLength(500)]
        public string group_goods_list { get; set; }

        [StringLength(50)]
        public string goods_car_bgcolor2 { get; set; }

        [StringLength(50)]
        public string goods_car_img { get; set; }

        [StringLength(50)]
        public string goods_car_img2 { get; set; }

        public int? group_state { get; set; }

        public int? group_sort { get; set; }

        [StringLength(50)]
        public string goods_car_textcolor { get; set; }

        [StringLength(50)]
        public string goods_car_textcolor2 { get; set; }
    }
}
