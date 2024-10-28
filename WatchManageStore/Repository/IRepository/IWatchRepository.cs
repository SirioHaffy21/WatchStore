using System.Collections.Generic;
using WatchManageStore.Areas.Admin.Models;
using WatchManageStore.Infrastructure;
using WatchManageStore.Models;

namespace WatchManageStore.Repository.IRepository
{
    public interface IWatchRepository : IBaseRepository<Watch>
    {
        public List<Watch> FindNewWatch();
     
       
    }
}
