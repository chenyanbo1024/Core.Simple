using Core.IServices;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Core.Services.Base;

public class BaseServices<TEntity> : IBaseServices<TEntity> where TEntity : class, new()
{
    private readonly CoreContext _context;
    private readonly DbSet<TEntity> _entities;
    public BaseServices(CoreContext context)
    {
        _context = context;
        _entities = _context.Set<TEntity>();
    }

    #region INSERT

    public async Task<int> AddAsync(TEntity entity, bool isSave = true)
    {
        await _entities.AddAsync(entity);
        if (isSave)
        {
            return await SaveChangeAsync();
        }
        return default;
    }

    # endregion INSERT


    #region QUERY

    public async Task<TEntity?> FindByIdAsync(int id)
    {
        return await _entities.FindAsync(id);
    }

    public async Task<List<TEntity>?> FindAsync(Expression<Func<TEntity, bool>> expression)
    {
        if (expression is null)
        {
            expression = x => true;
        }
        return await _entities.Where(expression).ToListAsync();
    }

    public async Task<int> CountAsync(Expression<Func<TEntity, bool>>? expression)
    {
        if (expression is null)
        {
            expression = x => true;
        }
        return await _entities.CountAsync(expression);
    }

    public async Task<List<TEntity>> FindByPage(Expression<Func<TEntity, bool>> expression,int skipCount = 0,int takeCount = 10)
    {
        if (expression is null)
        {
            expression = x => true;
        }
        return await _entities.Where(expression).Skip(skipCount).Take(takeCount).ToListAsync();
    }

    #endregion QUERY


    #region REMOVE
    public async Task<int> RemoveAsync(TEntity entity)
    {
        _entities.Remove(entity);
        return await SaveChangeAsync();
    }
    #endregion REMOVE


    #region UPDATE
    public async Task<int> Update()
    {
        return await SaveChangeAsync();
    }

    #endregion UPDATE

    /// <summary>
    /// 保存修改
    /// </summary>
    private async Task<int> SaveChangeAsync()
    {
        return await _context.SaveChangesAsync();
    }
}
