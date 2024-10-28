using System;
using WatchManageStore.Data;
using WatchManageStore.Repository.IRepository;

namespace WatchManageStore.Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        IAccountRepository accountRepository { get; }
        IBrandRepository brandRepository { get; }
        ICategoryRepository categoryRepository { get; } 
        ICommentRepository commentRepository { get; }   
        IDetailWatchRepository detailWatchRepository { get; }   
        IPostRepository postRepository { get; } 
        IStoreRepository storeRepository { get; }    
        IWatchRepository watchRepository { get; }
        IRateAccountRepository  rateAccountRepository { get; }
        ApplicationDBContext DbContext { get; }

        int SaveChanges();
    }
}
