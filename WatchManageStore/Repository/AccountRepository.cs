using WatchManageStore.Data;
using WatchManageStore.Infrastructure;
using WatchManageStore.Models;
using WatchManageStore.Repository.IRepository;

namespace WatchManageStore.Repository
{
    public class AccountRepository : BaseRepository<Account>, IAccountRepository
    {
        public AccountRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
