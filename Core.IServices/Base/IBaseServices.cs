using System.Linq.Expressions;

namespace Core.IServices;

public interface IBaseServices<TEntity> where TEntity : class
{
    #region INSERT

    /// <summary>
    /// 插入一行数据
    /// </summary>
    /// <param name="entity">新增的数据对象</param>
    /// <param name="isSave">是否保存，默认为true</param>
    Task<int> AddAsync(TEntity entity, bool isSave = true);

    #endregion INSERT


    #region REMOVE

    /// <summary>
    /// 删除一行数据
    /// </summary>
    /// <param name="entity">元素</param>
    /// <returns></returns>
    Task<int> RemoveAsync(TEntity entity);

    #endregion REMOVE


    #region QUERY

    /// <summary>
    /// 根据 ID 查询
    /// </summary>
    /// <param name="id">ID</param>
    Task<TEntity?> FindByIdAsync(int id);

    /// <summary>
    /// 根据条件查询
    /// </summary>
    /// <param name="expression">表达式</param>
    /// <returns>返回满足条件的元素</returns>
    Task<List<TEntity>?> FindAsync(Expression<Func<TEntity, bool>> expression);

    /// <summary>
    /// 返回满足条件的元素个数
    /// </summary>
    /// <param name="expression">条件表达式</param>
    /// <returns></returns>
    Task<int> CountAsync(Expression<Func<TEntity, bool>>? expression);

    /// <summary>
    /// 分页查询
    /// </summary>
    /// <param name="expression">表达式</param>
    /// <param name="skipCount">跳过元素个数</param>
    /// <param name="takeCount">获取元素个数</param>
    /// <returns></returns>
    Task<List<TEntity>> FindByPage(Expression<Func<TEntity, bool>> expression, int skipCount = 0, int takeCount = 10);

    #endregion QUERY


    #region UPDATE

    /// <summary>
    /// 更新数据
    /// </summary>
    /// <returns></returns>
    Task<int> Update();

    #endregion UPDATE
}
