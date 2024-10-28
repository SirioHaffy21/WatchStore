using WatchManageStore.Infrastructure;
using WatchManageStore.Models;

namespace WatchManageStore.Repository.IRepository
{
    public interface IRateAccountRepository: IBaseRepository<RateAccount>
    {
        public double RateAverageStore(int storeId);  
        public double RateAveragePost(int postId);
        public double RateAverageWatch(int watchId);
    }
}
