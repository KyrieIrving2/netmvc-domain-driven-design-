namespace QJDJ.Entity.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GroupUserInfo")]
    public partial class GroupUserInfo
    {
        [Key]
        public Guid guiId { get; set; }

        [StringLength(50)]
        public string guiKey { get; set; }

        [StringLength(50)]
        public string guiOpenId { get; set; }

        [StringLength(50)]
        public string guiUserTel { get; set; }

        [StringLength(50)]
        public string guiUserName { get; set; }

        [StringLength(200)]
        public string guiRecAddrDetail { get; set; }

        public long? guiBuildId { get; set; }

        [StringLength(50)]
        public string guiBuildText { get; set; }

        [StringLength(50)]
        public string guiCarNum { get; set; }

        [StringLength(50)]
        public string guiRegionNum { get; set; }

        public DateTime? guiFillDate { get; set; }

        [StringLength(50)]
        public string guiOriginalId { get; set; }
    }
}
