namespace QJDJ.Entity.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SysAgent")]
    public partial class SysAgent
    {
        [Key]
        public long aId { get; set; }

        public long aFatherId { get; set; }

        public long? aRegionId { get; set; }

        [Required]
        [StringLength(50)]
        public string aNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string aName { get; set; }

        public int? aLevel { get; set; }

        [StringLength(50)]
        public string aTypeText { get; set; }

        [StringLength(50)]
        public string aPresenterId { get; set; }

        public DateTime? aStartDate { get; set; }

        public DateTime? aEndDate { get; set; }

        [Required]
        [StringLength(50)]
        public string aUserName { get; set; }

        [Required]
        [StringLength(50)]
        public string aUserPhone { get; set; }

        [StringLength(50)]
        public string aUserAddress { get; set; }

        public double? aLongitude { get; set; }

        public double? aLatitude { get; set; }

        [StringLength(50)]
        public string aUserCompany { get; set; }

        [StringLength(50)]
        public string aUserComCreditCode { get; set; }

        public int? aSort { get; set; }

        public long? aFillerId { get; set; }

        public DateTime? aFillDate { get; set; }

        public int? aIsCancel { get; set; }

        public long? aCancelId { get; set; }

        public DateTime? aCancelDate { get; set; }
    }
}
