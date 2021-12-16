using System.Linq.Expressions;

namespace Core.IRepository
{
    public interface IBaseRepository<TEntity> where TEntity : class, new()
    {
        #region 新增

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity">新增的数据对象</param>
        /// <param name="isSave">是否保存，默认为true</param>
        TEntity Add(TEntity entity, bool isSave = true);
        Task<TEntity> FindByIdAsync(int id);

        /// <summary>
        /// 新增（同步方法）
        /// </summary>
        /// <param name="entity">新增的数据对象</param>
        /// <param name="isSave">是否保存，默认为true</param>
        Task<TEntity> AddAsync(TEntity entity, bool isSave = true);

        #endregion 新增

        #region 更新

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="entity">新增的数据对象</param>
        /// <param name="isSave">是否保存，默认为true</param>
        /// <returns></returns>
        bool Update(TEntity entity, bool isSave = true);

        #endregion 更新

        #region 删除

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="entity">新增的数据对象</param>
        /// <param name="isSave">是否保存，默认为true</param>
        /// <returns></returns>
        bool Remove(TEntity entity, bool isSave = true);

        /// <summary>
        /// 根据id删除
        /// </summary>
        /// <param name="id">表id</param>
        /// <param name="isSave">是否保存，默认为true</param>
        /// <returns></returns>
        bool RemoveById(int id, bool isSave = true);

        #endregion 删除

        #region 查询

        /// <summary>
        /// 查询所有
        /// </summary>
        /// <returns></returns>
        List<TEntity> FindAll();

        /// <summary>
        /// 根据id查询
        /// </summary>
        /// <param name="key">id</param>
        /// <returns></returns>
        TEntity FindById(int key);

        /// <summary>
        /// 条件查询
        /// </summary>
        /// <param name="expression">查询表示式</param>
        /// <returns></returns>
        List<TEntity> Query(Expression<Func<TEntity, bool>> expression);

        /// <summary>
        /// 分页条件查询
        /// </summary>
        /// <param name="expression">查询表示式</param>
        /// <param name="start">从第几个开始</param>
        /// <param name="end">到第几个结束</param>
        /// <returns></returns>
        List<TEntity> QueryByPage(Expression<Func<TEntity, bool>> expression = null, int start = 0, int end = 10);

        /// <summary>
        /// 根据条件查询总行数
        /// </summary>
        /// <param name="expression">查询表达式</param>
        /// <returns></returns>
        int GetCount(Expression<Func<TEntity, bool>> expression = null);

        #endregion 查询
    }
}
