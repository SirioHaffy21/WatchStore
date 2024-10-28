using WatchManageStore.Data;
using WatchManageStore.Infrastructure;
using WatchManageStore.Models;
using WatchManageStore.Repository.IRepository;

namespace WatchManageStore.Repository
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
