using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using WatchManageStore.Data;
using WatchManageStore.Infrastructure;
using WatchManageStore.Services;
using WatchManageStore.Services.InterfaceServices;

namespace WatchManageStore.Controllers
{
    public abstract class BaseController : Controller
    {
        private readonly IWatchesService _watchesService;
        private readonly IStoreService _storeService;
        private readonly IUnitOfWork _unitOfWork;
        public BaseController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _watchesService = new WatchesService(unitOfWork, mapper);
            _storeService = new StoreService(unitOfWork, mapper);
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            ViewBag.Brand = _unitOfWork.brandRepository.GetAll();
            ViewBag.NewWatch = _watchesService.FindNewdWatch();
            ViewBag.TrendWatch = _watchesService.FindTrendWatch();
            ViewBag.NewShop = _storeService.FindNewStore();
            ViewBag.LikeShop = _storeService.FindTrendStore();
            ViewBag.RecentPost = _unitOfWork.postRepository.FindPost();
            
            base.OnActionExecuting(context);
        }
    }
}
