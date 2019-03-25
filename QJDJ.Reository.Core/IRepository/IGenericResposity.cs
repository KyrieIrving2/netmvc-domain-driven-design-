using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace QJDJ.Reository.Core.IRepository
{
    public interface IGenericResposity<TEntity> where TEntity : class
    {
        #region 常用增删改查方法

        #region 1.0 新增实体，返回受影响的行数 +  int Add(TEntity model)
        int Add(TEntity model);
        #endregion

        #region 1.1 新增实体，返回对应的实体对象 + TEntity AddReturnModel(TEntity model)
        TEntity AddReturnModel(TEntity model);
        #endregion

        #region 2.0 根据id删除 +  int Del(T model)
        int Del(TEntity model);
        #endregion

        #region 2.1 根据条件删除 + int DelBy(Expression<Func<T, bool>> delWhere)
        int DelBy(Expression<Func<TEntity, bool>> delWhere);
        #endregion

        #region 3.0 修改实体 +  int Modify(T model)
        int Modify(TEntity model);
        #endregion

        #region 3.1 修改实体，可修改指定属性 + int Modify(T model, params string[] propertyNames)
        int Modify(TEntity model, params string[] propertyNames);
        #endregion

        #region 3.2 批量修改 + int ModifyBy(T model, Expression<Func<T, bool>> whereLambda, params string[] modifiedPropertyNames)
        int ModifyBy(TEntity model, Expression<Func<TEntity, bool>> whereLambda, params string[] modifiedPropertyNames);
        #endregion

        #region 4.0 根据条件查询单个model + T GetModel(Expression<Func<T, bool>> whereLambda)
        TEntity GetModel(Expression<Func<TEntity, bool>> whereLambda);
        #endregion

        #region 4.1 根据条件查询单个model并排序  +  T GetModel<TKey>(Expression<Func<T, bool>> whereLambda, Expression<Func<T, TKey>> orderLambda, bool isAsc = true)
        TEntity GetModel<TKey>(Expression<Func<TEntity, bool>> whereLambda, Expression<Func<TEntity, TKey>> orderLambda, bool isAsc = true);
        #endregion

        #region  5.0 根据条件查询 + List<T> GetListBy(Expression<Func<T, bool>> whereLambda)
        List<TEntity> GetListBy(Expression<Func<TEntity, bool>> whereLambda);
        #endregion

        #region 5.1 根据条件查询，并排序 +  List<T> GetListBy<TKey>(Expression<Func<T, bool>> whereLambda, Expression<Func<T, TKey>> orderLambda, bool isAsc = true)
        List<TEntity> GetListBy<TKey>(Expression<Func<TEntity, bool>> whereLambda, Expression<Func<TEntity, TKey>> orderLambda, bool isAsc = true);

        #endregion

        #region 5.2 根据条件查询Top多少个，并排序 + List<T> GetListBy<TKey>(int top, Expression<Func<T, bool>> whereLambda, Expression<Func<T, TKey>> orderLambda, bool isAsc = true)
        List<TEntity> GetListBy<TKey>(int top, Expression<Func<TEntity, bool>> whereLambda, Expression<Func<TEntity, TKey>> orderLambda, bool isAsc = true);

        #endregion

        #region  5.3 根据条件排序查询  双排序 + List<T> GetListBy<TKey1, TKey2>(Expression<Func<T, bool>> whereLambda, Expression<Func<T, TKey1>> orderLambda1, Expression<Func<T, TKey2>> orderLambda2, bool isAsc1 = true, bool isAsc2 = true)
        List<TEntity> GetListBy<TKey1, TKey2>(Expression<Func<TEntity, bool>> whereLambda, Expression<Func<TEntity, TKey1>> orderLambda1, Expression<Func<TEntity, TKey2>> orderLambda2, bool isAsc1 = true, bool isAsc2 = true);

        #endregion

        #region 5.3 根据条件排序查询Top个数  双排序 + List<T> GetListBy<TKey1, TKey2>(int top, Expression<Func<T, bool>> whereLambda, System.Linq.Expressions.Expression<Func<T, TKey1>> orderLambda1, Expression<Func<T, TKey2>> orderLambda2, bool isAsc1 = true, bool isAsc2 = true)
        List<TEntity> GetListBy<TKey1, TKey2>(int top, Expression<Func<TEntity, bool>> whereLambda, Expression<Func<TEntity, TKey1>> orderLambda1, Expression<Func<TEntity, TKey2>> orderLambda2, bool isAsc1 = true, bool isAsc2 = true);
        #endregion

        #region 6.0 分页查询 + List<T> GetPagedList<TKey>
        List<TEntity> GetPagedList<TKey>(int pageIndex, int pageSize, Expression<Func<TEntity, bool>> whereLambda, Expression<Func<TEntity, TKey>> orderByLambda, bool isAsc = true);

        #endregion

        #region 6.1分页查询 带输出 +List<T> GetPagedList<TKey>
        List<TEntity> GetPagedList<TKey>(int pageIndex, int pageSize, ref int rowCount, Expression<Func<TEntity, bool>> whereLambda, Expression<Func<TEntity, TKey>> orderByLambda, bool isAsc = true);
        #endregion

        #region 6.2 分页查询 带输出 并支持双字段排序
        List<TEntity> GetPagedList<TKey1, TKey2>(int pageIndex, int pageSize, ref int rowCount, Expression<Func<TEntity, bool>> whereLambda, Expression<Func<TEntity, TKey1>> orderByLambda1, Expression<Func<TEntity, TKey2>> orderByLambda2, bool isAsc1 = true, bool isAsc2 = true);

        #endregion



        #endregion


        #region 特殊方法

        #endregion
    }
}
