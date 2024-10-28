using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WatchManageStore.Areas.Admin.Models;
using WatchManageStore.Models;

namespace WatchManageStore.Services.InterfaceServices
{
    public interface IWatchesService
    {
        public List<WatchVM> FindTrendWatch();
        public IList<Watch> GetAll();
        public WatchVM FindByCondition(int id);
        public List<WatchVM> FindNewdWatch();
        public int CountReviewWatch(int id);
        public IList<Watch> WatchByName(string name);
        public IList<RateAccount> ReviewWatch(int id);
    }
}
