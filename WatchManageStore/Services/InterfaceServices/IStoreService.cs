using System.Collections.Generic;
using WatchManageStore.Areas.Admin.Models;
using WatchManageStore.Models;

namespace WatchManageStore.Services.InterfaceServices
{
    interface IStoreService
    {
        public List<StoreVM> FindNewStore();
        public List<StoreVM> FindTrendStore();
       
    }
}
