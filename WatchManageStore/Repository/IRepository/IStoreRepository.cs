using System.Collections.Generic;
using WatchManageStore.Infrastructure;
using WatchManageStore.Models;

namespace WatchManageStore.Repository.IRepository
{
    public interface IStoreRepository : IBaseRepository<Store>
    {

        public List<Store> FindNewShop();
        public List<Store> FindLikeShop();
        public void DelById(int id);
        Store GetDetail(int id);
    }
}
