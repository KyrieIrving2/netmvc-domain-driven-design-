using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QJDJ.Common.Action.Log4net;
using QJDJ.Entities.Data.DbContextModel;
using QJDJ.Entities.Data.FromSqlModel;
using QJDJ.Reository.Core.UnitOfWork;

namespace ManagementForQJDJ.Web.Areas.Areas.Controllers
{
    public class GoodsInfoesController : Controller
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        private QJModelContext db = new QJModelContext();

        // GET: Areas/GoodsInfoes
        public ActionResult Index()
        {
            string type = typeof(GoodsInfoesController) + ".index";
            //Log4netHelper.WriteLog(type, "出异常了");
            Log4netHelper.WriteLogsByRedis(type, "shit");
            var model = unitOfWork.GoodsInfo.GetListBy(g => g.gCancelId == 11);
            return View(model);
        }

        // GET: Areas/GoodsInfoes/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GoodsInfo goodsInfo = db.GoodsInfo.Find(id);
            if (goodsInfo == null)
            {
                return HttpNotFound();
            }
            return View(goodsInfo);
        }

        // GET: Areas/GoodsInfoes/Create
        public ActionResult Create()
        {
            ViewBag.gShopId = new SelectList(db.ShopInfo, "sId", "sShopName");
            return View();
        }

        // POST: Areas/GoodsInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "gId,gStationId,gSupplierId,gNumber,gName,gThumbImg1,gThumbImg2,gPicArray,gTagText,gTagValue1,gTagValue2,gTagValue3,gTagValue4,gTagValue5,gTagValue6,gTagValue7,gTagValue8,gTagValue9,gConentSummary,gContentDetail,gSlogan,gReminder,gDistribution,gSalesVolume,gBrand,gSourceArea,gStoreMode,gServiceMode,gKeys,gLabel,gDiscount,gWarnCount,gSafeDate,gShangjiaDate,gXiajiaDate,gAddDate,gState,gRemark,gFillerId,gFillDate,gIsCancel,gCancelId,gCancelDate,gContentDetailUrl,gShortPinyin,gStorage,gSeason,gShopId,gDaySalesAverage,gExternalNumber,gIsUseBean")] GoodsInfo goodsInfo)
        {
            if (ModelState.IsValid)
            {
                db.GoodsInfo.Add(goodsInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.gShopId = new SelectList(db.ShopInfo, "sId", "sShopName", goodsInfo.gShopId);
            return View(goodsInfo);
        }

        // GET: Areas/GoodsInfoes/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GoodsInfo goodsInfo = db.GoodsInfo.Find(id);
            if (goodsInfo == null)
            {
                return HttpNotFound();
            }
            ViewBag.gShopId = new SelectList(db.ShopInfo, "sId", "sShopName", goodsInfo.gShopId);
            return View(goodsInfo);
        }

        // POST: Areas/GoodsInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "gId,gStationId,gSupplierId,gNumber,gName,gThumbImg1,gThumbImg2,gPicArray,gTagText,gTagValue1,gTagValue2,gTagValue3,gTagValue4,gTagValue5,gTagValue6,gTagValue7,gTagValue8,gTagValue9,gConentSummary,gContentDetail,gSlogan,gReminder,gDistribution,gSalesVolume,gBrand,gSourceArea,gStoreMode,gServiceMode,gKeys,gLabel,gDiscount,gWarnCount,gSafeDate,gShangjiaDate,gXiajiaDate,gAddDate,gState,gRemark,gFillerId,gFillDate,gIsCancel,gCancelId,gCancelDate,gContentDetailUrl,gShortPinyin,gStorage,gSeason,gShopId,gDaySalesAverage,gExternalNumber,gIsUseBean")] GoodsInfo goodsInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(goodsInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.gShopId = new SelectList(db.ShopInfo, "sId", "sShopName", goodsInfo.gShopId);
            return View(goodsInfo);
        }

        // GET: Areas/GoodsInfoes/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GoodsInfo goodsInfo = db.GoodsInfo.Find(id);
            if (goodsInfo == null)
            {
                return HttpNotFound();
            }
            return View(goodsInfo);
        }

        // POST: Areas/GoodsInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            GoodsInfo goodsInfo = db.GoodsInfo.Find(id);
            db.GoodsInfo.Remove(goodsInfo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
