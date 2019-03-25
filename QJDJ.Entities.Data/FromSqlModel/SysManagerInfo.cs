namespace QJDJ.Entities.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SysManagerInfo")]
    public partial class SysManagerInfo
    {
        [Key]
        public long mId { get; set; }

        public int? mRoleId { get; set; }

        public int? mRoleType { get; set; }

        public long? mStationId { get; set; }

        public int? mType { get; set; }

        [Required]
        [StringLength(50)]
        public string mAccount { get; set; }

        [Required]
        [StringLength(200)]
        public string mPassword { get; set; }

        [StringLength(50)]
        public string mSalt { get; set; }

        [StringLength(50)]
        public string mNickName { get; set; }

        [StringLength(50)]
        public string mPhoto { get; set; }

        [Required]
        [StringLength(50)]
        public string mRealName { get; set; }

        [Required]
        [StringLength(50)]
        public string mTelephone { get; set; }

        public int? mTelIsVerify { get; set; }

        [StringLength(50)]
        public string mEmail { get; set; }

        public int? mEmailIsVerify { get; set; }

        [StringLength(50)]
        public string mIdCardNum { get; set; }

        [StringLength(50)]
        public string mCode { get; set; }

        [StringLength(50)]
        public string mProvince { get; set; }

        [StringLength(50)]
        public string mCity { get; set; }

        [StringLength(50)]
        public string mTown { get; set; }

        [StringLength(50)]
        public string mStreet { get; set; }

        [StringLength(50)]
        public string mDetail { get; set; }

        [StringLength(50)]
        public string mDescribe { get; set; }

        [StringLength(50)]
        public string mCardNum { get; set; }

        [StringLength(50)]
        public string mCardKey { get; set; }

        public int? mGender { get; set; }

        public int? mIsRetire { get; set; }

        public DateTime? mRetireDate { get; set; }

        [StringLength(50)]
        public string mParty { get; set; }

        [StringLength(50)]
        public string mLevel { get; set; }

        [StringLength(50)]
        public string mBirthday { get; set; }

        [StringLength(50)]
        public string mQQ { get; set; }

        [StringLength(50)]
        public string mWebChat { get; set; }

        [StringLength(50)]
        public string mWeibo { get; set; }

        public int? mState { get; set; }

        public DateTime? mStateTime { get; set; }

        public long? mStateUserId { get; set; }

        public int? mLoginWrongCount { get; set; }

        [StringLength(200)]
        public string mRemark { get; set; }

        public DateTime? mFillDate { get; set; }

        public long? mFillerId { get; set; }
    }
}
