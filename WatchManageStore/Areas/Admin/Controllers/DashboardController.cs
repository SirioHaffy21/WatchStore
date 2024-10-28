using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WatchManageStore.Infrastructure;

namespace WatchManageStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Administrator")]
    public class DashboardController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public DashboardController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult GetDashBoard()
        {
            var list = new List<int>();
            var listPost = _unitOfWork.postRepository.GetAll(); 
            for (int i = 1; i <= 12; i++)
            {
                var numberPost = listPost.Where(x => x.CreateOn.Month == i).Count();
                list.Add(numberPost);
            }
            //
            var listNumberStar = new List<int>();
            var listStar = _unitOfWork.rateAccountRepository.GetAll();
            for(int i = 1; i <= 5; i++)
            {
                var numberStar = listStar.Where(x=>(x.PostId!=null && x.Rate==i)).Count();
                listNumberStar.Add(numberStar);
            }
            return Json(new { ds = list,dsNumber = listNumberStar });
        }
    }
}
