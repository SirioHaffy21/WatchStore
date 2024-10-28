using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using WatchManageStore.Areas.Admin.Models;
using WatchManageStore.Infrastructure;
using WatchManageStore.Models;

namespace WatchManageStore.Controllers
{
    public class ShopController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ShopController(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var res = _unitOfWork.storeRepository.GetAll();
            var shopvm = _mapper.Map<List<StoreVM>>(res);
            return View(shopvm);
        }
        [HttpGet]
        public IActionResult Details(int storeId)
        {
            var post = _unitOfWork.storeRepository.GetDetail(storeId);
            if (post != null)
            {
                var res = _unitOfWork.storeRepository.Find(x => x.StoreId == storeId);
                var rate = _unitOfWork.rateAccountRepository.RateAverageStore(storeId);
                var storevm = _mapper.Map<StoreVM>(res);
                storevm.Rate = rate;
                return View(storevm);
            }

            return View("_NotFound");

        }
        [HttpPost]
        public ActionResult Create(int storeId, int rate)
        {
            var userId = HttpContext.User?.FindFirst(ClaimTypes.NameIdentifier).Value;
            RateAccount rateAccount = new RateAccount();
            rateAccount.Rate = rate;

            if (rateAccount == null)
            {
                rateAccount.StoreId = storeId;
                rateAccount.UserId = userId;
                _unitOfWork.rateAccountRepository.Add(rateAccount);
            }
            else
            {
                _unitOfWork.rateAccountRepository.Update(rateAccount);
            }
            _unitOfWork.SaveChanges();

            return Json(new { code = 200, msg = "Đánh giá thành công" });
        }

        public IActionResult SearchStore(string search)
        {

            var list = _unitOfWork.storeRepository.GetAll();
            if (search == null)
            {
                return Json(new { searchItem = list });

            }
            if (string.IsNullOrEmpty(search))
            {
                return Json(new { searchItem = list });
            }

            var result = list.Where(x => x.StoreName.ToLower().Contains(search.ToLower())).ToList();
            //var result = from Store in list
            //             where Store.StoreName.ToLower() == search
            //             select Store;
            //Store st = new Store();
            //foreach (var store in result)
            //{
            //    st = store;
            //}

            return Json(new { searchItem = result });
            // return View();
        }
    }
}
