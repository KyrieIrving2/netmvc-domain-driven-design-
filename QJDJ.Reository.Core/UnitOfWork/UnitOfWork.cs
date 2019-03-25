using QJDJ.Entities.Data.DbContextModel;
using QJDJ.Entities.Data.FromSqlModel;
using QJDJ.Reository.Core.IRepository;
using QJDJ.Reository.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QJDJ.Reository.Core.UnitOfWork
{
    /// <summary>
    /// 工作单元：提供实体上下文对象，保证上下文唯一性
    /// </summary>
    public class UnitOfWork
    {
        private QJModelContext _dbContext;
        public UnitOfWork()
        {
            this._dbContext = new QJModelContext();
        }


        private IGenericResposity<GoodsInfo> _GoodsInfo;
        public IGenericResposity<GoodsInfo> GoodsInfo
        {
            get
            {
                if (this._GoodsInfo == null)
                {
                    this._GoodsInfo = new GenericResposity<GoodsInfo>(_dbContext);
                }
                return _GoodsInfo;
            }
        }
    }
}
