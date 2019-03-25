namespace QJDJ.Entity.Data.DbContextModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using QJDJ.Entity.Data.FromSqlModel;

    public partial class QJModelContext : DbContext
    {
        public QJModelContext()
            : base("name=QJModelContext")
        {
        }

        public virtual DbSet<GoodsInfo> GoodsInfo { get; set; }
        public virtual DbSet<OrderInfo> OrderInfo { get; set; }
        public virtual DbSet<OrderInfo_old> OrderInfo_old { get; set; }
        public virtual DbSet<OrderItemInfo> OrderItemInfo { get; set; }
        public virtual DbSet<OrderItemInfo_old> OrderItemInfo_old { get; set; }
        public virtual DbSet<OrderLogisticsInfo> OrderLogisticsInfo { get; set; }
        public virtual DbSet<OrderManage> OrderManage { get; set; }
        public virtual DbSet<QdOrderInfo> QdOrderInfo { get; set; }
        public virtual DbSet<SearchRecord> SearchRecord { get; set; }
        public virtual DbSet<ShopInfo> ShopInfo { get; set; }
        public virtual DbSet<SysAgent> SysAgent { get; set; }
        public virtual DbSet<SysBannerContentArray> SysBannerContentArray { get; set; }
        public virtual DbSet<SysBannerInfo> SysBannerInfo { get; set; }
        public virtual DbSet<SysCommonKey> SysCommonKey { get; set; }
        public virtual DbSet<SysCommonValue> SysCommonValue { get; set; }
        public virtual DbSet<SysHomeTemplate> SysHomeTemplate { get; set; }
        public virtual DbSet<SysHomeTemplateArrayDetail> SysHomeTemplateArrayDetail { get; set; }
        public virtual DbSet<SysHomeTemplateGroup> SysHomeTemplateGroup { get; set; }
        public virtual DbSet<SysHomeTemplateGroupArray> SysHomeTemplateGroupArray { get; set; }
        public virtual DbSet<SysManagerInfo> SysManagerInfo { get; set; }
        public virtual DbSet<SysNoticeInfo> SysNoticeInfo { get; set; }
        public virtual DbSet<SysPhoneCode> SysPhoneCode { get; set; }
        public virtual DbSet<SysRegionInfo> SysRegionInfo { get; set; }
        public virtual DbSet<SysStationBuild> SysStationBuild { get; set; }
        public virtual DbSet<SysStationInfo> SysStationInfo { get; set; }
        public virtual DbSet<SysStationInfo_old> SysStationInfo_old { get; set; }
        public virtual DbSet<SysStationInfoWX> SysStationInfoWX { get; set; }
        public virtual DbSet<SysStationOrderRec> SysStationOrderRec { get; set; }
        public virtual DbSet<SysUserAddress> SysUserAddress { get; set; }
        public virtual DbSet<SysUserAddressMiniWX> SysUserAddressMiniWX { get; set; }
        public virtual DbSet<SysUserAddressWX> SysUserAddressWX { get; set; }
        public virtual DbSet<SysUserDeviceToken> SysUserDeviceToken { get; set; }
        public virtual DbSet<SysUserGoodsFavorite> SysUserGoodsFavorite { get; set; }
        public virtual DbSet<SysUserInfo> SysUserInfo { get; set; }
        public virtual DbSet<SysUserInfoWX> SysUserInfoWX { get; set; }
        public virtual DbSet<SysUserIntegralRecord> SysUserIntegralRecord { get; set; }
        public virtual DbSet<SysUserMoneyRecord> SysUserMoneyRecord { get; set; }
        public virtual DbSet<SysUserShopCar> SysUserShopCar { get; set; }
        public virtual DbSet<SysUserSigninRecord> SysUserSigninRecord { get; set; }
        public virtual DbSet<SysUserThird> SysUserThird { get; set; }
        public virtual DbSet<SysUserWallet> SysUserWallet { get; set; }
        public virtual DbSet<SysUserWalletWX> SysUserWalletWX { get; set; }
        public virtual DbSet<SysWxAccountInfo> SysWxAccountInfo { get; set; }
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<ChargeInfo> ChargeInfo { get; set; }
        public virtual DbSet<GoodsAttribute> GoodsAttribute { get; set; }
        public virtual DbSet<GoodsCategory> GoodsCategory { get; set; }
        public virtual DbSet<GoodsComment> GoodsComment { get; set; }
        public virtual DbSet<GoodsInfo_New> GoodsInfo_New { get; set; }
        public virtual DbSet<GoodsInfoCategory> GoodsInfoCategory { get; set; }
        public virtual DbSet<GoodsPriceZhongchu> GoodsPriceZhongchu { get; set; }
        public virtual DbSet<GoodsShelves> GoodsShelves { get; set; }
        public virtual DbSet<GoodsSupplier> GoodsSupplier { get; set; }
        public virtual DbSet<GrabActivityInfo> GrabActivityInfo { get; set; }
        public virtual DbSet<GrabFinishError> GrabFinishError { get; set; }
        public virtual DbSet<GrabOrderInfoAll> GrabOrderInfoAll { get; set; }
        public virtual DbSet<GrabOrderInfoAll123> GrabOrderInfoAll123 { get; set; }
        public virtual DbSet<GrabPickupError> GrabPickupError { get; set; }
        public virtual DbSet<GrabUserAssetDetail> GrabUserAssetDetail { get; set; }
        public virtual DbSet<GrabUserAssetInfo> GrabUserAssetInfo { get; set; }
        public virtual DbSet<GrabUserInfo> GrabUserInfo { get; set; }
        public virtual DbSet<GrabUserLocation> GrabUserLocation { get; set; }
        public virtual DbSet<GrabUserOrder> GrabUserOrder { get; set; }
        public virtual DbSet<GrabUserOrder123> GrabUserOrder123 { get; set; }
        public virtual DbSet<GrabUserOrderRecord> GrabUserOrderRecord { get; set; }
        public virtual DbSet<GrabUserOrderRecord123> GrabUserOrderRecord123 { get; set; }
        public virtual DbSet<GrabUserWithdrawRecord> GrabUserWithdrawRecord { get; set; }
        public virtual DbSet<GrabWithdrawRule> GrabWithdrawRule { get; set; }
        public virtual DbSet<GroupAllGoodsInfo> GroupAllGoodsInfo { get; set; }
        public virtual DbSet<GroupAllGroup> GroupAllGroup { get; set; }
        public virtual DbSet<GroupHeadInfo> GroupHeadInfo { get; set; }
        public virtual DbSet<GroupOrderInfo> GroupOrderInfo { get; set; }
        public virtual DbSet<GroupOrderInfo0755> GroupOrderInfo0755 { get; set; }
        public virtual DbSet<GroupUserInfo> GroupUserInfo { get; set; }
        public virtual DbSet<MpBannerList> MpBannerList { get; set; }
        public virtual DbSet<MpCategoryGoodsDetail> MpCategoryGoodsDetail { get; set; }
        public virtual DbSet<MpCategoryGoodsList> MpCategoryGoodsList { get; set; }
        public virtual DbSet<MpCategoryList> MpCategoryList { get; set; }
        public virtual DbSet<MpGroupInfo> MpGroupInfo { get; set; }
        public virtual DbSet<MpGroupOrder> MpGroupOrder { get; set; }
        public virtual DbSet<MpGroupRegion> MpGroupRegion { get; set; }
        public virtual DbSet<MpGroupUserAddr> MpGroupUserAddr { get; set; }
        public virtual DbSet<MpMenuList> MpMenuList { get; set; }
        public virtual DbSet<OfflineOrderInfo> OfflineOrderInfo { get; set; }
        public virtual DbSet<OfflineOrderItemInfo> OfflineOrderItemInfo { get; set; }
        public virtual DbSet<OrderEvaluation> OrderEvaluation { get; set; }
        public virtual DbSet<OrderExpress> OrderExpress { get; set; }
        public virtual DbSet<OrderGoodsToComment> OrderGoodsToComment { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderInfo>()
                .HasMany(e => e.OrderItemInfo)
                .WithRequired(e => e.OrderInfo)
                .HasForeignKey(e => e.oiiOrderId);

            modelBuilder.Entity<ShopInfo>()
                .HasMany(e => e.GoodsInfo)
                .WithRequired(e => e.ShopInfo)
                .HasForeignKey(e => e.gShopId);

            modelBuilder.Entity<SysCommonKey>()
                .Property(e => e.kName)
                .IsUnicode(false);

            modelBuilder.Entity<SysCommonKey>()
                .Property(e => e.kRemark)
                .IsUnicode(false);

            modelBuilder.Entity<SysCommonKey>()
                .Property(e => e.kFillerId)
                .IsUnicode(false);

            modelBuilder.Entity<SysCommonKey>()
                .Property(e => e.kCancelId)
                .IsUnicode(false);
        }
    }
}
