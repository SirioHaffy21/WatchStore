using WatchManageStore.Data;
using WatchManageStore.Infrastructure;
using WatchManageStore.Models;
using WatchManageStore.Repository.IRepository;

namespace WatchManageStore.Repository
{
    public class BrandRepository : BaseRepository<Brand>, IBrandRepository
    {

        public BrandRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
