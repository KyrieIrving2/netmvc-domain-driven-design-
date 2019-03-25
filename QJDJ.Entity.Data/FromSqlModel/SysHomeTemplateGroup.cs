namespace QJDJ.Entity.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SysHomeTemplateGroup")]
    public partial class SysHomeTemplateGroup
    {
        [Key]
        public long htgId { get; set; }

        public long htgTemplateId { get; set; }

        [Required]
        [StringLength(50)]
        public string htgTitle { get; set; }

        public int? htgSort { get; set; }

        public int? htgState { get; set; }
    }
}
