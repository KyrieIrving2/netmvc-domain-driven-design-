namespace QJDJ.Entities.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MpMenuList")]
    public partial class MpMenuList
    {
        [Key]
        public Guid mp_id { get; set; }

        [StringLength(50)]
        public string menu_text { get; set; }

        [StringLength(50)]
        public string menu_default_color { get; set; }

        [StringLength(50)]
        public string menu_default_img { get; set; }

        [StringLength(50)]
        public string menu_selected_color { get; set; }

        [StringLength(50)]
        public string menu_selected_img { get; set; }

        public int? menu_state { get; set; }
    }
}
