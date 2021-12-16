using Core.IRepository;
using Core.Models;
using Core.Models.Model;
using Core.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace Core.Repository
{
    public class TestRepository : BaseRepository<Test>, ITestRepository
    {
        private readonly CoreContext _context;
        private readonly DbSet<Test> _entity;

        public TestRepository(CoreContext context) : base(context)
        {
            _context = context;
            _entity = _context.Set<Test>();
        }
    }
}
