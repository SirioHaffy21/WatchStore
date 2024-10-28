using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WatchManageStore.Areas.Admin.Models;
using WatchManageStore.Infrastructure;
using WatchManageStore.Models;
using WatchManageStore.Services.InterfaceServices;

namespace WatchManageStore.Services
{
    public class WatchesService: IWatchesService
    {
        private IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public WatchesService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public IList<Watch> GetAll()
        {
            return _unitOfWork.watchRepository.GetAll();
        }
        public WatchVM FindByCondition(int id)
        {
            var res = _unitOfWork.watchRepository.Find(x => x.WatchId == id);
            double rate = 0;
            foreach (var item in res.RateAccounts)
            {
                rate += item.Rate;
            }
            rate = rate / res.RateAccounts.Count;
            var watchVM = _mapper.Map<WatchVM>(res);
            watchVM.Rate = rate;
            return watchVM;
        }
        public List<WatchVM> FindNewdWatch()
        {
            return _mapper.Map<List<WatchVM>>(_unitOfWork.watchRepository.FindNewWatch());
        }
        public List<WatchVM> FindTrendWatch()
        {
            var result = new List<WatchVM>();
            var listWatch = _unitOfWork.watchRepository.GetAll();
            for (int i = 0; i < listWatch.Count; i++)
            {
                var vm = _mapper.Map<WatchVM>(listWatch[i]);
                var rate = _unitOfWork.rateAccountRepository.RateAverageWatch(listWatch[i].WatchId);
                vm.Rate = rate;
                result.Add(vm);
            }
            return result.OrderByDescending(x => x.Rate).Take(5).ToList();
        }
        public int CountReviewWatch(int id)
        {
            return _unitOfWork.rateAccountRepository.FindByCondition(x => x.WatchId == id).Count();
        }
        public IList<RateAccount> ReviewWatch(int id)
        {
            return _unitOfWork.rateAccountRepository.FindByCondition(x => x.WatchId == id);
        }
        public IList<Watch> WatchByName(string name)
        {
            return _unitOfWork.watchRepository.FindByCondition(x => x.Brands.BrandName.Equals(name));
        }
    }
}
