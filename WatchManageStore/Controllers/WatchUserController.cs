using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using WatchManageStore.Areas.Admin.Models;
using WatchManageStore.Infrastructure;
using WatchManageStore.Models;
using WatchManageStore.Services;
using WatchManageStore.Services.InterfaceServices;

namespace WatchManageStore.Controllers
{
    public class WatchUserController : BaseController
    {
        private readonly IWatchesService _watchesService;
        private readonly IUnitOfWork _unitOfWork;
        public WatchUserController(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork,mapper)
        {
            _unitOfWork = unitOfWork;
            _watchesService = new WatchesService(unitOfWork,mapper);
        }
        public IActionResult Index()
        {
            var res = _watchesService.GetAll();
            return View(res);
        }
        public IActionResult Detail(int id)
        {
            ViewBag.CountReview = _watchesService.CountReviewWatch(id);
            var res = _watchesService.FindByCondition(id);
            ViewBag.UserReview = _watchesService.ReviewWatch(id);
            return View(res);
        }
        public IActionResult WatchByName(string name)
        {
            var res= _watchesService.WatchByName(name);
            return View(res);
        }
        public IActionResult Create(int watchId,int rate)
        {
            var userId= HttpContext.User?.FindFirst(ClaimTypes.NameIdentifier).Value;
            var rateAccount = _unitOfWork.rateAccountRepository.Find
                (x => x.UserId == userId&&x.WatchId==watchId);
            
            if (rateAccount == null)
            {
                rateAccount = new RateAccount();
                rateAccount.WatchId = watchId;
                rateAccount.UserId = userId;
                rateAccount.Rate = rate;
                _unitOfWork.rateAccountRepository.Add(rateAccount);
            }
            else
            {
                rateAccount.Rate = rate;
                _unitOfWork.rateAccountRepository.Update(rateAccount);
            }
            _unitOfWork.SaveChanges();
            var res = _unitOfWork.rateAccountRepository.FindByCondition(x=>x.WatchId==watchId);
            return Json(new { rateaccount= res });
        }
        public IActionResult SearchWatch(string search)
        {
            var list = _unitOfWork.watchRepository.GetAll();
            var result = list.Where(x => x.WatchName.ToLower().Contains(search.ToLower())).ToList();
            return Json(new { searchItem = result });
        }
    }
}
