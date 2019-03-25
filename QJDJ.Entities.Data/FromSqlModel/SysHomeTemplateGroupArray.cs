namespace QJDJ.Entities.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SysHomeTemplateGroupArray")]
    public partial class SysHomeTemplateGroupArray
    {
        [Key]
        public long htgaId { get; set; }

        public long htgaGroupId { get; set; }

        [Required]
        [StringLength(50)]
        public string htgaTitle { get; set; }

        public int? htgaType { get; set; }

        public int? htgaSort { get; set; }

        public int? htgaState { get; set; }
    }
}
