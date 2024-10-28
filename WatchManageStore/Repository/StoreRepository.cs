using System.Collections.Generic;
using System.Linq;
using WatchManageStore.Data;
using WatchManageStore.Infrastructure;
using WatchManageStore.Models;
using WatchManageStore.Repository.IRepository;

namespace WatchManageStore.Repository
{
    public class StoreRepository : BaseRepository<Store>, IStoreRepository
    {
        private readonly ApplicationDBContext _context;

        public StoreRepository(ApplicationDBContext context) : base(context)
        {
            _context = context;
        }
        public List<Store> FindNewShop()
        {
            return _dbSet.Take(5).OrderByDescending(x => x.CreateOn).ToList();
        }
        public List<Store> FindLikeShop()
        {
            return _dbSet.Take(5).OrderByDescending(x => x.CreateOn).ToList();
          
        }

        public void DelById(int id)
        {
            var entity = _context.Stores.Find(id);
            _context.Stores.Remove(entity);
        }
        public Store GetDetail(int id)
        {
            return _context.Stores.FirstOrDefault(
                s => s.StoreId == id);
        }
    }
}
