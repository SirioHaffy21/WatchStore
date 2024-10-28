using WatchManageStore.Infrastructure;
using WatchManageStore.Models;

namespace WatchManageStore.Services
{
    public class AdminWatchService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AdminWatchService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public int SaveWatch(Watch watch)
        {
            _unitOfWork.watchRepository.Add(watch);
            _unitOfWork.SaveChanges();
            var result = _unitOfWork.watchRepository.Find(x => x.WatchName == watch.WatchName);
            return result.WatchId;
        }
    }
}
