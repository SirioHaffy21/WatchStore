using System.Collections.Generic;
using WatchManageStore.Infrastructure;
using WatchManageStore.Models;

namespace WatchManageStore.Services
{
    public class AdminStoreService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AdminStoreService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IList<Store> GetListStore()
        {
            return _unitOfWork.storeRepository.GetAll();
        }
        public Store GetById(int id)
        {
            return _unitOfWork.storeRepository.Find(x => x.StoreId == id);
        }

    }
}
