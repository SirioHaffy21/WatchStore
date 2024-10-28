using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using WatchManageStore.Data;
using WatchManageStore.Infrastructure;
using WatchManageStore.Models;
using WatchManageStore.Repository.IRepository;

namespace WatchManageStore.Repository
{
    public class RateAccountRepository : BaseRepository<RateAccount>, IRateAccountRepository
    {
        private readonly ApplicationDBContext _context;
        public RateAccountRepository(ApplicationDBContext context) : base(context)
        {
            _context = context; 
        }
        public override IList<RateAccount> FindByCondition(Expression<Func<RateAccount, bool>> condition)
        {
            var list= _context.RateAccounts.Where(condition).ToList();
            Account accounts = new Account();
            foreach (var item in list)
            {
                accounts = _context.Accounts.FirstOrDefault(x => x.Id == item.UserId);
                if (accounts != null)
                {
                    item.Accounts = accounts;
                }
            }
            return list;
        }
        public double RateAveragePost(int postId)
        {
            var res = _context.RateAccounts.Where(r => r.PostId == postId);
            if(res.Any())
            {
                var result = res.Average(r => r.Rate);
                return Math.Round(result, 0);
            }
            return 0;
        }

        public double RateAverageStore(int storeId)
        {
            var x = _context.RateAccounts.Where(r => r.StoreId == storeId);
            if (x.Any())
            {
                var result = x.Average(s => s.Rate);
                return Math.Round(result, 0);
            }
            return 0;
            
        }
        public double RateAverageWatch(int watchId)
        {
            var x = _context.RateAccounts.Where(r => r.WatchId == watchId);
            if (x.Any())
            {
                var result = x.Average(s => s.Rate);
                return Math.Round(result, 1);
            }
            return 0;
        }
    }
}
