using WatchManageStore.Data;
using WatchManageStore.Repository;
using WatchManageStore.Repository.IRepository;

namespace WatchManageStore.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDBContext _context;

        IAccountRepository _accountRepository;
        IBrandRepository _brandRepository;
        ICategoryRepository _categoryRepository;
        ICommentRepository _commentRepository;  
        IDetailWatchRepository _detailWatchRepository;  
        IPostRepository _postRepository;    
        IStoreRepository _storeRepository;
        IWatchRepository _watchRepository;  
        IRateAccountRepository _rateAccountRepository;
       
        public UnitOfWork(ApplicationDBContext context)
        {
            _context = context;
        }

        public ApplicationDBContext DbContext => _context;

        public IAccountRepository accountRepository => _accountRepository ?? (_accountRepository = new AccountRepository(_context));
        public IBrandRepository brandRepository => _brandRepository ?? (_brandRepository = new BrandRepository(_context));

        public ICategoryRepository categoryRepository =>_categoryRepository ??(_categoryRepository = new CategoryRepository(_context));

        public ICommentRepository commentRepository => _commentRepository ??(_commentRepository = new CommentRepository(_context));

        public IDetailWatchRepository detailWatchRepository => _detailWatchRepository??(_detailWatchRepository = new DetailWatchRepository(_context));

        public IPostRepository postRepository => _postRepository ??(_postRepository = new PostRepository(_context));

        public IStoreRepository storeRepository => _storeRepository ?? (_storeRepository = new StoreRepository(_context));

        public IWatchRepository watchRepository => _watchRepository ?? (_watchRepository = new WatchRepository(_context));

        public IRateAccountRepository rateAccountRepository => _rateAccountRepository??(_rateAccountRepository = new RateAccountRepository(_context));

        public void Dispose()
        {
            _context.Dispose();
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
