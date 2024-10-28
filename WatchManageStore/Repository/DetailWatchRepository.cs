using WatchManageStore.Data;
using WatchManageStore.Infrastructure;
using WatchManageStore.Models;
using WatchManageStore.Repository.IRepository;

namespace WatchManageStore.Repository
{
    public class DetailWatchRepository : BaseRepository<DetailWatch>, IDetailWatchRepository
    {

        public DetailWatchRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
