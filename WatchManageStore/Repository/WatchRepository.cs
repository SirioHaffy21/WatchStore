using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using WatchManageStore.Areas.Admin.Models;
using WatchManageStore.Data;
using WatchManageStore.Infrastructure;
using WatchManageStore.Models;
using WatchManageStore.Repository.IRepository;

namespace WatchManageStore.Repository
{
    public class WatchRepository : BaseRepository<Watch>, IWatchRepository
    {
        private readonly ApplicationDBContext _context;
        public DbSet<Watch> _dbSet { get; set; }
        public WatchRepository(ApplicationDBContext context) : base(context)
        {
            _context = context;
            _dbSet = _context.Set<Watch>();
        }
        public override Watch Find(Expression<Func<Watch, bool>> condition)
        {
            return _dbSet.Include(x=>x.RateAccounts).Include(x=>x.DetailWatch).FirstOrDefault(condition);
        }
        public List<Watch> FindNewWatch()
        {
            return _dbSet.Take(5).OrderByDescending(x => x.CreateOn).ToList();
        }

        
    }
}
