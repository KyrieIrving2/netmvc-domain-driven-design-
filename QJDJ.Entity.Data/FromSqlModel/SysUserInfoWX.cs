namespace QJDJ.Entity.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SysUserInfoWX")]
    public partial class SysUserInfoWX
    {
        [Key]
        public long uId { get; set; }

        public long? uStationId { get; set; }

        [Required]
        [StringLength(50)]
        public string uAccount { get; set; }

        [Required]
        [StringLength(50)]
        public string uPassword { get; set; }

        [StringLength(50)]
        public string uNickName { get; set; }

        public string uPhoto { get; set; }

        [StringLength(50)]
        public string uRealName { get; set; }

        [StringLength(50)]
        public string uTelphone { get; set; }

        public int? uTelIsVerify { get; set; }

        [StringLength(50)]
        public string uEmail { get; set; }

        public int? uEmailIsVerify { get; set; }

        [StringLength(50)]
        public string uSalt { get; set; }

        [StringLength(50)]
        public string uIdCardNum { get; set; }

        [StringLength(50)]
        public string uDescribe { get; set; }

        [StringLength(50)]
        public string uCardNum { get; set; }

        [StringLength(50)]
        public string uCardKey { get; set; }

        public int? uSex { get; set; }

        [StringLength(50)]
        public string uLevel { get; set; }

        public int? uOccupation { get; set; }

        public int? uIncome { get; set; }

        public int? uEducation { get; set; }

        public int? uFamilyMemberCount { get; set; }

        public int? uIsRetire { get; set; }

        public DateTime? uRetireDate { get; set; }

        public int? uParty { get; set; }

        public DateTime? uBirthday { get; set; }

        [StringLength(50)]
        public string uSevenPay { get; set; }

        [StringLength(50)]
        public string uQQ { get; set; }

        [StringLength(50)]
        public string uWebChat { get; set; }

        [StringLength(50)]
        public string uWeibo { get; set; }

        public int? uState { get; set; }

        public DateTime? uStateTime { get; set; }

        public long? uStateUserId { get; set; }

        [StringLength(50)]
        public string uLoginWrongCount { get; set; }

        public DateTime? uRegisterDate { get; set; }

        [StringLength(50)]
        public string uRegisterWay { get; set; }

        [StringLength(50)]
        public string uRecommender { get; set; }

        [StringLength(200)]
        public string uRemark { get; set; }

        public DateTime? uFillDate { get; set; }

        public long? uFillerId { get; set; }

        [StringLength(50)]
        public string uKey { get; set; }
    }
}
