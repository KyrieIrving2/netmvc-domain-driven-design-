namespace QJDJ.Entity.Data.FromSqlModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GrabOrderInfoAll")]
    public partial class GrabOrderInfoAll
    {
        [Key]
        [Column(Order = 0)]
        public Guid goiId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string goiOrderNumber { get; set; }

        public DateTime? goiStartTime { get; set; }

        public DateTime? goiEndTime { get; set; }

        public long? goiSendUserId { get; set; }

        public long? goiStationId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int goiState { get; set; }

        public DateTime? goiStateTime { get; set; }

        public double? goiRewardIncomeMin { get; set; }

        public double? goiRewardIncomeMax { get; set; }

        [StringLength(300)]
        public string goiStationDetail { get; set; }

        public double? goiStationLongitude { get; set; }

        public double? goiStationLatitude { get; set; }

        [StringLength(300)]
        public string goiUserAddrDetail { get; set; }

        public double? goiUserAddrLongitude { get; set; }

        public double? goiUserAddrLatitude { get; set; }

        [StringLength(50)]
        public string goiOrderTag { get; set; }

        public double? goiOrderAmount { get; set; }

        public double? goiCommonIncome { get; set; }

        [StringLength(50)]
        public string goiLogisticsNumber { get; set; }

        [StringLength(50)]
        public string goiOrderSource { get; set; }

        public int? goiOrderLimitTimer { get; set; }

        [StringLength(200)]
        public string goiOrderRemark { get; set; }

        [StringLength(50)]
        public string goiUserAddrName { get; set; }

        [StringLength(50)]
        public string goiUserAddrTel { get; set; }

        [StringLength(50)]
        public string goiUserConfirmCode { get; set; }
    }
}
