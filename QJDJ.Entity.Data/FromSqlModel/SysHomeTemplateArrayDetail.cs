namespace QJDJ.Entity.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SysHomeTemplateArrayDetail")]
    public partial class SysHomeTemplateArrayDetail
    {
        [Key]
        public long htadId { get; set; }

        public long htadGroupArrayId { get; set; }

        [StringLength(50)]
        public string htadPath { get; set; }

        public int? htadType { get; set; }

        [StringLength(300)]
        public string htadValue { get; set; }

        [StringLength(50)]
        public string htadTitle { get; set; }

        public int? htadState { get; set; }

        public int? htadSort { get; set; }

        [StringLength(200)]
        public string htadRemark { get; set; }

        public DateTime? htadDateTime { get; set; }
    }
}
