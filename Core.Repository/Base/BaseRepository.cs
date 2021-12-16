using System.Linq.Expressions;
using Core.IRepository;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Core.Repository.Base
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class, new()
    {
        private readonly DbContext _context;
        private readonly DbSet<TEntity> _entities;

        public BaseRepository(DbContext context)
        {
            _context = context;
            _entities = _context.Set<TEntity>();
        }

        #region 新增

        public TEntity Add(TEntity entity, bool isSave = true)
        {
            _context.Set<TEntity>().Add(entity);
            if (isSave && SaveChanges() > 0)
            {
                return entity;
            }
            return null;
        }

        public async Task<TEntity> AddAsync(TEntity entity, bool isSave = true)
        {
            try
            {
                await _context.Set<TEntity>().AddAsync(entity);
                if (isSave && await SaveChangesAsync() > 0)
                {
                    return entity;
                }
                return null;
            }
            catch (Exception ex)
            {

                throw ex;
            }
   
        }

        #endregion 新增

        #region 更新

        public bool Update(TEntity entity, bool isSave = true)
        {
            _context.Set<TEntity>().Update(entity);
            if (isSave && SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        #endregion 更新

        #region 删除

        public bool Remove(TEntity entity, bool isSave = true)
        {
            _context.Set<TEntity>().Remove(entity);
            if (isSave && SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public bool RemoveById(int id, bool isSave = true)
        {
            TEntity entity = FindById(id);
            _entities.Remove(entity);
            if (isSave && SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        #endregion 删除

        #region 查询

        public List<TEntity> FindAll()
        {
            return _entities.ToList();
        }

        public TEntity FindById(int id)
        {
            return _entities.Find(id);
        }

        public List<TEntity> Query(Expression<Func<TEntity, bool>> expression)
        {
            return _entities.Where(expression).ToList();
        }

        public List<TEntity> QueryByPage(Expression<Func<TEntity, bool>> expression = null, int start = 0, int end = 10)
        {
            if (expression == null)
            {
                return _entities.Skip(start).Take(end - start).ToList();
            }
            return _entities.Where(expression).Skip(start).Take(end - start).ToList();
        }

        public int GetCount(Expression<Func<TEntity, bool>> expression = null)
        {
            if (expression is null)
            {
                return _entities.Count();
            }
            return _entities.Where(expression).Count();
        }

        #endregion 查询

        #region SaveChanges

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async Task<TEntity> FindByIdAsync(int id)
        {
            return await _entities.FindAsync(id);
        }

        #endregion SaveChanges
    }
}
