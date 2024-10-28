using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using WatchManageStore.Areas.Admin.Models;
using WatchManageStore.Infrastructure;
using WatchManageStore.Models;
using WatchManageStore.Services.InterfaceServices;

namespace WatchManageStore.Services
{
    public class StoreService : IStoreService
    {
        private readonly IUnitOfWork _unitOfWork;
        private IMapper _mapper;
        public StoreService(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public List<StoreVM> FindNewStore()
        {
            return _mapper.Map<List<StoreVM>>(_unitOfWork.storeRepository.FindNewShop());
        }

        public List<StoreVM> FindTrendStore()
        {
            var result = new List<StoreVM>();
            var listStore = _unitOfWork.storeRepository.GetAll();
            for (int i = 0; i < listStore.Count; i++)
            {
                var vm = _mapper.Map<StoreVM>(listStore[i]);
                var rate = _unitOfWork.rateAccountRepository.RateAverageWatch(listStore[i].StoreId);
                vm.Rate = rate;
                result.Add(vm);
            }
            return result.OrderByDescending(x => x.Rate).Take(5).ToList();
        }
    }
}
