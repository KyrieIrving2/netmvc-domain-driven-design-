namespace QJDJ.Entity.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GroupHeadInfo")]
    public partial class GroupHeadInfo
    {
        [Key]
        [Column(Order = 0)]
        public Guid ghiKey { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ghiNumber { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string ghiRegionNum { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string ghiRegionText { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string ghiStreetNum { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string ghiStreetText { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(200)]
        public string ghiAddress { get; set; }

        public double? ghiLongitude { get; set; }

        public double? ghiLatitude { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string ghiUserName { get; set; }

        [StringLength(50)]
        public string ghiUserPhone { get; set; }

        [StringLength(50)]
        public string ghiUserFixedPhone { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ghiState { get; set; }

        public DateTime? ghiFillDate { get; set; }
    }
}
