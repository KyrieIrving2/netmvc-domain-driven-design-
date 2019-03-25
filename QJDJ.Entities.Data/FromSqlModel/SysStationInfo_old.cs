namespace QJDJ.Entities.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SysStationInfo_old
    {
        [Key]
        public long siId { get; set; }

        [Required]
        [StringLength(50)]
        public string siName { get; set; }

        public long? siRegionId { get; set; }

        public long? siFatherId { get; set; }

        [StringLength(50)]
        public string siNumber { get; set; }

        public int? siLevel { get; set; }

        [StringLength(50)]
        public string siType { get; set; }

        public double? siLongitude { get; set; }

        public double? siLatitude { get; set; }

        [StringLength(50)]
        public string siProvince { get; set; }

        [StringLength(50)]
        public string siCity { get; set; }

        [StringLength(50)]
        public string siTown { get; set; }

        [StringLength(50)]
        public string siStreet { get; set; }

        [StringLength(50)]
        public string siDetail { get; set; }

        [StringLength(50)]
        public string siPostCode { get; set; }

        [StringLength(50)]
        public string siDescribe { get; set; }

        [StringLength(50)]
        public string siPropertyType { get; set; }

        [StringLength(50)]
        public string siPropertyCom { get; set; }

        public int? siIsHot { get; set; }

        public int? siSort { get; set; }

        public DateTime? siStartDate { get; set; }

        public DateTime? siStateDate { get; set; }

        public int? siState { get; set; }

        [StringLength(200)]
        public string siRemark { get; set; }

        public long? siFillerId { get; set; }

        public DateTime? siFillDate { get; set; }

        public int? siIsCancel { get; set; }

        public long? siCancelId { get; set; }

        public DateTime? siCancelDate { get; set; }

        [StringLength(50)]
        public string siUserName { get; set; }

        [StringLength(50)]
        public string siUserPhone { get; set; }

        [StringLength(50)]
        public string siUserFixedPhone { get; set; }
    }
}
