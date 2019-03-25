namespace QJDJ.Entity.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ShopInfo")]
    public partial class ShopInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ShopInfo()
        {
            GoodsInfo = new HashSet<GoodsInfo>();
        }

        [Key]
        public long sId { get; set; }

        [Required]
        [StringLength(20)]
        public string sShopName { get; set; }

        [Required]
        [StringLength(50)]
        public string sShopDescription { get; set; }

        [StringLength(50)]
        public string sShopImgUrl { get; set; }

        public long? sShopFocusCount { get; set; }

        public double? sShopService { get; set; }

        public double? sLogicsService { get; set; }

        [Required]
        [StringLength(10)]
        public string sManagerName { get; set; }

        [Required]
        [StringLength(50)]
        public string sManagerPhone { get; set; }

        [Required]
        [StringLength(50)]
        public string sManagerEmail { get; set; }

        public int? sIsRuning { get; set; }

        [Required]
        [StringLength(50)]
        public string sShopType { get; set; }

        [Required]
        [StringLength(50)]
        public string sShopAddrDetail { get; set; }

        public DateTime sShopStartRuntime { get; set; }

        public DateTime sShopEndRuntime { get; set; }

        [StringLength(50)]
        public string sRegisterName { get; set; }

        [StringLength(50)]
        public string sRegisterIdCardNum { get; set; }

        [StringLength(100)]
        public string sIdCardUpImgUrl { get; set; }

        [StringLength(100)]
        public string sIdCardBackImgUrl { get; set; }

        [StringLength(100)]
        public string sLicenceImgUrl { get; set; }

        public DateTime sLicenceBeginTime { get; set; }

        public int? sIsLicenceExpired { get; set; }

        public DateTime sLicenceEndTime { get; set; }

        public int? sIsChecked { get; set; }

        [StringLength(500)]
        public string sRemark { get; set; }

        [StringLength(500)]
        public string sCheckDescription { get; set; }

        [StringLength(500)]
        public string sLogicsDistribution { get; set; }

        [StringLength(50)]
        public string sServiceTel { get; set; }

        [StringLength(50)]
        public string sFillUser { get; set; }

        public DateTime sFillDate { get; set; }

        [StringLength(200)]
        public string sCoponInfoDesc { get; set; }

        [StringLength(20)]
        public string sShopNumber { get; set; }

        [Required]
        [StringLength(200)]
        public string sShopDescDetial { get; set; }

        public DateTime sIdCardBeginTime { get; set; }

        public int? sIsIdCardExpired { get; set; }

        public DateTime sIdCardEndTime { get; set; }

        [Required]
        [StringLength(20)]
        public string sLoginName { get; set; }

        [Required]
        [StringLength(200)]
        public string sPassword { get; set; }

        [StringLength(20)]
        public string sCreditcardNum { get; set; }

        [StringLength(100)]
        public string sCreditcardUpUrl { get; set; }

        [StringLength(100)]
        public string sCreditcardBackUrl { get; set; }

        [Required]
        [StringLength(200)]
        public string sComfirmPassword { get; set; }

        [StringLength(100)]
        public string sShopQrcodeUrl { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoodsInfo> GoodsInfo { get; set; }
    }
}
