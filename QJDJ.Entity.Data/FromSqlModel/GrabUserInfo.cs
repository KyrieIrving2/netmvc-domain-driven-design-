namespace QJDJ.Entity.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GrabUserInfo")]
    public partial class GrabUserInfo
    {
        [Key]
        [Column(Order = 0)]
        public Guid guiId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long guiUserId { get; set; }

        [StringLength(50)]
        public string guiUserNumber { get; set; }

        [StringLength(50)]
        public string guiRealName { get; set; }

        [StringLength(50)]
        public string guiIdCardNumber { get; set; }

        [StringLength(50)]
        public string guiSevenPay { get; set; }

        [StringLength(50)]
        public string guiQjdjAccount { get; set; }

        [StringLength(50)]
        public string guiPhoto { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int guiLevel { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int guiState { get; set; }

        [StringLength(50)]
        public string guiRecommendCode { get; set; }

        [StringLength(50)]
        public string guiRecommender { get; set; }
    }
}
